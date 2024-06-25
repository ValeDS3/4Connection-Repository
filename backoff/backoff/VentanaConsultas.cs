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
    public partial class VentanaConsultas : Form
    {
        
        public VentanaConsultas()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_consulta_ID_Usuario_Por_Nombre_Click(object sender, EventArgs e)
        {
            lable_consulta.Text = "NOMBRE DE USUARIO";
            Resultado.Text = "DATO ID USUARIO";
            txt_Consulta.Text = "";
        }

        private void btn_consulta_ID_Post_Click(object sender, EventArgs e)
        {
            lable_consulta.Text = "ID USUARIO";
            Resultado.Text = "DATO ID POST";
            txt_Consulta.Text = "";
        }

        private void btn_consulta_ID_Evento_Click(object sender, EventArgs e)
        {
            lable_consulta.Text = "ID USUARIO";
            Resultado.Text = "DATO ID EVENTO";
            txt_Consulta.Text = "";
        }

        private void btn_consulta_ID_Grupo_Click(object sender, EventArgs e)
        {
            lable_consulta.Text = "ID USUARIO";
            Resultado.Text = "DATO ID GRUPO";
            txt_Consulta.Text = "";
        }

        private void btn_consulta_ID_Chat_Privado_Click(object sender, EventArgs e)
        {
            lable_consulta.Text = "ID USUARIO";
            Resultado.Text = "DATO ID CHAT";
            txt_Consulta.Text = "";
        }

        private void Resultado_Click(object sender, EventArgs e)
        {
            
        }
    }
}
