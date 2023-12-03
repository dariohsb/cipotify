using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Cipotify.Forms
{
    public partial class FormularioAjustes : Form
    {
        public Cipotify formularioPrincipal;
        private string folderPath;

        public FormularioAjustes()
        {
            InitializeComponent();
            this.Load += FormularioAjustes_Load;

            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            folderPath = Path.Combine(documentsPath, "Cipotify");

            combo_formato.SelectedIndex = 0;

            combo_formato.SelectedIndexChanged += (sender, e) =>
            {
                this.formularioPrincipal.FormatoSeleccionado = combo_formato.SelectedItem.ToString();
                Properties.Settings.Default.FormatoSeleccionado = combo_formato.SelectedItem.ToString();
                Properties.Settings.Default.Save();
            };
        }

        private void FormularioAjustes_Load(object sender, EventArgs e)
        {
            // Sincroniza el estado del checkbox con el del formulario principal
            cb_reproducir_auto.Checked = this.formularioPrincipal.ReproducirAutomaticamente;

            // Aquí cargamos el formato seleccionado guardado, o usamos MP4 por defecto si no se ha seleccionado ninguno
            string formatoGuardado = Properties.Settings.Default.FormatoSeleccionado ?? "MP4";
            this.formularioPrincipal.FormatoSeleccionado = formatoGuardado;
            combo_formato.SelectedItem = formatoGuardado;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.formularioPrincipal.CambiarVisibilidadVideoView1(true);
            this.Close();
        }

        private void cb_reproducir_auto_CheckedChanged(object sender, EventArgs e)
        {
            this.formularioPrincipal.ReproducirAutomaticamente = cb_reproducir_auto.Checked;
        }

        private void eliminar_videos_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(folderPath))
                {
                    foreach (var file in Directory.GetFiles(folderPath))
                    {
                        File.Delete(file);
                    }

                    foreach (var dir in Directory.GetDirectories(folderPath))
                    {
                        Directory.Delete(dir, true);
                    }
                    MessageBox.Show("Los archivos han sido eliminados con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.formularioPrincipal.limpiarPanelMusica();
                    this.formularioPrincipal.cargarBotonesMusica();
                }
            }
            catch (IOException ioEx)
            {
                Console.WriteLine(ioEx.Message);
            }
        }
    }
}