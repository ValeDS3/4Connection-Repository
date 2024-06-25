using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backoff
{
    public partial class VentanaModificaionPost : Form
    {
        public VentanaModificaionPost()
        {
            InitializeComponent();
        }

        private void btn_Cargan_imagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririmagen = new OpenFileDialog();

            if (abririmagen.ShowDialog()== DialogResult.OK)
            {
                box_imagenes.ImageLocation = abririmagen.FileName;
                box_imagenes.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Terminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
