
namespace Proyecto_Biblioteca
{
    partial class FrmAdministrador
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
            this.btn_Admi_Edi = new System.Windows.Forms.Button();
            this.btn_Admi_Cat = new System.Windows.Forms.Button();
            this.btn_Admi_Autor = new System.Windows.Forms.Button();
            this.btn_Admi_UsuarioSist = new System.Windows.Forms.Button();
            this.btn_Admi_Libro = new System.Windows.Forms.Button();
            this.btn_Admi_Lector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Admi_Edi
            // 
            this.btn_Admi_Edi.Location = new System.Drawing.Point(437, 625);
            this.btn_Admi_Edi.Name = "btn_Admi_Edi";
            this.btn_Admi_Edi.Size = new System.Drawing.Size(545, 85);
            this.btn_Admi_Edi.TabIndex = 7;
            this.btn_Admi_Edi.Text = "Editorial";
            this.btn_Admi_Edi.UseVisualStyleBackColor = true;
            // 
            // btn_Admi_Cat
            // 
            this.btn_Admi_Cat.Location = new System.Drawing.Point(437, 467);
            this.btn_Admi_Cat.Name = "btn_Admi_Cat";
            this.btn_Admi_Cat.Size = new System.Drawing.Size(545, 85);
            this.btn_Admi_Cat.TabIndex = 6;
            this.btn_Admi_Cat.Text = "Categoria";
            this.btn_Admi_Cat.UseVisualStyleBackColor = true;
            // 
            // btn_Admi_Autor
            // 
            this.btn_Admi_Autor.Location = new System.Drawing.Point(437, 302);
            this.btn_Admi_Autor.Name = "btn_Admi_Autor";
            this.btn_Admi_Autor.Size = new System.Drawing.Size(545, 85);
            this.btn_Admi_Autor.TabIndex = 5;
            this.btn_Admi_Autor.Text = "Autor";
            this.btn_Admi_Autor.UseVisualStyleBackColor = true;
            // 
            // btn_Admi_UsuarioSist
            // 
            this.btn_Admi_UsuarioSist.Location = new System.Drawing.Point(437, 142);
            this.btn_Admi_UsuarioSist.Name = "btn_Admi_UsuarioSist";
            this.btn_Admi_UsuarioSist.Size = new System.Drawing.Size(545, 85);
            this.btn_Admi_UsuarioSist.TabIndex = 4;
            this.btn_Admi_UsuarioSist.Text = "Usuario Sistema";
            this.btn_Admi_UsuarioSist.UseVisualStyleBackColor = true;
            // 
            // btn_Admi_Libro
            // 
            this.btn_Admi_Libro.Location = new System.Drawing.Point(437, 780);
            this.btn_Admi_Libro.Name = "btn_Admi_Libro";
            this.btn_Admi_Libro.Size = new System.Drawing.Size(545, 85);
            this.btn_Admi_Libro.TabIndex = 8;
            this.btn_Admi_Libro.Text = "Libro";
            this.btn_Admi_Libro.UseVisualStyleBackColor = true;
            // 
            // btn_Admi_Lector
            // 
            this.btn_Admi_Lector.Location = new System.Drawing.Point(437, 942);
            this.btn_Admi_Lector.Name = "btn_Admi_Lector";
            this.btn_Admi_Lector.Size = new System.Drawing.Size(545, 85);
            this.btn_Admi_Lector.TabIndex = 9;
            this.btn_Admi_Lector.Text = "Lector";
            this.btn_Admi_Lector.UseVisualStyleBackColor = true;
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 1194);
            this.Controls.Add(this.btn_Admi_Lector);
            this.Controls.Add(this.btn_Admi_Libro);
            this.Controls.Add(this.btn_Admi_Edi);
            this.Controls.Add(this.btn_Admi_Cat);
            this.Controls.Add(this.btn_Admi_Autor);
            this.Controls.Add(this.btn_Admi_UsuarioSist);
            this.Name = "FrmAdministrador";
            this.Text = "Administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Admi_Edi;
        private System.Windows.Forms.Button btn_Admi_Cat;
        private System.Windows.Forms.Button btn_Admi_Autor;
        private System.Windows.Forms.Button btn_Admi_UsuarioSist;
        private System.Windows.Forms.Button btn_Admi_Libro;
        private System.Windows.Forms.Button btn_Admi_Lector;
    }
}