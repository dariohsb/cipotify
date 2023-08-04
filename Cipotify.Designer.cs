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
            caja_video_youtube = new TextBox();
            btn_descargar_video = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel_lateral = new Panel();
            panel_datos = new Panel();
            enlace_github = new LinkLabel();
            panel_musica = new Panel();
            panel_biblioteca = new Panel();
            btn_desplegar_musica = new Button();
            panel_logo = new Panel();
            logo = new PictureBox();
            panel_inferior = new Panel();
            ajustar_sonido = new TrackBar();
            btn_reproducir = new Button();
            btn_pausa = new Button();
            videoView1 = new LibVLCSharp.WinForms.VideoView();
            panel_lateral.SuspendLayout();
            panel_datos.SuspendLayout();
            panel_biblioteca.SuspendLayout();
            panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panel_inferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ajustar_sonido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)videoView1).BeginInit();
            SuspendLayout();
            // 
            // caja_video_youtube
            // 
            caja_video_youtube.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            caja_video_youtube.Location = new Point(203, 11);
            caja_video_youtube.Name = "caja_video_youtube";
            caja_video_youtube.Size = new Size(253, 29);
            caja_video_youtube.TabIndex = 0;
            caja_video_youtube.Text = "Introduce un enlace de youtube...";
            // 
            // btn_descargar_video
            // 
            btn_descargar_video.Location = new Point(113, 6);
            btn_descargar_video.Name = "btn_descargar_video";
            btn_descargar_video.Size = new Size(75, 40);
            btn_descargar_video.TabIndex = 1;
            btn_descargar_video.Text = "Descargar";
            btn_descargar_video.UseVisualStyleBackColor = true;
            btn_descargar_video.Click += btn_descargar_video_Click;
            // 
            // panel_lateral
            // 
            panel_lateral.BackColor = Color.FromArgb(33, 33, 43);
            panel_lateral.Controls.Add(panel_datos);
            panel_lateral.Controls.Add(panel_musica);
            panel_lateral.Controls.Add(panel_biblioteca);
            panel_lateral.Controls.Add(panel_logo);
            panel_lateral.Dock = DockStyle.Left;
            panel_lateral.Location = new Point(0, 0);
            panel_lateral.Name = "panel_lateral";
            panel_lateral.Size = new Size(204, 450);
            panel_lateral.TabIndex = 2;
            // 
            // panel_datos
            // 
            panel_datos.BackColor = Color.FromArgb(41, 53, 65);
            panel_datos.Controls.Add(enlace_github);
            panel_datos.Dock = DockStyle.Bottom;
            panel_datos.Location = new Point(0, 399);
            panel_datos.Name = "panel_datos";
            panel_datos.Size = new Size(204, 51);
            panel_datos.TabIndex = 3;
            // 
            // enlace_github
            // 
            enlace_github.AutoSize = true;
            enlace_github.LinkColor = Color.FromArgb(192, 255, 255);
            enlace_github.Location = new Point(3, 1);
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
            panel_musica.Dock = DockStyle.Top;
            panel_musica.Location = new Point(0, 133);
            panel_musica.Name = "panel_musica";
            panel_musica.Size = new Size(204, 267);
            panel_musica.TabIndex = 2;
            // 
            // panel_biblioteca
            // 
            panel_biblioteca.Controls.Add(btn_desplegar_musica);
            panel_biblioteca.Dock = DockStyle.Top;
            panel_biblioteca.Location = new Point(0, 79);
            panel_biblioteca.Name = "panel_biblioteca";
            panel_biblioteca.Size = new Size(204, 54);
            panel_biblioteca.TabIndex = 1;
            // 
            // btn_desplegar_musica
            // 
            btn_desplegar_musica.BackColor = Color.White;
            btn_desplegar_musica.Dock = DockStyle.Fill;
            btn_desplegar_musica.FlatAppearance.BorderSize = 0;
            btn_desplegar_musica.FlatStyle = FlatStyle.Flat;
            btn_desplegar_musica.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_desplegar_musica.Location = new Point(0, 0);
            btn_desplegar_musica.Name = "btn_desplegar_musica";
            btn_desplegar_musica.Size = new Size(204, 54);
            btn_desplegar_musica.TabIndex = 0;
            btn_desplegar_musica.Text = "BIBLIOTECA DE MÚSICA";
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
            panel_logo.Size = new Size(204, 79);
            panel_logo.TabIndex = 0;
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.BackgroundImage = Properties.Resources.cipotify;
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.Dock = DockStyle.Fill;
            logo.Image = Properties.Resources.cipotify;
            logo.Location = new Point(0, 0);
            logo.Name = "logo";
            logo.Size = new Size(204, 79);
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // panel_inferior
            // 
            panel_inferior.BackColor = Color.FromArgb(40, 53, 69);
            panel_inferior.Controls.Add(ajustar_sonido);
            panel_inferior.Controls.Add(btn_reproducir);
            panel_inferior.Controls.Add(btn_pausa);
            panel_inferior.Controls.Add(btn_descargar_video);
            panel_inferior.Controls.Add(caja_video_youtube);
            panel_inferior.Dock = DockStyle.Bottom;
            panel_inferior.Location = new Point(204, 400);
            panel_inferior.Name = "panel_inferior";
            panel_inferior.Size = new Size(596, 50);
            panel_inferior.TabIndex = 4;
            // 
            // ajustar_sonido
            // 
            ajustar_sonido.Location = new Point(480, 6);
            ajustar_sonido.Maximum = 100;
            ajustar_sonido.Name = "ajustar_sonido";
            ajustar_sonido.Size = new Size(104, 45);
            ajustar_sonido.TabIndex = 7;
            ajustar_sonido.TickFrequency = 10;
            ajustar_sonido.Value = 50;
            ajustar_sonido.Scroll += ajustar_sonido_Scroll;
            // 
            // btn_reproducir
            // 
            btn_reproducir.BackColor = Color.FromArgb(40, 53, 69);
            btn_reproducir.BackgroundImage = Properties.Resources.reproducir;
            btn_reproducir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_reproducir.FlatAppearance.BorderSize = 0;
            btn_reproducir.FlatStyle = FlatStyle.Flat;
            btn_reproducir.Location = new Point(6, -1);
            btn_reproducir.Name = "btn_reproducir";
            btn_reproducir.Size = new Size(52, 47);
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
            btn_pausa.FlatStyle = FlatStyle.Flat;
            btn_pausa.Location = new Point(15, 6);
            btn_pausa.Name = "btn_pausa";
            btn_pausa.Size = new Size(36, 33);
            btn_pausa.TabIndex = 5;
            btn_pausa.UseVisualStyleBackColor = false;
            btn_pausa.Click += btn_pausa_Click;
            // 
            // videoView1
            // 
            videoView1.BackColor = Color.LightGray;
            videoView1.Dock = DockStyle.Fill;
            videoView1.Location = new Point(204, 0);
            videoView1.MediaPlayer = null;
            videoView1.Name = "videoView1";
            videoView1.Size = new Size(596, 400);
            videoView1.TabIndex = 5;
            videoView1.Text = "videoView1";
            // 
            // Cipotify
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(videoView1);
            Controls.Add(panel_inferior);
            Controls.Add(panel_lateral);
            MaximizeBox = false;
            MinimumSize = new Size(816, 489);
            Name = "Cipotify";
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
    }
}