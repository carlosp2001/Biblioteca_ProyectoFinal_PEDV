
namespace Proyecto_Biblioteca
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.btn_Admi = new System.Windows.Forms.Button();
            this.btn_Empleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Admi
            // 
            this.btn_Admi.Location = new System.Drawing.Point(53, 104);
            this.btn_Admi.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Admi.Name = "btn_Admi";
            this.btn_Admi.Size = new System.Drawing.Size(168, 156);
            this.btn_Admi.TabIndex = 0;
            this.btn_Admi.Text = "ADMINISTRADOR";
            this.btn_Admi.UseVisualStyleBackColor = true;
            this.btn_Admi.Click += new System.EventHandler(this.btn_Admi_Click);
            // 
            // btn_Empleado
            // 
            this.btn_Empleado.Location = new System.Drawing.Point(292, 104);
            this.btn_Empleado.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Empleado.Name = "btn_Empleado";
            this.btn_Empleado.Size = new System.Drawing.Size(169, 156);
            this.btn_Empleado.TabIndex = 1;
            this.btn_Empleado.Text = "EMPLEADO";
            this.btn_Empleado.UseVisualStyleBackColor = true;
            this.btn_Empleado.Click += new System.EventHandler(this.btn_Empleado_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 310);
            this.Controls.Add(this.btn_Empleado);
            this.Controls.Add(this.btn_Admi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FrmUsuario";
            this.Text = "BIENVENIDO A GOODREADER";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Admi;
        private System.Windows.Forms.Button btn_Empleado;
    }
}