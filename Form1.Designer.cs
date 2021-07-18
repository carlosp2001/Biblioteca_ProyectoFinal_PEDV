
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "USUARIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CONTRASEÑA:";
            // 
            // txt_Usuario_Empl
            // 
            this.txt_Usuario_Empl.Location = new System.Drawing.Point(120, 93);
            this.txt_Usuario_Empl.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txt_Usuario_Empl.Name = "txt_Usuario_Empl";
            this.txt_Usuario_Empl.Size = new System.Drawing.Size(99, 20);
            this.txt_Usuario_Empl.TabIndex = 3;
            // 
            // txt_Contraseña_Empl
            // 
            this.txt_Contraseña_Empl.Location = new System.Drawing.Point(120, 150);
            this.txt_Contraseña_Empl.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txt_Contraseña_Empl.Name = "txt_Contraseña_Empl";
            this.txt_Contraseña_Empl.Size = new System.Drawing.Size(99, 20);
            this.txt_Contraseña_Empl.TabIndex = 4;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(190, 200);
            this.btn_Ingresar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(81, 30);
            this.btn_Ingresar.TabIndex = 5;
            this.btn_Ingresar.Text = "INGRESAR";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // Frm_Login_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 258);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.txt_Contraseña_Empl);
            this.Controls.Add(this.txt_Usuario_Empl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Frm_Login_Empleado";
            this.Text = "GOODREADER";
            this.Load += new System.EventHandler(this.Frm_Login_Empleado_Load);
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

