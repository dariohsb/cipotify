namespace Cipotify.Forms
{
    partial class FormularioAjustes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_cerrar = new Button();
            cb_reproducir_auto = new CheckBox();
            panel_ajustes_videos = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            eliminar_videos = new Button();
            label3 = new Label();
            panel3 = new Panel();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            panel4 = new Panel();
            combo_formato = new MetroFramework.Controls.MetroComboBox();
            label6 = new Label();
            panel_ajustes_videos.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btn_cerrar
            // 
            btn_cerrar.Image = Properties.Resources.close;
            btn_cerrar.Location = new Point(814, 12);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(42, 38);
            btn_cerrar.TabIndex = 0;
            btn_cerrar.UseVisualStyleBackColor = true;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // cb_reproducir_auto
            // 
            cb_reproducir_auto.AutoSize = true;
            cb_reproducir_auto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cb_reproducir_auto.ForeColor = Color.White;
            cb_reproducir_auto.Location = new Point(15, 33);
            cb_reproducir_auto.Name = "cb_reproducir_auto";
            cb_reproducir_auto.Size = new Size(267, 24);
            cb_reproducir_auto.TabIndex = 1;
            cb_reproducir_auto.Text = "Reproducción automática de vídeos";
            cb_reproducir_auto.UseVisualStyleBackColor = true;
            cb_reproducir_auto.CheckedChanged += cb_reproducir_auto_CheckedChanged;
            // 
            // panel_ajustes_videos
            // 
            panel_ajustes_videos.BackColor = Color.FromArgb(37, 42, 64);
            panel_ajustes_videos.Controls.Add(label2);
            panel_ajustes_videos.Controls.Add(cb_reproducir_auto);
            panel_ajustes_videos.Location = new Point(56, 80);
            panel_ajustes_videos.Name = "panel_ajustes_videos";
            panel_ajustes_videos.Size = new Size(331, 146);
            panel_ajustes_videos.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 9);
            label2.Name = "label2";
            label2.Size = new Size(194, 21);
            label2.TabIndex = 2;
            label2.Text = "Ajustes de reproducción";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(158, 161, 176);
            label1.Location = new Point(56, 32);
            label1.Name = "label1";
            label1.Size = new Size(118, 33);
            label1.TabIndex = 3;
            label1.Text = "Ajustes";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 42, 64);
            panel1.Controls.Add(eliminar_videos);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(56, 264);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 146);
            panel1.TabIndex = 3;
            // 
            // eliminar_videos
            // 
            eliminar_videos.BackColor = Color.Red;
            eliminar_videos.FlatStyle = FlatStyle.Flat;
            eliminar_videos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            eliminar_videos.ForeColor = Color.White;
            eliminar_videos.Location = new Point(15, 42);
            eliminar_videos.Name = "eliminar_videos";
            eliminar_videos.Size = new Size(194, 40);
            eliminar_videos.TabIndex = 3;
            eliminar_videos.Text = "Eliminar todos los vídeos";
            eliminar_videos.UseVisualStyleBackColor = false;
            eliminar_videos.Click += eliminar_videos_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 9);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 2;
            label3.Text = "Ajustes extra";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 42, 64);
            panel3.Controls.Add(metroLabel1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(409, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(331, 146);
            panel3.TabIndex = 7;
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.BackColor = Color.Red;
            metroLabel1.CustomBackground = true;
            metroLabel1.CustomForeColor = true;
            metroLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel1.ForeColor = Color.White;
            metroLabel1.Location = new Point(216, 11);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(42, 19);
            metroLabel1.TabIndex = 6;
            metroLabel1.Text = "BETA";
            metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(combo_formato);
            panel4.Location = new Point(20, 33);
            panel4.Name = "panel4";
            panel4.Size = new Size(138, 29);
            panel4.TabIndex = 5;
            // 
            // combo_formato
            // 
            combo_formato.FormattingEnabled = true;
            combo_formato.ItemHeight = 23;
            combo_formato.Items.AddRange(new object[] { "MP4", "MP3" });
            combo_formato.Location = new Point(0, 0);
            combo_formato.Name = "combo_formato";
            combo_formato.Size = new Size(138, 29);
            combo_formato.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(15, 9);
            label6.Name = "label6";
            label6.Size = new Size(195, 21);
            label6.TabIndex = 2;
            label6.Text = "Formato de vídeo/audio";
            // 
            // FormularioAjustes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 53, 65);
            ClientSize = new Size(931, 624);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel_ajustes_videos);
            Controls.Add(btn_cerrar);
            Name = "FormularioAjustes";
            Text = "FormularioAjustes";
            panel_ajustes_videos.ResumeLayout(false);
            panel_ajustes_videos.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cerrar;
        private CheckBox cb_reproducir_auto;
        private Panel panel_ajustes_videos;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button eliminar_videos;
        private Panel panel3;
        private Panel panel4;
        private MetroFramework.Controls.MetroComboBox combo_formato;
        private Label label6;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}