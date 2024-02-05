using LibVLCSharp.Shared;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Web;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Cipotify
{
    public partial class Cipotify : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHrighEllipse
            );

        private Region roundedRegion;
        private LibVLCSharp.WinForms.VideoView videoView;
        private LibVLC libVLC;
        private MediaPlayer mediaPlayer;
        public int CancionActual { get; set; } = -1;
        public bool ReproducirAutomaticamente { get; set; } = false;

        private string folderPath;
        private Media currentMedia;
        private System.Windows.Forms.Timer timer;
        private bool userIsDraggingTrackbar = false;
        public string FormatoSeleccionado { get; set; }
        private Rectangle lastFormRectangle;
        private bool esPantallaCompleta = false;

        private const int DragThreshold = 5; // Umbral para iniciar arrastre, en píxeles
        private bool isDragging = false;
        private Point mouseDownLocation;
        private bool reproduciendo = false;

        public Cipotify()
        {
            InitializeComponent();
            Core.Initialize();

            AplicarBordesRedondeados();

            panel_musica.Visible = true;

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 500;
            timer.Tick += (sender, e) => ActualizarBarraDeProgreso();
            timer.Start();

            libVLC = new LibVLC();
            mediaPlayer = new MediaPlayer(libVLC);

            mediaPlayer.EndReached += async (sender, e) =>
            {
                if (this.ReproducirAutomaticamente)
                {
                    await Task.Delay(1000);
                    mediaPlayer.Stop();

                    ReproducirSiguienteCancion();
                }
            };

            this.videoView1.MediaPlayer = mediaPlayer;

            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            folderPath = Path.Combine(documentsPath, "Cipotify");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            cargarBotonesMusica();
        }

        private void AplicarBordesRedondeados()
        {
            this.Region?.Dispose();

            IntPtr hRgn = CreateRoundRectRgn(0, 0, this.Width, this.Height, 25, 25);
            this.Region = System.Drawing.Region.FromHrgn(hRgn);
        }

        private void caja_video_youtube_Enter(object sender, EventArgs e)
        {
            if (caja_video_youtube.Text == "Introduce un enlace de YouTube...")
            {
                caja_video_youtube.Text = "";
                //caja_video_youtube.ForeColor = Color.Black;
            }
        }

        private void caja_video_youtube_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(caja_video_youtube.Text))
            {
                caja_video_youtube.Text = "Introduce un enlace de YouTube...";
                //caja_video_youtube.ForeColor = Color.Gray;
            }
        }

        private async void btn_descargar_video_Click(object sender, EventArgs e)
        {
            string videoUrl = caja_video_youtube.Text;
            Uri uri;

            try
            {
                uri = new Uri(videoUrl);
            }
            catch (UriFormatException)
            {
                MessageBox.Show("Por favor, introduce una URL válida de YouTube.");
                return;
            }

            if (uri.Host != "youtu.be" && uri.Host != "www.youtube.com")
            {
                MessageBox.Show("Por favor, introduce una URL válida de YouTube.");
                return;
            }

            string videoId;
            string videoName = Microsoft.VisualBasic.Interaction.InputBox("Por favor, introduce el nombre del video:", "Descargar Video", "Ejemplo");

            if (string.IsNullOrEmpty(videoName.Trim()))
            {
                MessageBox.Show("Por favor, introduce un nombre para el video.");
                return;
            }

            string path = Path.Combine(folderPath, $"{videoName}.mp4");

            if (uri.Host == "youtu.be")
            {
                videoId = uri.AbsolutePath.Substring(1);
            }
            else
            {
                var query = HttpUtility.ParseQueryString(uri.Query);
                videoId = query.Get("v");
            }

            if (!File.Exists(path))
            {
                var youtube = new YoutubeClient();
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoId);
                IStreamInfo streamInfo = null;

                panel_descarga.Visible = true;

                pb_descarga.Minimum = 0;
                pb_descarga.Maximum = 100;
                pb_descarga.Value = 0;

                var progressHandler = new Progress<double>(p => pb_descarga.Value = (int)(p * 100));

                switch (this.FormatoSeleccionado)
                {
                    case "MP3":
                        streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                        if (streamInfo != null)
                        {
                            path = Path.Combine(folderPath, $"{videoName}.webm");
                            await youtube.Videos.Streams.DownloadAsync(streamInfo, path, progressHandler);
                        }
                        break;

                    case "FLAC":
                        streamInfo = streamManifest.GetAudioStreams().GetWithHighestBitrate();
                        if (streamInfo != null)
                        {
                            var tempPath = path.Replace(".mp4", ".mp3");
                            await youtube.Videos.Streams.DownloadAsync(streamInfo, tempPath, progressHandler);
                        }
                        break;

                    case "MP4":
                    default:
                        streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                        if (streamInfo != null)
                        {
                            await youtube.Videos.Streams.DownloadAsync(streamInfo, path, progressHandler);
                        }
                        break;
                }
                panel_descarga.Visible = false;
            }

            texto_reproduciendo.Text = videoName;
            label_reproduciendo.Visible = true;
            texto_reproduciendo.Visible = true;

            using var media = new Media(libVLC, path, FromType.FromPath);
            mediaPlayer.Play(media);

            limpiarPanelMusica();
            cargarBotonesMusica();
        }

        private void btn_crear_playlist_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Introduce el nombre de la playlist:", "Nueva Playlist", "");

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("El nombre de la playlist no puede estar vacío.");
                return;
            }
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            folderPath = Path.Combine(documentsPath, "Cipotify");
            string pathToCreate = Path.Combine(folderPath, input);

            if (!Directory.Exists(pathToCreate))
            {
                Directory.CreateDirectory(pathToCreate);
                limpiarPanelMusica();
                cargarBotonesMusica();
            }
            else
            {
                MessageBox.Show("Ya existe una playlist con ese nombre.");
            }
        }

        public void limpiarPanelMusica()
        {
            panel_musica.Controls.Clear();
        }

        public void cargarBotonesMusica()
        {
            panel_musica.SuspendLayout(); // Detiene el diseño temporalmente

            DirectoryInfo mainDir = new DirectoryInfo(folderPath);

            panel_musica.AllowDrop = true;

            panel_musica.DragEnter += (sender, e) =>
            {
                if (e.Data.GetDataPresent(DataFormats.StringFormat))
                {
                    e.Effect = DragDropEffects.Move;
                }
            };

            panel_musica.DragDrop += (sender, e) =>
            {
                string sourceFilePath = (string)e.Data.GetData(DataFormats.StringFormat);
                string targetFilePath = Path.Combine(mainDir.FullName, Path.GetFileName(sourceFilePath));

                if (!File.Exists(targetFilePath))
                {
                    File.Move(sourceFilePath, targetFilePath);
                    limpiarPanelMusica();
                    cargarBotonesMusica();
                }
            };

            // Cargar las canciones que no están en ninguna playlist
            foreach (var filePattern in new[] { "*.mp3", "*.mp4" })
            {
                foreach (var file in mainDir.GetFiles(filePattern))
                {
                    AddSongButton(file, panel_musica);
                }
            }

            // Cargar las canciones dentro de cada subdirectorio (playlist)
            foreach (var dir in mainDir.GetDirectories())
            {
                Panel songsPanel = new Panel()
                {
                    Dock = DockStyle.Top,
                    Height = 0,
                    BackColor = Color.White
                };
                songsPanel.Padding = new Padding(0);

                foreach (var filePattern in new[] { "*.mp3", "*.mp4" })
                {
                    foreach (var file in dir.GetFiles(filePattern))
                    {
                        AddSongButton(file, songsPanel, isInPlaylist: true);
                    }
                }

                panel_musica.Controls.Add(songsPanel);

                Panel playlistPanel = new Panel()
                {
                    Dock = DockStyle.Top,
                    Height = 50,
                    //BackColor = Color.FromArgb(240, 240, 240)
                    BackColor = Color.FromArgb(85, 85, 115)
                };

                Button playlistButton = new Button()
                {
                    Text = dir.Name,
                    Dock = DockStyle.Fill,
                    //BackColor = Color.FromArgb(240, 240, 240),
                    //ForeColor = Color.FromArgb(50, 50, 50),
                    BackColor = Color.FromArgb(85, 85, 115),
                    ForeColor = Color.FromArgb(255, 255, 255),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Arial", 11, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                playlistButton.FlatAppearance.MouseOverBackColor = playlistButton.BackColor;
                playlistButton.FlatAppearance.BorderSize = 0;

                playlistButton.AllowDrop = true;

                playlistButton.DragEnter += (sender, e) =>
                {
                    if (e.Data.GetDataPresent(DataFormats.StringFormat))
                    {
                        e.Effect = DragDropEffects.Move;
                    }
                };

                playlistButton.DragDrop += (sender, e) =>
                {
                    string sourceFilePath = (string)e.Data.GetData(DataFormats.StringFormat);
                    string targetFilePath = Path.Combine(dir.FullName, Path.GetFileName(sourceFilePath));

                    if (!File.Exists(targetFilePath)) // Asegurarse de que el archivo no exista ya en la carpeta de destino
                    {
                        File.Move(sourceFilePath, targetFilePath); // Mover el archivo
                        limpiarPanelMusica();
                        cargarBotonesMusica();
                    }
                };

                Button trashButton = new Button()
                {
                    Dock = DockStyle.Right,
                    Width = 50,
                    FlatStyle = FlatStyle.Flat,
                    BackgroundImageLayout = ImageLayout.Center,
                    BackgroundImage = Properties.Resources.TrashIcon,
                    BackColor = Color.Transparent,
                    ForeColor = Color.Transparent,
                    Tag = dir.FullName
                };

                trashButton.FlatAppearance.BorderSize = 0;
                trashButton.FlatAppearance.MouseOverBackColor = trashButton.BackColor;

                trashButton.Click += (sender, e) =>
                {
                    string directoryToDelete = (sender as Button).Tag.ToString();
                    DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta playlist?", "Eliminar Playlist", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Directory.Delete(directoryToDelete, true);
                        limpiarPanelMusica();
                        cargarBotonesMusica();
                    }
                };

                playlistPanel.Controls.Add(playlistButton);
                playlistPanel.Controls.Add(trashButton);
                panel_musica.Controls.Add(playlistPanel);

                playlistButton.Click += (sender, e) =>
                {
                    if (songsPanel.Height == 0)
                    {
                        int totalHeight = 0;
                        foreach (Control control in songsPanel.Controls)
                        {
                            totalHeight += control.Height;
                        }
                        songsPanel.Height = totalHeight;
                    }
                    else
                    {
                        songsPanel.Height = 0;
                    }
                };
            }

            panel_musica.ResumeLayout(true);
        }
        private void AddSongButton(FileInfo file, Panel panel, bool isInPlaylist = false)
        {
            Button button = new Button()
            {
                Text = Path.GetFileNameWithoutExtension(file.Name),
                Dock = DockStyle.Top,
                Height = 40,
                //BackColor = isInPlaylist ? Color.FromArgb(240, 240, 240) : Color.White,
                BackColor = isInPlaylist ? Color.FromArgb(85, 85, 115) : Color.White,
                ForeColor = isInPlaylist ? Color.White : Color.Black,
                Font = new Font("Arial", 10),
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleLeft
            };

            button.FlatAppearance.BorderSize = 0;

            button.MouseDown += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    mouseDownLocation = e.Location;
                    isDragging = false;
                }
            };

            button.MouseMove += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (!isDragging && (Math.Abs(e.X - mouseDownLocation.X) > DragThreshold || Math.Abs(e.Y - mouseDownLocation.Y) > DragThreshold))
                    {
                        isDragging = true;
                        // Inicia el arrastre aquí
                        button.DoDragDrop(file.FullName, DragDropEffects.Move);
                    }
                }
            };

            button.MouseUp += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left && !isDragging)
                {
                    // Ejecuta la lógica de clic aquí, es decir, reproducir la canción
                    CancionActual = panel.Controls.GetChildIndex(button);
                    string path = Path.Combine(file.DirectoryName, file.Name);
                    reproducirMusica(path);
                }
            };
            panel.Controls.Add(button);
        }

        private void reproducirMusica(string path)
        {
            mediaPlayer.Stop();

            if (currentMedia != null)
            {
                currentMedia.Dispose();
                currentMedia = null;
            }

            label_reproduciendo.Visible = true;
            texto_reproduciendo.Visible = true;

            string nombreCancion = Path.GetFileNameWithoutExtension(path);
            texto_reproduciendo.Text = nombreCancion;

            currentMedia = new Media(libVLC, path, FromType.FromPath);
            mediaPlayer.Play(currentMedia);

        }
        private void ReproducirSiguienteCancion()
        {
            if (reproduciendo) return;

            reproduciendo = true;
            this.Invoke((MethodInvoker)delegate
            {
                CancionActual++;
                if (CancionActual >= panel_musica.Controls.Count)
                {
                    CancionActual = 0;
                }

                // Verificación adicional para evitar NullReferenceException
                if (panel_musica.Controls[CancionActual] is Button siguienteBoton)
                {
                    string path = Path.Combine(folderPath, $"{siguienteBoton.Text}.mp4");
                    if (File.Exists(path))
                    {
                        reproducirMusica(path);
                    }
                }
                reproduciendo = false;
            });
        }
        private void ReproducirCancionAnterior()
        {
            if (reproduciendo) return;

            reproduciendo = true;
            this.Invoke((MethodInvoker)delegate
            {
                CancionActual--;
                if (CancionActual < 0)
                {
                    CancionActual = panel_musica.Controls.Count - 1;
                }

                // Verificación adicional para evitar NullReferenceException
                if (panel_musica.Controls[CancionActual] is Button anteriorBoton)
                {
                    string path = Path.Combine(folderPath, $"{anteriorBoton.Text}.mp4");
                    if (File.Exists(path))
                    {
                        reproducirMusica(path);
                    }
                }
                reproduciendo = false;
            });
        }

        private void HandleEndReached(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                CancionActual++;
                if (CancionActual >= panel_musica.Controls.Count)
                {
                    CancionActual = 0;
                }

                var siguienteBoton = panel_musica.Controls[CancionActual] as Button;
                string path = Path.Combine(folderPath, $"{siguienteBoton.Text}.mp4");
                reproducirMusica(path);
            });
        }


        private void btn_desplegar_musica_Click(object sender, EventArgs e)
        {
            panel_musica.Visible = !panel_musica.Visible;
        }

        private void btn_pausa_Click(object sender, EventArgs e)
        {
            if (mediaPlayer.IsPlaying)
            {
                mediaPlayer.Pause();
                btn_pausa.Visible = false;
                btn_reproducir.Visible = true;
            }
        }
        private void btn_reproducir_Click(object sender, EventArgs e)
        {
            mediaPlayer.Play();
            btn_pausa.Visible = true;
            btn_reproducir.Visible = false;
        }

        private void enlace_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/cipotemanx";
            Process.Start(new ProcessStartInfo() { FileName = url, UseShellExecute = true });
        }

        private void ajustar_sonido_Scroll(object sender, EventArgs e)
        {
            double scaledValue = Math.Pow(ajustar_sonido.Value / 100.0, 0.3) * 100.0;
            mediaPlayer.Volume = (int)scaledValue;
        }

        private async void enlace_actualizacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string currentVersion = "0.4";
            string owner = "cipotemanx";
            string repo = "cipotify";

            string url = $"https://api.github.com/repos/{owner}/{repo}/releases/latest";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "request");

            var response = await client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            dynamic latestRelease = JsonConvert.DeserializeObject(content);
            string latestVersion = latestRelease.tag_name;

            if (latestVersion != currentVersion)
            {
                MessageBox.Show("Hay una nueva versión disponible!");
            }
            else
            {
                MessageBox.Show("Estás utilizando la versión más reciente");
            }
        }
        private void btn_desplegar_ajustes_Click(object sender, EventArgs e)
        {
            Forms.FormularioAjustes ajustes = new Forms.FormularioAjustes();
            ajustes.formularioPrincipal = this;
            ajustes.TopLevel = false;
            ajustes.FormBorderStyle = FormBorderStyle.None;
            ajustes.Dock = DockStyle.Fill;
            videoView1.Visible = false;
            panel_contenido.Controls.Add(ajustes);
            ajustes.Show();
        }

        public void CambiarVisibilidadVideoView1(bool visible)
        {
            videoView1.Visible = visible;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            ReproducirSiguienteCancion();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            ReproducirCancionAnterior();
        }

        private void trackbar_reproduccion_Scroll(object sender, ScrollEventArgs e)
        {
            mediaPlayer.Time = trackbar_reproduccion.Value * 1000;
        }

        private void trackbar_reproduccion_MouseDown(object sender, MouseEventArgs e)
        {
            userIsDraggingTrackbar = true;
        }

        private void trackbar_reproduccion_MouseUp(object sender, MouseEventArgs e)
        {
            userIsDraggingTrackbar = false;
            mediaPlayer.Time = trackbar_reproduccion.Value * 1000;
        }
        private void ActualizarBarraDeProgreso()
        {
            if (mediaPlayer.State == VLCState.Playing)
            {
                if (mediaPlayer.Length > 0)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.trackbar_reproduccion.Visible = true;
                        trackbar_reproduccion.Maximum = (int)(mediaPlayer.Length / 1000);
                        if (!userIsDraggingTrackbar)
                        {
                            trackbar_reproduccion.Value = (int)(mediaPlayer.Time / 1000);
                        }
                    });
                }
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.trackbar_reproduccion.Visible = false;
                });
            }
        }

        private void btn_pantalla_completa_Click(object sender, EventArgs e)
        {
            CambiarPantallaCompleta();
        }

        private void CambiarPantallaCompleta()
        {
            if (esPantallaCompleta)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Bounds = lastFormRectangle;
                panel_lateral.Visible = true;
                videoView1.Dock = DockStyle.None;

                this.Region = roundedRegion;
                btn_cerrar_ventana.Visible = true;
                esPantallaCompleta = false;
                AplicarBordesRedondeados();
            }
            else
            {
                lastFormRectangle = this.Bounds;
                this.Region = null;
                this.Bounds = Screen.FromControl(this).Bounds;
                btn_cerrar_ventana.Visible = false;
                videoView1.Dock = DockStyle.Fill;
                panel_lateral.Visible = false;

                esPantallaCompleta = true;
            }

            // Forzar un refresco del diseño.
            this.PerformLayout();
        }

        private void Formulario_Resize(object sender, EventArgs e)
        {
            if (!esPantallaCompleta)
            {
                AplicarBordesRedondeados();
            }
        }


        private void btn_cerrar_ventana_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_ventana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}