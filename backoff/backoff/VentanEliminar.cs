using MySql.Data.MySqlClient;
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
    public partial class VentanEliminar : Form
    {

        public static MySqlConnection Connection()
        {

            try
            {
                MySqlConnection conexionbd = new MySqlConnection("Server=localhost; database=base ; uID=root ; pwd= ;");
                conexionbd.Open();


                return conexionbd;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }


        }

        public static void cerrar()
        {

            MySqlConnection conexionbd = new MySqlConnection("Server=localhost; database=base ; uID=root ; pwd= ;");
            conexionbd.Close();


        }

        public VentanEliminar()
        {
            InitializeComponent();
            
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            leble_ID.Text = "ID USUARIO";
            this.Close();

        }

        private void btn_Eliminar_post_Click(object sender, EventArgs e)
        {
            leble_ID.Text = "ID POST";
            
        }

        private void btn_Eliminar_Grupo_Click(object sender, EventArgs e)
        {
            leble_ID.Text = "ID GRUPO";
        }

        private void btn_Eliminar_Evento_Click(object sender, EventArgs e)
        {
            leble_ID.Text = "ID EVENTO";
        }

        

        private void btn_Eliminar_usuario_Click(object sender, EventArgs e)
        {
            leble_ID.Text = "ID USUARIO";
            String txt_Usuario = txt_ID.Text;
            if (txt_Usuario != "")
            {
                try
                {
                    Connection();


                    using (MySqlCommand cmd = new MySqlCommand($"DELETE FROM base.usuario WHERE name = @value", Connection()))
                    {
                        cmd.Parameters.AddWithValue("@value", txt_Usuario);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        Console.WriteLine($"Filas afectadas: {filasAfectadas}");
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                cerrar();
            }
            else
            {
                txt_ID.Text = "deve ingresar un id de usuario";
            }

        }

        private void btn_Eliminar_comentario_Click(object sender, EventArgs e)
        {
            leble_ID.Text = "ID POST";
        }

        private void btn_Eliminar_chat_privado_Click(object sender, EventArgs e)
        {
            leble_ID.Text = "ID CHAT PRIVADO";
        }

    }
}
