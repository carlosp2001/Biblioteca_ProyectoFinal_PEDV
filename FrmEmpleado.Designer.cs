
namespace Proyecto_Biblioteca
{
    partial class FrmEmpleado
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
            this.btn_Emple_AgreLect = new System.Windows.Forms.Button();
            this.btn_Emple_Presta = new System.Windows.Forms.Button();
            this.btn_Emple_EntreLib = new System.Windows.Forms.Button();
            this.btn_Emple_Fact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Emple_AgreLect
            // 
            this.btn_Emple_AgreLect.Location = new System.Drawing.Point(535, 168);
            this.btn_Emple_AgreLect.Name = "btn_Emple_AgreLect";
            this.btn_Emple_AgreLect.Size = new System.Drawing.Size(545, 117);
            this.btn_Emple_AgreLect.TabIndex = 0;
            this.btn_Emple_AgreLect.Text = "Agregar Un Nuevo Lector";
            this.btn_Emple_AgreLect.UseVisualStyleBackColor = true;
            // 
            // btn_Emple_Presta
            // 
            this.btn_Emple_Presta.Location = new System.Drawing.Point(535, 366);
            this.btn_Emple_Presta.Name = "btn_Emple_Presta";
            this.btn_Emple_Presta.Size = new System.Drawing.Size(545, 117);
            this.btn_Emple_Presta.TabIndex = 1;
            this.btn_Emple_Presta.Text = "Realizar Prestamo";
            this.btn_Emple_Presta.UseVisualStyleBackColor = true;
            // 
            // btn_Emple_EntreLib
            // 
            this.btn_Emple_EntreLib.Location = new System.Drawing.Point(535, 592);
            this.btn_Emple_EntreLib.Name = "btn_Emple_EntreLib";
            this.btn_Emple_EntreLib.Size = new System.Drawing.Size(545, 117);
            this.btn_Emple_EntreLib.TabIndex = 2;
            this.btn_Emple_EntreLib.Text = "Recibir Entrega De Libro";
            this.btn_Emple_EntreLib.UseVisualStyleBackColor = true;
            // 
            // btn_Emple_Fact
            // 
            this.btn_Emple_Fact.Location = new System.Drawing.Point(535, 806);
            this.btn_Emple_Fact.Name = "btn_Emple_Fact";
            this.btn_Emple_Fact.Size = new System.Drawing.Size(545, 117);
            this.btn_Emple_Fact.TabIndex = 3;
            this.btn_Emple_Fact.Text = "Realizar Factura";
            this.btn_Emple_Fact.UseVisualStyleBackColor = true;
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1743, 1142);
            this.Controls.Add(this.btn_Emple_Fact);
            this.Controls.Add(this.btn_Emple_EntreLib);
            this.Controls.Add(this.btn_Emple_Presta);
            this.Controls.Add(this.btn_Emple_AgreLect);
            this.Name = "FrmEmpleado";
            this.Text = "EMPLEADO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Emple_AgreLect;
        private System.Windows.Forms.Button btn_Emple_Presta;
        private System.Windows.Forms.Button btn_Emple_EntreLib;
        private System.Windows.Forms.Button btn_Emple_Fact;
    }
}