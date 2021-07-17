
namespace Proyecto_Biblioteca
{
    partial class FrmEditorial
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Modi_editorial = new System.Windows.Forms.Button();
            this.btn_Agre_editorial = new System.Windows.Forms.Button();
            this.dgv_admi_editorial = new System.Windows.Forms.DataGridView();
            this.txt_pais_editorial = new System.Windows.Forms.TextBox();
            this.txt_Nombre_editorial = new System.Windows.Forms.TextBox();
            this.txt_Id_editorial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admi_editorial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(547, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editorial";
            // 
            // btn_Modi_editorial
            // 
            this.btn_Modi_editorial.Location = new System.Drawing.Point(873, 510);
            this.btn_Modi_editorial.Name = "btn_Modi_editorial";
            this.btn_Modi_editorial.Size = new System.Drawing.Size(196, 102);
            this.btn_Modi_editorial.TabIndex = 41;
            this.btn_Modi_editorial.Text = "Modificar";
            this.btn_Modi_editorial.UseVisualStyleBackColor = true;
            // 
            // btn_Agre_editorial
            // 
            this.btn_Agre_editorial.Location = new System.Drawing.Point(873, 345);
            this.btn_Agre_editorial.Name = "btn_Agre_editorial";
            this.btn_Agre_editorial.Size = new System.Drawing.Size(196, 94);
            this.btn_Agre_editorial.TabIndex = 40;
            this.btn_Agre_editorial.Text = "Agregar";
            this.btn_Agre_editorial.UseVisualStyleBackColor = true;
            // 
            // dgv_admi_editorial
            // 
            this.dgv_admi_editorial.AllowUserToAddRows = false;
            this.dgv_admi_editorial.AllowUserToDeleteRows = false;
            this.dgv_admi_editorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admi_editorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_admi_editorial.Location = new System.Drawing.Point(140, 820);
            this.dgv_admi_editorial.Name = "dgv_admi_editorial";
            this.dgv_admi_editorial.ReadOnly = true;
            this.dgv_admi_editorial.RowHeadersWidth = 123;
            this.dgv_admi_editorial.RowTemplate.Height = 46;
            this.dgv_admi_editorial.Size = new System.Drawing.Size(929, 226);
            this.dgv_admi_editorial.TabIndex = 39;
            // 
            // txt_pais_editorial
            // 
            this.txt_pais_editorial.Location = new System.Drawing.Point(357, 595);
            this.txt_pais_editorial.Name = "txt_pais_editorial";
            this.txt_pais_editorial.Size = new System.Drawing.Size(183, 44);
            this.txt_pais_editorial.TabIndex = 37;
            // 
            // txt_Nombre_editorial
            // 
            this.txt_Nombre_editorial.Location = new System.Drawing.Point(357, 453);
            this.txt_Nombre_editorial.Name = "txt_Nombre_editorial";
            this.txt_Nombre_editorial.Size = new System.Drawing.Size(183, 44);
            this.txt_Nombre_editorial.TabIndex = 36;
            // 
            // txt_Id_editorial
            // 
            this.txt_Id_editorial.Location = new System.Drawing.Point(357, 317);
            this.txt_Id_editorial.Name = "txt_Id_editorial";
            this.txt_Id_editorial.Size = new System.Drawing.Size(183, 44);
            this.txt_Id_editorial.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 598);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 37);
            this.label4.TabIndex = 33;
            this.label4.Text = "Pais:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 37);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 37);
            this.label2.TabIndex = 31;
            this.label2.Text = "Id:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 15;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 15;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Pais";
            this.Column3.MinimumWidth = 15;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // FrmEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 1223);
            this.Controls.Add(this.btn_Modi_editorial);
            this.Controls.Add(this.btn_Agre_editorial);
            this.Controls.Add(this.dgv_admi_editorial);
            this.Controls.Add(this.txt_pais_editorial);
            this.Controls.Add(this.txt_Nombre_editorial);
            this.Controls.Add(this.txt_Id_editorial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditorial";
            this.Text = "EDITORIAL";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admi_editorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Modi_editorial;
        private System.Windows.Forms.Button btn_Agre_editorial;
        private System.Windows.Forms.DataGridView dgv_admi_editorial;
        private System.Windows.Forms.TextBox txt_pais_editorial;
        private System.Windows.Forms.TextBox txt_Nombre_editorial;
        private System.Windows.Forms.TextBox txt_Id_editorial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}