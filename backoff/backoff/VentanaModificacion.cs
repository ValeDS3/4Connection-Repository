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
    public partial class VentanaModificacion : Form
    {
        VentanaModificaionPost ventanaModificaionPost;
        VentanaModificacionUsuario VentanaModificacionUsuario;
        VentanaModificacionEvento VentanaModificacionEvento;
        VentanaModificacionComentario VentanaModificacionComentario;
        VentanaModificacionGrupo VentanaModificacionGrupo;
        VentanaModificacionChatPrivado VentanaModificacionChatPrivado;
        public VentanaModificacion()
        {
            InitializeComponent();
            ventanaModificaionPost = new VentanaModificaionPost();
            VentanaModificacionUsuario = new VentanaModificacionUsuario();
            VentanaModificacionEvento = new VentanaModificacionEvento();
            VentanaModificacionComentario = new VentanaModificacionComentario();
            VentanaModificacionGrupo = new VentanaModificacionGrupo();
            VentanaModificacionChatPrivado = new VentanaModificacionChatPrivado();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mod_post_Click(object sender, EventArgs e)
        {
            leble_ID.Text = "ID POST";
            if (txt_ID.Text == "1")
            {
                ventanaModificaionPost.ShowDialog();
            }
        }

        private void btn_mod_evento_Click(object sender, EventArgs e)
        {
            leble_ID.Text = "ID EVENTO";
            if (txt_ID.Text == "3")
            {
                VentanaModificacionEvento.ShowDialog();
            }
        }

        private void btn_mod_comentario_Click(object sender, EventArgs e)
        {
            leble_ID.Text = "ID POST";
            VentanaModificacionComentario.ShowDialog();
        }

        private void btn_mod_usuario_Click(object sender, EventArgs e)
        {
            leble_ID.Text = "ID USUARIO";
            if (txt_ID.Text == "2")
            {
                VentanaModificacionUsuario.ShowDialog();
            }
        }

        private void btn_mod_grupo_Click(object sender, EventArgs e)
        {
            leble_ID.Text = "ID GRUPO";
            VentanaModificacionGrupo.ShowDialog();
        }

        private void btn_mod_chat_privado_Click(object sender, EventArgs e)
        {
            leble_ID.Text = "ID CHAT PRIVADO";
            VentanaModificacionChatPrivado.ShowDialog();
        }

    }
}
