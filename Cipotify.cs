using LibVLCSharp.Shared;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Web;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Cipotify
{
    public partial class Cipotify : Form
    {
        private LibVLCSharp.WinForms.VideoView videoView;
        private LibVLC libVLC;
        private MediaPlayer mediaPlayer;
        private string folderPath;
        public Cipotify()
        {
            InitializeComponent();
            Core.Initialize();

            libVLC = new LibVLC();
            mediaPlayer = new MediaPlayer(libVLC);

            this.videoView1.MediaPlayer = mediaPlayer;

            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            folderPath = Path.Combine(documentsPath, "Cipotify");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            cargarBotonesMusica();

        }

        private async void btn_descargar_video_Click(object sender, EventArgs e)
        {
            string videoUrl = caja_video_youtube.Text;
            Uri uri = new Uri(videoUrl);
            string videoId;

            string videoName = Microsoft.VisualBasic.Interaction.InputBox("Por favor, introduce el nombre del video:", "Descargar Video", "Ejemplo");
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
                var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

                if (streamInfo != null)
                {
                    await youtube.Videos.Streams.DownloadAsync(streamInfo, path);
                }
            }

            // Crea el media y reproduce el video
            using var media = new Media(libVLC, path, FromType.FromPath);
            mediaPlayer.Play(media);

            panel_musica.Controls.Clear();
            cargarBotonesMusica();
        }
        public void cargarBotonesMusica()
        {
            DirectoryInfo dir = new DirectoryInfo(folderPath);
            foreach (var file in dir.GetFiles())
            {
                Button button = new Button()
                {
                    Text = Path.GetFileNameWithoutExtension(file.Name),
                    Dock = DockStyle.Top,
                    Height = 40,
                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    Font = new Font("Arial", 10),
                    FlatStyle = FlatStyle.Flat,
                    TextAlign = ContentAlignment.TopLeft
                };

                button.FlatAppearance.BorderSize = 0;
                button.Margin = new Padding(0, 0, 0, 5);

                button.Click += (sender, e) =>
                {
                    string path = Path.Combine(folderPath, file.Name);
                    reproducirMusica(path);
                };
                panel_musica.Controls.Add(button);
            }
        }

        private void reproducirMusica(string path)
        {
            using var media = new Media(libVLC, path, FromType.FromPath);
            mediaPlayer.Play(media);
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
            mediaPlayer.Volume = ajustar_sonido.Value;
        }
        private async void enlace_actualizacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string currentVersion = "0.1";
            string owner = "cipotemanx";
            string repo = "W11-Debloater";

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
    }
}