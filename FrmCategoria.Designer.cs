
namespace Proyecto_Biblioteca
{
    partial class FrmCategoria
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
            this.btn_Modi_Cat = new System.Windows.Forms.Button();
            this.btn_Agregar_Cat = new System.Windows.Forms.Button();
            this.dgv_Admi_Cat = new System.Windows.Forms.DataGridView();
            this.txt_Nombre_Cat = new System.Windows.Forms.TextBox();
            this.txt_Id_Cat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Admi_Cat)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Modi_Cat
            // 
            this.btn_Modi_Cat.Location = new System.Drawing.Point(955, 554);
            this.btn_Modi_Cat.Name = "btn_Modi_Cat";
            this.btn_Modi_Cat.Size = new System.Drawing.Size(196, 102);
            this.btn_Modi_Cat.TabIndex = 42;
            this.btn_Modi_Cat.Text = "Modificar";
            this.btn_Modi_Cat.UseVisualStyleBackColor = true;
            // 
            // btn_Agregar_Cat
            // 
            this.btn_Agregar_Cat.Location = new System.Drawing.Point(955, 371);
            this.btn_Agregar_Cat.Name = "btn_Agregar_Cat";
            this.btn_Agregar_Cat.Size = new System.Drawing.Size(196, 94);
            this.btn_Agregar_Cat.TabIndex = 41;
            this.btn_Agregar_Cat.Text = "Agregar";
            this.btn_Agregar_Cat.UseVisualStyleBackColor = true;
            // 
            // dgv_Admi_Cat
            // 
            this.dgv_Admi_Cat.AllowUserToAddRows = false;
            this.dgv_Admi_Cat.AllowUserToDeleteRows = false;
            this.dgv_Admi_Cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Admi_Cat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_Admi_Cat.Location = new System.Drawing.Point(176, 817);
            this.dgv_Admi_Cat.Name = "dgv_Admi_Cat";
            this.dgv_Admi_Cat.ReadOnly = true;
            this.dgv_Admi_Cat.RowHeadersWidth = 123;
            this.dgv_Admi_Cat.RowTemplate.Height = 46;
            this.dgv_Admi_Cat.Size = new System.Drawing.Size(677, 226);
            this.dgv_Admi_Cat.TabIndex = 40;
            // 
            // txt_Nombre_Cat
            // 
            this.txt_Nombre_Cat.Location = new System.Drawing.Point(385, 530);
            this.txt_Nombre_Cat.Name = "txt_Nombre_Cat";
            this.txt_Nombre_Cat.Size = new System.Drawing.Size(183, 44);
            this.txt_Nombre_Cat.TabIndex = 37;
            // 
            // txt_Id_Cat
            // 
            this.txt_Id_Cat.Location = new System.Drawing.Point(385, 394);
            this.txt_Id_Cat.Name = "txt_Id_Cat";
            this.txt_Id_Cat.Size = new System.Drawing.Size(183, 44);
            this.txt_Id_Cat.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 37);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 37);
            this.label2.TabIndex = 32;
            this.label2.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(474, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 64);
            this.label1.TabIndex = 31;
            this.label1.Text = "Categoria";
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
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 1211);
            this.Controls.Add(this.btn_Modi_Cat);
            this.Controls.Add(this.btn_Agregar_Cat);
            this.Controls.Add(this.dgv_Admi_Cat);
            this.Controls.Add(this.txt_Nombre_Cat);
            this.Controls.Add(this.txt_Id_Cat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCategoria";
            this.Text = "FrmCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Admi_Cat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Modi_Cat;
        private System.Windows.Forms.Button btn_Agregar_Cat;
        private System.Windows.Forms.DataGridView dgv_Admi_Cat;
        private System.Windows.Forms.TextBox txt_Nombre_Cat;
        private System.Windows.Forms.TextBox txt_Id_Cat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}