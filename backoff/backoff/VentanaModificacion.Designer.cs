
namespace backoff
{
    partial class VentanaModificacion
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
            this.leble_ID = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_mod_post = new System.Windows.Forms.Button();
            this.btn_mod_evento = new System.Windows.Forms.Button();
            this.btn_mod_comentario = new System.Windows.Forms.Button();
            this.btn_mod_usuario = new System.Windows.Forms.Button();
            this.btn_mod_grupo = new System.Windows.Forms.Button();
            this.btn_mod_chat_privado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leble_ID
            // 
            this.leble_ID.AutoSize = true;
            this.leble_ID.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leble_ID.Location = new System.Drawing.Point(278, 106);
            this.leble_ID.Name = "leble_ID";
            this.leble_ID.Size = new System.Drawing.Size(118, 26);
            this.leble_ID.TabIndex = 11;
            this.leble_ID.Text = "ID USUARIO";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(237, 135);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(200, 20);
            this.txt_ID.TabIndex = 10;
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(36, 22);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 12;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_mod_post
            // 
            this.btn_mod_post.Location = new System.Drawing.Point(36, 135);
            this.btn_mod_post.Name = "btn_mod_post";
            this.btn_mod_post.Size = new System.Drawing.Size(142, 23);
            this.btn_mod_post.TabIndex = 13;
            this.btn_mod_post.Text = "Modificar Post";
            this.btn_mod_post.UseVisualStyleBackColor = true;
            this.btn_mod_post.Click += new System.EventHandler(this.btn_mod_post_Click);
            // 
            // btn_mod_evento
            // 
            this.btn_mod_evento.Location = new System.Drawing.Point(36, 175);
            this.btn_mod_evento.Name = "btn_mod_evento";
            this.btn_mod_evento.Size = new System.Drawing.Size(142, 23);
            this.btn_mod_evento.TabIndex = 14;
            this.btn_mod_evento.Text = "Modificar Evento";
            this.btn_mod_evento.UseVisualStyleBackColor = true;
            this.btn_mod_evento.Click += new System.EventHandler(this.btn_mod_evento_Click);
            // 
            // btn_mod_comentario
            // 
            this.btn_mod_comentario.Location = new System.Drawing.Point(36, 216);
            this.btn_mod_comentario.Name = "btn_mod_comentario";
            this.btn_mod_comentario.Size = new System.Drawing.Size(142, 23);
            this.btn_mod_comentario.TabIndex = 15;
            this.btn_mod_comentario.Text = "Modificar Comentario";
            this.btn_mod_comentario.UseVisualStyleBackColor = true;
            this.btn_mod_comentario.Click += new System.EventHandler(this.btn_mod_comentario_Click);
            // 
            // btn_mod_usuario
            // 
            this.btn_mod_usuario.Location = new System.Drawing.Point(36, 256);
            this.btn_mod_usuario.Name = "btn_mod_usuario";
            this.btn_mod_usuario.Size = new System.Drawing.Size(142, 23);
            this.btn_mod_usuario.TabIndex = 16;
            this.btn_mod_usuario.Text = "Modificar Usuario";
            this.btn_mod_usuario.UseVisualStyleBackColor = true;
            this.btn_mod_usuario.Click += new System.EventHandler(this.btn_mod_usuario_Click);
            // 
            // btn_mod_grupo
            // 
            this.btn_mod_grupo.Location = new System.Drawing.Point(36, 295);
            this.btn_mod_grupo.Name = "btn_mod_grupo";
            this.btn_mod_grupo.Size = new System.Drawing.Size(142, 23);
            this.btn_mod_grupo.TabIndex = 17;
            this.btn_mod_grupo.Text = "Modificar Grupo";
            this.btn_mod_grupo.UseVisualStyleBackColor = true;
            this.btn_mod_grupo.Click += new System.EventHandler(this.btn_mod_grupo_Click);
            // 
            // btn_mod_chat_privado
            // 
            this.btn_mod_chat_privado.Location = new System.Drawing.Point(36, 337);
            this.btn_mod_chat_privado.Name = "btn_mod_chat_privado";
            this.btn_mod_chat_privado.Size = new System.Drawing.Size(142, 23);
            this.btn_mod_chat_privado.TabIndex = 18;
            this.btn_mod_chat_privado.Text = "Modificar chat privado";
            this.btn_mod_chat_privado.UseVisualStyleBackColor = true;
            this.btn_mod_chat_privado.Click += new System.EventHandler(this.btn_mod_chat_privado_Click);
            // 
            // VentanaModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 454);
            this.Controls.Add(this.btn_mod_chat_privado);
            this.Controls.Add(this.btn_mod_grupo);
            this.Controls.Add(this.btn_mod_usuario);
            this.Controls.Add(this.btn_mod_comentario);
            this.Controls.Add(this.btn_mod_evento);
            this.Controls.Add(this.btn_mod_post);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.leble_ID);
            this.Controls.Add(this.txt_ID);
            this.Name = "VentanaModificacion";
            this.Text = "VentanaModificacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leble_ID;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_mod_post;
        private System.Windows.Forms.Button btn_mod_evento;
        private System.Windows.Forms.Button btn_mod_comentario;
        private System.Windows.Forms.Button btn_mod_usuario;
        private System.Windows.Forms.Button btn_mod_grupo;
        private System.Windows.Forms.Button btn_mod_chat_privado;
    }
}