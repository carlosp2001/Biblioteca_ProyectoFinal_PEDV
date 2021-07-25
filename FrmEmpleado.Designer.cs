
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleado));
            this.btn_Emple_AgreLect = new System.Windows.Forms.Button();
            this.btn_Emple_Presta = new System.Windows.Forms.Button();
            this.btn_Emple_EntreLib = new System.Windows.Forms.Button();
            this.btn_Emple_Fact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Emple_AgreLect
            // 
            this.btn_Emple_AgreLect.Image = ((System.Drawing.Image)(resources.GetObject("btn_Emple_AgreLect.Image")));
            this.btn_Emple_AgreLect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Emple_AgreLect.Location = new System.Drawing.Point(139, 58);
            this.btn_Emple_AgreLect.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Emple_AgreLect.Name = "btn_Emple_AgreLect";
            this.btn_Emple_AgreLect.Size = new System.Drawing.Size(210, 47);
            this.btn_Emple_AgreLect.TabIndex = 0;
            this.btn_Emple_AgreLect.Text = "Agregar Un Nuevo Lector";
            this.btn_Emple_AgreLect.UseVisualStyleBackColor = true;
            this.btn_Emple_AgreLect.Click += new System.EventHandler(this.btn_Emple_AgreLect_Click);
            // 
            // btn_Emple_Presta
            // 
            this.btn_Emple_Presta.Image = ((System.Drawing.Image)(resources.GetObject("btn_Emple_Presta.Image")));
            this.btn_Emple_Presta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Emple_Presta.Location = new System.Drawing.Point(139, 128);
            this.btn_Emple_Presta.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Emple_Presta.Name = "btn_Emple_Presta";
            this.btn_Emple_Presta.Size = new System.Drawing.Size(210, 47);
            this.btn_Emple_Presta.TabIndex = 1;
            this.btn_Emple_Presta.Text = "Realizar Prestamo";
            this.btn_Emple_Presta.UseVisualStyleBackColor = true;
            this.btn_Emple_Presta.Click += new System.EventHandler(this.btn_Emple_Presta_Click);
            // 
            // btn_Emple_EntreLib
            // 
            this.btn_Emple_EntreLib.Image = ((System.Drawing.Image)(resources.GetObject("btn_Emple_EntreLib.Image")));
            this.btn_Emple_EntreLib.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Emple_EntreLib.Location = new System.Drawing.Point(139, 207);
            this.btn_Emple_EntreLib.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Emple_EntreLib.Name = "btn_Emple_EntreLib";
            this.btn_Emple_EntreLib.Size = new System.Drawing.Size(210, 47);
            this.btn_Emple_EntreLib.TabIndex = 2;
            this.btn_Emple_EntreLib.Text = "Recibir Entrega De Libro";
            this.btn_Emple_EntreLib.UseVisualStyleBackColor = true;
            this.btn_Emple_EntreLib.Click += new System.EventHandler(this.btn_Emple_EntreLib_Click);
            // 
            // btn_Emple_Fact
            // 
            this.btn_Emple_Fact.Image = ((System.Drawing.Image)(resources.GetObject("btn_Emple_Fact.Image")));
            this.btn_Emple_Fact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Emple_Fact.Location = new System.Drawing.Point(139, 282);
            this.btn_Emple_Fact.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Emple_Fact.Name = "btn_Emple_Fact";
            this.btn_Emple_Fact.Size = new System.Drawing.Size(210, 47);
            this.btn_Emple_Fact.TabIndex = 3;
            this.btn_Emple_Fact.Text = "Realizar Factura";
            this.btn_Emple_Fact.UseVisualStyleBackColor = true;
            this.btn_Emple_Fact.Click += new System.EventHandler(this.btn_Emple_Fact_Click);
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(462, 389);
            this.Controls.Add(this.btn_Emple_Fact);
            this.Controls.Add(this.btn_Emple_EntreLib);
            this.Controls.Add(this.btn_Emple_Presta);
            this.Controls.Add(this.btn_Emple_AgreLect);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FrmEmpleado";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMPLEADO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEmpleado_FormClosed);
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Emple_AgreLect;
        private System.Windows.Forms.Button btn_Emple_Presta;
        private System.Windows.Forms.Button btn_Emple_EntreLib;
        private System.Windows.Forms.Button btn_Emple_Fact;
    }
}