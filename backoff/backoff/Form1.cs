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
    public partial class VentanaPrinicipal : Form
    {
        VentanEliminar VentanEliminar;
        VentanaModificacion ventanaModificacion;
        VentanaConsultas ventanaConsultas;
        public VentanaPrinicipal()
        {
            InitializeComponent();
            VentanEliminar = new VentanEliminar();
            ventanaModificacion = new VentanaModificacion();
            ventanaConsultas = new VentanaConsultas();

        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            VentanEliminar.ShowDialog();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            ventanaModificacion.ShowDialog();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            ventanaConsultas.ShowDialog();
        }
    }
}
