
namespace Proyecto_Biblioteca
{
    partial class Frm_Login_Admi
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
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.txt_Contraseña_Admi = new System.Windows.Forms.TextBox();
            this.txt_Usuario_Admi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(638, 618);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(256, 85);
            this.btn_Ingresar.TabIndex = 11;
            this.btn_Ingresar.Text = "INGRESAR";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            // 
            // txt_Contraseña_Admi
            // 
            this.txt_Contraseña_Admi.Location = new System.Drawing.Point(418, 474);
            this.txt_Contraseña_Admi.Name = "txt_Contraseña_Admi";
            this.txt_Contraseña_Admi.Size = new System.Drawing.Size(305, 44);
            this.txt_Contraseña_Admi.TabIndex = 10;
            // 
            // txt_Usuario_Admi
            // 
            this.txt_Usuario_Admi.Location = new System.Drawing.Point(418, 313);
            this.txt_Usuario_Admi.Name = "txt_Usuario_Admi";
            this.txt_Usuario_Admi.Size = new System.Drawing.Size(305, 44);
            this.txt_Usuario_Admi.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "CONTRASEÑA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "USUARIO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(913, 83);
            this.label1.TabIndex = 6;
            this.label1.Text = "LOGIN ADMINISTRADOR";
            // 
            // Frm_Login_Admi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 787);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.txt_Contraseña_Admi);
            this.Controls.Add(this.txt_Usuario_Admi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Login_Admi";
            this.Text = "GOODREADER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.TextBox txt_Contraseña_Admi;
        private System.Windows.Forms.TextBox txt_Usuario_Admi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}