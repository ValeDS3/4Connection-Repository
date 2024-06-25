
namespace backoff
{
    partial class VentanaModificaionPost
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
            this.btn_Terminar = new System.Windows.Forms.Button();
            this.txt_texto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.box_imagenes = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cargan_imagen = new System.Windows.Forms.Button();
            this.txt_URL_youtube = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.box_imagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Terminar
            // 
            this.btn_Terminar.Location = new System.Drawing.Point(82, 512);
            this.btn_Terminar.Name = "btn_Terminar";
            this.btn_Terminar.Size = new System.Drawing.Size(283, 67);
            this.btn_Terminar.TabIndex = 0;
            this.btn_Terminar.Text = "TERMINAR";
            this.btn_Terminar.UseVisualStyleBackColor = true;
            this.btn_Terminar.Click += new System.EventHandler(this.btn_Terminar_Click);
            // 
            // txt_texto
            // 
            this.txt_texto.Location = new System.Drawing.Point(82, 55);
            this.txt_texto.Multiline = true;
            this.txt_texto.Name = "txt_texto";
            this.txt_texto.Size = new System.Drawing.Size(283, 95);
            this.txt_texto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modficia Texto";
            // 
            // box_imagenes
            // 
            this.box_imagenes.Location = new System.Drawing.Point(82, 219);
            this.box_imagenes.Name = "box_imagenes";
            this.box_imagenes.Size = new System.Drawing.Size(283, 142);
            this.box_imagenes.TabIndex = 3;
            this.box_imagenes.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modficia Imagen";
            // 
            // btn_Cargan_imagen
            // 
            this.btn_Cargan_imagen.Location = new System.Drawing.Point(144, 367);
            this.btn_Cargan_imagen.Name = "btn_Cargan_imagen";
            this.btn_Cargan_imagen.Size = new System.Drawing.Size(158, 23);
            this.btn_Cargan_imagen.TabIndex = 5;
            this.btn_Cargan_imagen.Text = "Carga imagen";
            this.btn_Cargan_imagen.UseVisualStyleBackColor = true;
            this.btn_Cargan_imagen.Click += new System.EventHandler(this.btn_Cargan_imagen_Click);
            // 
            // txt_URL_youtube
            // 
            this.txt_URL_youtube.Location = new System.Drawing.Point(82, 452);
            this.txt_URL_youtube.Multiline = true;
            this.txt_URL_youtube.Name = "txt_URL_youtube";
            this.txt_URL_youtube.Size = new System.Drawing.Size(283, 29);
            this.txt_URL_youtube.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Modficia URL";
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(12, 12);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 8;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // VentanaModificaionPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 604);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_URL_youtube);
            this.Controls.Add(this.btn_Cargan_imagen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_imagenes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_texto);
            this.Controls.Add(this.btn_Terminar);
            this.Name = "VentanaModificaionPost";
            this.Text = "VentanaModificaionPost";
            ((System.ComponentModel.ISupportInitialize)(this.box_imagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Terminar;
        private System.Windows.Forms.TextBox txt_texto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox box_imagenes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Cargan_imagen;
        private System.Windows.Forms.TextBox txt_URL_youtube;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_volver;
    }
}