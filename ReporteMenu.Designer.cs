
namespace Proyecto_Biblioteca
{
    partial class ReporteMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteMenu));
            this.button2 = new System.Windows.Forms.Button();
            this.btn_reportelibros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button2.Image = global::Proyecto_Biblioteca.Properties.Resources.lector;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(87, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 75);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reporte de Libros";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_reportelibros
            // 
            this.btn_reportelibros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_reportelibros.Image = global::Proyecto_Biblioteca.Properties.Resources.reporte;
            this.btn_reportelibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportelibros.Location = new System.Drawing.Point(87, 147);
            this.btn_reportelibros.Name = "btn_reportelibros";
            this.btn_reportelibros.Size = new System.Drawing.Size(194, 75);
            this.btn_reportelibros.TabIndex = 0;
            this.btn_reportelibros.Text = "Reporte de Prestamos";
            this.btn_reportelibros.UseVisualStyleBackColor = true;
            this.btn_reportelibros.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReporteMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(355, 293);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_reportelibros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteMenu";
            this.Opacity = 0.95D;
            this.Text = "ReporteMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_reportelibros;
        private System.Windows.Forms.Button button2;
    }
}