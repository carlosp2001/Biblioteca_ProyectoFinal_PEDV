
namespace Proyecto_Biblioteca
{
    partial class Frm_Login_Empleado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login_Empleado));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Usuario_Empl = new System.Windows.Forms.TextBox();
            this.txt_Contraseña_Empl = new System.Windows.Forms.TextBox();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(602, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "USUARIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "CONTRASEÑA:";
            // 
            // txt_Usuario_Empl
            // 
            this.txt_Usuario_Empl.Location = new System.Drawing.Point(381, 265);
            this.txt_Usuario_Empl.Name = "txt_Usuario_Empl";
            this.txt_Usuario_Empl.Size = new System.Drawing.Size(305, 44);
            this.txt_Usuario_Empl.TabIndex = 3;
            // 
            // txt_Contraseña_Empl
            // 
            this.txt_Contraseña_Empl.Location = new System.Drawing.Point(381, 426);
            this.txt_Contraseña_Empl.Name = "txt_Contraseña_Empl";
            this.txt_Contraseña_Empl.Size = new System.Drawing.Size(305, 44);
            this.txt_Contraseña_Empl.TabIndex = 4;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(601, 570);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(256, 85);
            this.btn_Ingresar.TabIndex = 5;
            this.btn_Ingresar.Text = "INGRESAR";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            // 
            // Frm_Login_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 735);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.txt_Contraseña_Empl);
            this.Controls.Add(this.txt_Usuario_Empl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Login_Empleado";
            this.Text = "GOODREADER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Usuario_Empl;
        private System.Windows.Forms.TextBox txt_Contraseña_Empl;
        private System.Windows.Forms.Button btn_Ingresar;
    }
}

