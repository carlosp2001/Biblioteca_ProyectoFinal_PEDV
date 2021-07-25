
namespace Proyecto_Biblioteca
{
    partial class DGV_Prestamos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Generar_Factura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 374);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Generar_Factura
            // 
            this.btn_Generar_Factura.Location = new System.Drawing.Point(340, 415);
            this.btn_Generar_Factura.Name = "btn_Generar_Factura";
            this.btn_Generar_Factura.Size = new System.Drawing.Size(75, 23);
            this.btn_Generar_Factura.TabIndex = 1;
            this.btn_Generar_Factura.Text = "Generar Factura";
            this.btn_Generar_Factura.UseVisualStyleBackColor = true;
            this.btn_Generar_Factura.Click += new System.EventHandler(this.btn_Generar_Factura_Click);
            // 
            // DGV_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Generar_Factura);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DGV_Prestamos";
            this.Text = "DGV_Prestamos";
            this.Load += new System.EventHandler(this.DGV_Prestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Generar_Factura;
    }
}