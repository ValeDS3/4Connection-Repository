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
    public partial class VentanaModificacionEvento : Form
    {
        public VentanaModificacionEvento()
        {
            InitializeComponent();
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
