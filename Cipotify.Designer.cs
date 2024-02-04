namespace Cipotify
{
    partial class Cipotify
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cipotify));
            caja_video_youtube = new TextBox();
            btn_descargar_video = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel_lateral = new Panel();
            btn_desplegar_ajustes = new Button();
            panel_datos = new Panel();
            enlace_actualizacion = new LinkLabel();
            enlace_github = new LinkLabel();
            panel_musica = new Panel();
            panel_biblioteca = new Panel();
            btn_crear_playlist = new Button();
            btn_desplegar_musica = new Button();
            panel_logo = new Panel();
            logo = new PictureBox();
            panel_inferior = new Panel();
            texto_reproduciendo = new Label();
            label_reproduciendo = new Label();
            btn_pantalla_completa = new Button();
            btn_siguiente = new Button();
            btn_anterior = new Button();
            ajustar_sonido = new TrackBar();
            btn_reproducir = new Button();
            btn_pausa = new Button();
            videoView1 = new LibVLCSharp.WinForms.VideoView();
            panel_contenido = new Panel();
            btn_minimizar_ventana = new Button();
            btn_cerrar_ventana = new Button();
            panel_descarga = new Panel();
            label1 = new Label();
            pb_descarga = new MetroFramework.Controls.MetroProgressBar();
            metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            trackbar_reproduccion = new MetroFramework.Controls.MetroTrackBar();
            panel_lateral.SuspendLayout();
            panel_datos.SuspendLayout();
            panel_biblioteca.SuspendLayout();
            panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panel_inferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ajustar_sonido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)videoView1).BeginInit();
            panel_contenido.SuspendLayout();
            panel_descarga.SuspendLayout();
            SuspendLayout();
            // 
            // caja_video_youtube
            // 
            caja_video_youtube.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            caja_video_youtube.ForeColor = SystemColors.WindowText;
            caja_video_youtube.Location = new Point(423, 11);
            caja_video_youtube.Name = "caja_video_youtube";
            caja_video_youtube.Size = new Size(253, 25);
            caja_video_youtube.TabIndex = 0;
            caja_video_youtube.Text = "Introduce un enlace de YouTube...";
            caja_video_youtube.Enter += caja_video_youtube_Enter;
            caja_video_youtube.Leave += caja_video_youtube_Leave;
            // 
            // btn_descargar_video
            // 
            btn_descargar_video.Location = new Point(342, 9);
            btn_descargar_video.Name = "btn_descargar_video";
            btn_descargar_video.Size = new Size(75, 29);
            btn_descargar_video.TabIndex = 1;
            btn_descargar_video.Text = "Descargar";
            btn_descargar_video.UseVisualStyleBackColor = true;
            btn_descargar_video.Click += btn_descargar_video_Click;
            // 
            // panel_lateral
            // 
            panel_lateral.BackColor = Color.FromArgb(24, 30, 54);
            panel_lateral.Controls.Add(btn_desplegar_ajustes);
            panel_lateral.Controls.Add(panel_datos);
            panel_lateral.Controls.Add(panel_musica);
            panel_lateral.Controls.Add(panel_biblioteca);
            panel_lateral.Controls.Add(panel_logo);
            panel_lateral.Dock = DockStyle.Left;
            panel_lateral.Location = new Point(0, 0);
            panel_lateral.Name = "panel_lateral";
            panel_lateral.Size = new Size(255, 757);
            panel_lateral.TabIndex = 2;
            // 
            // btn_desplegar_ajustes
            // 
            btn_desplegar_ajustes.BackColor = Color.FromArgb(24, 30, 54);
            btn_desplegar_ajustes.Cursor = Cursors.Hand;
            btn_desplegar_ajustes.Dock = DockStyle.Bottom;
            btn_desplegar_ajustes.FlatAppearance.BorderSize = 0;
            btn_desplegar_ajustes.FlatStyle = FlatStyle.Flat;
            btn_desplegar_ajustes.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_desplegar_ajustes.ForeColor = Color.Gainsboro;
            btn_desplegar_ajustes.Image = Properties.Resources.settings;
            btn_desplegar_ajustes.Location = new Point(0, 651);
            btn_desplegar_ajustes.Name = "btn_desplegar_ajustes";
            btn_desplegar_ajustes.Padding = new Padding(35, 0, 0, 0);
            btn_desplegar_ajustes.Size = new Size(255, 55);
            btn_desplegar_ajustes.TabIndex = 3;
            btn_desplegar_ajustes.Text = "AJUSTES";
            btn_desplegar_ajustes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_desplegar_ajustes.UseVisualStyleBackColor = false;
            btn_desplegar_ajustes.Click += btn_desplegar_ajustes_Click;
            // 
            // panel_datos
            // 
            panel_datos.BackColor = Color.FromArgb(41, 53, 65);
            panel_datos.Controls.Add(enlace_actualizacion);
            panel_datos.Controls.Add(enlace_github);
            panel_datos.Dock = DockStyle.Bottom;
            panel_datos.Location = new Point(0, 706);
            panel_datos.Name = "panel_datos";
            panel_datos.Size = new Size(255, 51);
            panel_datos.TabIndex = 3;
            // 
            // enlace_actualizacion
            // 
            enlace_actualizacion.AutoSize = true;
            enlace_actualizacion.LinkColor = Color.FromArgb(192, 255, 255);
            enlace_actualizacion.Location = new Point(3, 25);
            enlace_actualizacion.Name = "enlace_actualizacion";
            enlace_actualizacion.Size = new Size(140, 15);
            enlace_actualizacion.TabIndex = 4;
            enlace_actualizacion.TabStop = true;
            enlace_actualizacion.Text = "Comprobar actualización";
            enlace_actualizacion.LinkClicked += enlace_actualizacion_LinkClicked;
            // 
            // enlace_github
            // 
            enlace_github.AutoSize = true;
            enlace_github.LinkColor = Color.FromArgb(192, 255, 255);
            enlace_github.Location = new Point(3, 7);
            enlace_github.Name = "enlace_github";
            enlace_github.Size = new Size(108, 15);
            enlace_github.TabIndex = 3;
            enlace_github.TabStop = true;
            enlace_github.Text = "Sígueme en Github";
            enlace_github.LinkClicked += enlace_github_LinkClicked;
            // 
            // panel_musica
            // 
            panel_musica.AutoScroll = true;
            panel_musica.BackColor = Color.FromArgb(33, 33, 43);
            panel_musica.Dock = DockStyle.Fill;
            panel_musica.Location = new Point(0, 133);
            panel_musica.Name = "panel_musica";
            panel_musica.Size = new Size(255, 624);
            panel_musica.TabIndex = 4;
            // 
            // panel_biblioteca
            // 
            panel_biblioteca.Controls.Add(btn_crear_playlist);
            panel_biblioteca.Controls.Add(btn_desplegar_musica);
            panel_biblioteca.Dock = DockStyle.Top;
            panel_biblioteca.Location = new Point(0, 79);
            panel_biblioteca.Name = "panel_biblioteca";
            panel_biblioteca.Size = new Size(255, 54);
            panel_biblioteca.TabIndex = 1;
            // 
            // btn_crear_playlist
            // 
            btn_crear_playlist.BackColor = Color.Transparent;
            btn_crear_playlist.BackgroundImage = Properties.Resources.plus;
            btn_crear_playlist.BackgroundImageLayout = ImageLayout.Zoom;
            btn_crear_playlist.FlatAppearance.BorderSize = 0;
            btn_crear_playlist.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_crear_playlist.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_crear_playlist.FlatStyle = FlatStyle.Flat;
            btn_crear_playlist.Location = new Point(173, 6);
            btn_crear_playlist.Name = "btn_crear_playlist";
            btn_crear_playlist.Size = new Size(38, 42);
            btn_crear_playlist.TabIndex = 1;
            btn_crear_playlist.UseVisualStyleBackColor = false;
            btn_crear_playlist.Click += btn_crear_playlist_Click;
            // 
            // btn_desplegar_musica
            // 
            btn_desplegar_musica.BackColor = Color.FromArgb(24, 30, 54);
            btn_desplegar_musica.BackgroundImageLayout = ImageLayout.None;
            btn_desplegar_musica.Cursor = Cursors.Hand;
            btn_desplegar_musica.Dock = DockStyle.Top;
            btn_desplegar_musica.FlatAppearance.BorderSize = 0;
            btn_desplegar_musica.FlatStyle = FlatStyle.Flat;
            btn_desplegar_musica.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_desplegar_musica.ForeColor = Color.Gainsboro;
            btn_desplegar_musica.Image = Properties.Resources.musica;
            btn_desplegar_musica.Location = new Point(0, 0);
            btn_desplegar_musica.Name = "btn_desplegar_musica";
            btn_desplegar_musica.Padding = new Padding(15, 0, 0, 0);
            btn_desplegar_musica.Size = new Size(255, 54);
            btn_desplegar_musica.TabIndex = 0;
            btn_desplegar_musica.Text = "BIBLIOTECA";
            btn_desplegar_musica.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_desplegar_musica.UseVisualStyleBackColor = false;
            btn_desplegar_musica.Click += btn_desplegar_musica_Click;
            // 
            // panel_logo
            // 
            panel_logo.BackColor = Color.FromArgb(41, 53, 65);
            panel_logo.Controls.Add(logo);
            panel_logo.Dock = DockStyle.Top;
            panel_logo.Location = new Point(0, 0);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(255, 79);
            panel_logo.TabIndex = 0;
            // 
            // logo
            // 
            logo.BackColor = Color.FromArgb(24, 30, 54);
            logo.BackgroundImage = Properties.Resources.cipotify;
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.Dock = DockStyle.Fill;
            logo.Image = Properties.Resources.cipotify;
            logo.Location = new Point(0, 0);
            logo.Name = "logo";
            logo.Size = new Size(255, 79);
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // panel_inferior
            // 
            panel_inferior.BackColor = Color.FromArgb(40, 53, 69);
            panel_inferior.Controls.Add(texto_reproduciendo);
            panel_inferior.Controls.Add(label_reproduciendo);
            panel_inferior.Controls.Add(btn_pantalla_completa);
            panel_inferior.Controls.Add(btn_siguiente);
            panel_inferior.Controls.Add(btn_anterior);
            panel_inferior.Controls.Add(ajustar_sonido);
            panel_inferior.Controls.Add(btn_reproducir);
            panel_inferior.Controls.Add(btn_pausa);
            panel_inferior.Controls.Add(btn_descargar_video);
            panel_inferior.Controls.Add(caja_video_youtube);
            panel_inferior.Dock = DockStyle.Bottom;
            panel_inferior.Location = new Point(255, 702);
            panel_inferior.Name = "panel_inferior";
            panel_inferior.Size = new Size(963, 55);
            panel_inferior.TabIndex = 4;
            // 
            // texto_reproduciendo
            // 
            texto_reproduciendo.AutoSize = true;
            texto_reproduciendo.ForeColor = Color.White;
            texto_reproduciendo.Location = new Point(19, 28);
            texto_reproduciendo.Name = "texto_reproduciendo";
            texto_reproduciendo.Size = new Size(0, 15);
            texto_reproduciendo.TabIndex = 12;
            texto_reproduciendo.Visible = false;
            // 
            // label_reproduciendo
            // 
            label_reproduciendo.AutoSize = true;
            label_reproduciendo.ForeColor = Color.White;
            label_reproduciendo.Location = new Point(19, 9);
            label_reproduciendo.Name = "label_reproduciendo";
            label_reproduciendo.Size = new Size(91, 15);
            label_reproduciendo.TabIndex = 11;
            label_reproduciendo.Text = "Reproduciendo:";
            label_reproduciendo.Visible = false;
            // 
            // btn_pantalla_completa
            // 
            btn_pantalla_completa.BackgroundImage = Properties.Resources.expandir;
            btn_pantalla_completa.BackgroundImageLayout = ImageLayout.Center;
            btn_pantalla_completa.Dock = DockStyle.Right;
            btn_pantalla_completa.FlatAppearance.BorderSize = 0;
            btn_pantalla_completa.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_pantalla_completa.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_pantalla_completa.FlatStyle = FlatStyle.Flat;
            btn_pantalla_completa.Location = new Point(908, 0);
            btn_pantalla_completa.Name = "btn_pantalla_completa";
            btn_pantalla_completa.Size = new Size(55, 55);
            btn_pantalla_completa.TabIndex = 10;
            btn_pantalla_completa.UseVisualStyleBackColor = true;
            btn_pantalla_completa.Click += btn_pantalla_completa_Click;
            // 
            // btn_siguiente
            // 
            btn_siguiente.BackColor = Color.FromArgb(40, 53, 69);
            btn_siguiente.BackgroundImage = Properties.Resources.next;
            btn_siguiente.BackgroundImageLayout = ImageLayout.Stretch;
            btn_siguiente.FlatAppearance.BorderSize = 0;
            btn_siguiente.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_siguiente.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_siguiente.FlatStyle = FlatStyle.Flat;
            btn_siguiente.Location = new Point(278, 6);
            btn_siguiente.Name = "btn_siguiente";
            btn_siguiente.Size = new Size(39, 35);
            btn_siguiente.TabIndex = 9;
            btn_siguiente.UseVisualStyleBackColor = false;
            btn_siguiente.Click += btn_siguiente_Click;
            // 
            // btn_anterior
            // 
            btn_anterior.BackColor = Color.FromArgb(40, 53, 69);
            btn_anterior.BackgroundImage = Properties.Resources.back;
            btn_anterior.BackgroundImageLayout = ImageLayout.Stretch;
            btn_anterior.FlatAppearance.BorderSize = 0;
            btn_anterior.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_anterior.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_anterior.FlatStyle = FlatStyle.Flat;
            btn_anterior.Location = new Point(233, 7);
            btn_anterior.Name = "btn_anterior";
            btn_anterior.Size = new Size(39, 35);
            btn_anterior.TabIndex = 8;
            btn_anterior.UseVisualStyleBackColor = false;
            btn_anterior.Click += btn_anterior_Click;
            // 
            // ajustar_sonido
            // 
            ajustar_sonido.Location = new Point(710, 7);
            ajustar_sonido.Maximum = 100;
            ajustar_sonido.Name = "ajustar_sonido";
            ajustar_sonido.Size = new Size(104, 45);
            ajustar_sonido.TabIndex = 7;
            ajustar_sonido.TickFrequency = 10;
            ajustar_sonido.Value = 100;
            ajustar_sonido.Scroll += ajustar_sonido_Scroll;
            // 
            // btn_reproducir
            // 
            btn_reproducir.BackColor = Color.FromArgb(40, 53, 69);
            btn_reproducir.BackgroundImage = Properties.Resources.reproducir;
            btn_reproducir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_reproducir.FlatAppearance.BorderSize = 0;
            btn_reproducir.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_reproducir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_reproducir.FlatStyle = FlatStyle.Flat;
            btn_reproducir.Location = new Point(170, -1);
            btn_reproducir.Name = "btn_reproducir";
            btn_reproducir.Size = new Size(57, 51);
            btn_reproducir.TabIndex = 6;
            btn_reproducir.UseVisualStyleBackColor = false;
            btn_reproducir.Visible = false;
            btn_reproducir.Click += btn_reproducir_Click;
            // 
            // btn_pausa
            // 
            btn_pausa.BackColor = Color.FromArgb(40, 53, 69);
            btn_pausa.BackgroundImage = Properties.Resources.pausa;
            btn_pausa.BackgroundImageLayout = ImageLayout.Stretch;
            btn_pausa.FlatAppearance.BorderSize = 0;
            btn_pausa.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_pausa.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_pausa.FlatStyle = FlatStyle.Flat;
            btn_pausa.Location = new Point(179, 6);
            btn_pausa.Name = "btn_pausa";
            btn_pausa.Size = new Size(41, 37);
            btn_pausa.TabIndex = 5;
            btn_pausa.UseVisualStyleBackColor = false;
            btn_pausa.Click += btn_pausa_Click;
            // 
            // videoView1
            // 
            videoView1.BackColor = Color.FromArgb(54, 59, 71);
            videoView1.Dock = DockStyle.Fill;
            videoView1.Location = new Point(0, 0);
            videoView1.MediaPlayer = null;
            videoView1.Name = "videoView1";
            videoView1.Size = new Size(963, 702);
            videoView1.TabIndex = 5;
            // 
            // panel_contenido
            // 
            panel_contenido.Controls.Add(btn_minimizar_ventana);
            panel_contenido.Controls.Add(btn_cerrar_ventana);
            panel_contenido.Controls.Add(panel_descarga);
            panel_contenido.Controls.Add(trackbar_reproduccion);
            panel_contenido.Controls.Add(videoView1);
            panel_contenido.Dock = DockStyle.Fill;
            panel_contenido.Location = new Point(255, 0);
            panel_contenido.Name = "panel_contenido";
            panel_contenido.Size = new Size(963, 702);
            panel_contenido.TabIndex = 6;
            // 
            // btn_minimizar_ventana
            // 
            btn_minimizar_ventana.BackColor = Color.FromArgb(54, 59, 71);
            btn_minimizar_ventana.FlatAppearance.BorderSize = 0;
            btn_minimizar_ventana.FlatStyle = FlatStyle.Flat;
            btn_minimizar_ventana.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_minimizar_ventana.ForeColor = Color.White;
            btn_minimizar_ventana.Location = new Point(913, 0);
            btn_minimizar_ventana.Name = "btn_minimizar_ventana";
            btn_minimizar_ventana.Size = new Size(25, 25);
            btn_minimizar_ventana.TabIndex = 11;
            btn_minimizar_ventana.Text = "-";
            btn_minimizar_ventana.UseVisualStyleBackColor = false;
            btn_minimizar_ventana.Click += btn_minimizar_ventana_Click;
            // 
            // btn_cerrar_ventana
            // 
            btn_cerrar_ventana.BackColor = Color.FromArgb(54, 59, 71);
            btn_cerrar_ventana.FlatAppearance.BorderSize = 0;
            btn_cerrar_ventana.FlatStyle = FlatStyle.Flat;
            btn_cerrar_ventana.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cerrar_ventana.ForeColor = Color.White;
            btn_cerrar_ventana.Location = new Point(938, 0);
            btn_cerrar_ventana.Name = "btn_cerrar_ventana";
            btn_cerrar_ventana.Size = new Size(25, 25);
            btn_cerrar_ventana.TabIndex = 10;
            btn_cerrar_ventana.Text = "X";
            btn_cerrar_ventana.UseVisualStyleBackColor = false;
            btn_cerrar_ventana.Click += btn_cerrar_ventana_Click;
            // 
            // panel_descarga
            // 
            panel_descarga.BackColor = Color.FromArgb(37, 42, 64);
            panel_descarga.Controls.Add(label1);
            panel_descarga.Controls.Add(pb_descarga);
            panel_descarga.Controls.Add(metroProgressSpinner1);
            panel_descarga.Location = new Point(298, 242);
            panel_descarga.Name = "panel_descarga";
            panel_descarga.Size = new Size(294, 142);
            panel_descarga.TabIndex = 9;
            panel_descarga.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(3, 24);
            label1.Name = "label1";
            label1.Size = new Size(257, 21);
            label1.TabIndex = 9;
            label1.Text = "Espere a que finalice la descarga";
            // 
            // pb_descarga
            // 
            pb_descarga.Dock = DockStyle.Bottom;
            pb_descarga.Location = new Point(0, 119);
            pb_descarga.Name = "pb_descarga";
            pb_descarga.Size = new Size(294, 23);
            pb_descarga.TabIndex = 7;
            // 
            // metroProgressSpinner1
            // 
            metroProgressSpinner1.Location = new Point(266, 29);
            metroProgressSpinner1.Maximum = 100;
            metroProgressSpinner1.Name = "metroProgressSpinner1";
            metroProgressSpinner1.Size = new Size(16, 16);
            metroProgressSpinner1.TabIndex = 8;
            metroProgressSpinner1.Text = "metroProgressSpinner1";
            // 
            // trackbar_reproduccion
            // 
            trackbar_reproduccion.BackColor = Color.Transparent;
            trackbar_reproduccion.Dock = DockStyle.Bottom;
            trackbar_reproduccion.ForeColor = SystemColors.ControlText;
            trackbar_reproduccion.Location = new Point(0, 679);
            trackbar_reproduccion.Name = "trackbar_reproduccion";
            trackbar_reproduccion.Size = new Size(963, 23);
            trackbar_reproduccion.TabIndex = 6;
            trackbar_reproduccion.Text = "metroTrackBar1";
            trackbar_reproduccion.Scroll += trackbar_reproduccion_Scroll;
            trackbar_reproduccion.MouseDown += trackbar_reproduccion_MouseDown;
            trackbar_reproduccion.MouseUp += trackbar_reproduccion_MouseUp;
            // 
            // Cipotify
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 757);
            Controls.Add(panel_contenido);
            Controls.Add(panel_inferior);
            Controls.Add(panel_lateral);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(1218, 757);
            Name = "Cipotify";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cipotify";
            panel_lateral.ResumeLayout(false);
            panel_datos.ResumeLayout(false);
            panel_datos.PerformLayout();
            panel_biblioteca.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panel_inferior.ResumeLayout(false);
            panel_inferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ajustar_sonido).EndInit();
            ((System.ComponentModel.ISupportInitialize)videoView1).EndInit();
            panel_contenido.ResumeLayout(false);
            panel_descarga.ResumeLayout(false);
            panel_descarga.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox caja_video_youtube;
        private Button btn_descargar_video;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel_lateral;
        private Panel panel_inferior;
        private Panel panel_biblioteca;
        private Panel panel_logo;
        private Panel panel_musica;
        private Button btn_desplegar_musica;
        private Button btn_pausa;
        private Button btn_reproducir;
        private PictureBox logo;
        private LinkLabel enlace_github;
        private Panel panel_datos;
        private LibVLCSharp.WinForms.VideoView videoView1;
        private TrackBar ajustar_sonido;
        private LinkLabel enlace_actualizacion;
        private Button btn_desplegar_ajustes;
        private Panel panel_contenido;
        private Button btn_anterior;
        private Button btn_siguiente;
        private MetroFramework.Controls.MetroTrackBar trackbar_reproduccion;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroProgressBar pb_descarga;
        private Panel panel_descarga;
        private Label label1;
        private Button btn_pantalla_completa;
        private Button btn_crear_playlist;
        private Label texto_reproduciendo;
        private Label label_reproduciendo;
        private Button btn_cerrar_ventana;
        private Button btn_minimizar_ventana;
    }
}