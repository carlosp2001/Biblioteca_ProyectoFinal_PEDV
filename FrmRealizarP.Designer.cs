﻿
namespace Proyecto_Biblioteca
{
    partial class FrmRealizarP
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ID_PrestamoLib = new System.Windows.Forms.TextBox();
            this.txt_Nombre_PrestamoLib = new System.Windows.Forms.TextBox();
            this.comBox_Cat_PrestLib = new System.Windows.Forms.ComboBox();
            this.comBox_Libro_PrestLib = new System.Windows.Forms.ComboBox();
            this.dateT_FPrest_PrestLib = new System.Windows.Forms.DateTimePicker();
            this.dateT_FDevolu_PrestLib = new System.Windows.Forms.DateTimePicker();
            this.dgv_PrestLib = new System.Windows.Forms.DataGridView();
            this.btn_Agregar_PrestLib = new System.Windows.Forms.Button();
            this.btn_Eliminar_PrestLib = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PrestLib)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(842, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRESTAMO DE LIBRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Lector:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(670, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Libro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha De Prestamo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(670, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(321, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha De Devolucion";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dateT_FDevolu_PrestLib);
            this.groupBox1.Controls.Add(this.dateT_FPrest_PrestLib);
            this.groupBox1.Controls.Add(this.comBox_Libro_PrestLib);
            this.groupBox1.Controls.Add(this.comBox_Cat_PrestLib);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(116, 498);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1353, 388);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Del Libro";
            // 
            // txt_ID_PrestamoLib
            // 
            this.txt_ID_PrestamoLib.Location = new System.Drawing.Point(325, 272);
            this.txt_ID_PrestamoLib.Name = "txt_ID_PrestamoLib";
            this.txt_ID_PrestamoLib.Size = new System.Drawing.Size(100, 44);
            this.txt_ID_PrestamoLib.TabIndex = 8;
            // 
            // txt_Nombre_PrestamoLib
            // 
            this.txt_Nombre_PrestamoLib.Location = new System.Drawing.Point(325, 393);
            this.txt_Nombre_PrestamoLib.Name = "txt_Nombre_PrestamoLib";
            this.txt_Nombre_PrestamoLib.Size = new System.Drawing.Size(100, 44);
            this.txt_Nombre_PrestamoLib.TabIndex = 9;
            // 
            // comBox_Cat_PrestLib
            // 
            this.comBox_Cat_PrestLib.FormattingEnabled = true;
            this.comBox_Cat_PrestLib.Location = new System.Drawing.Point(215, 101);
            this.comBox_Cat_PrestLib.Name = "comBox_Cat_PrestLib";
            this.comBox_Cat_PrestLib.Size = new System.Drawing.Size(121, 45);
            this.comBox_Cat_PrestLib.TabIndex = 7;
            // 
            // comBox_Libro_PrestLib
            // 
            this.comBox_Libro_PrestLib.FormattingEnabled = true;
            this.comBox_Libro_PrestLib.Location = new System.Drawing.Point(820, 106);
            this.comBox_Libro_PrestLib.Name = "comBox_Libro_PrestLib";
            this.comBox_Libro_PrestLib.Size = new System.Drawing.Size(121, 45);
            this.comBox_Libro_PrestLib.TabIndex = 8;
            // 
            // dateT_FPrest_PrestLib
            // 
            this.dateT_FPrest_PrestLib.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateT_FPrest_PrestLib.Location = new System.Drawing.Point(365, 247);
            this.dateT_FPrest_PrestLib.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateT_FPrest_PrestLib.Name = "dateT_FPrest_PrestLib";
            this.dateT_FPrest_PrestLib.Size = new System.Drawing.Size(200, 44);
            this.dateT_FPrest_PrestLib.TabIndex = 9;
            this.dateT_FPrest_PrestLib.Value = new System.DateTime(2021, 7, 12, 0, 0, 0, 0);
            // 
            // dateT_FDevolu_PrestLib
            // 
            this.dateT_FDevolu_PrestLib.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateT_FDevolu_PrestLib.Location = new System.Drawing.Point(1018, 239);
            this.dateT_FDevolu_PrestLib.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateT_FDevolu_PrestLib.Name = "dateT_FDevolu_PrestLib";
            this.dateT_FDevolu_PrestLib.Size = new System.Drawing.Size(200, 44);
            this.dateT_FDevolu_PrestLib.TabIndex = 10;
            this.dateT_FDevolu_PrestLib.Value = new System.DateTime(2021, 7, 12, 0, 0, 0, 0);
            // 
            // dgv_PrestLib
            // 
            this.dgv_PrestLib.AllowUserToAddRows = false;
            this.dgv_PrestLib.AllowUserToDeleteRows = false;
            this.dgv_PrestLib.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgv_PrestLib.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PrestLib.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgv_PrestLib.Location = new System.Drawing.Point(116, 976);
            this.dgv_PrestLib.Name = "dgv_PrestLib";
            this.dgv_PrestLib.ReadOnly = true;
            this.dgv_PrestLib.RowHeadersWidth = 123;
            this.dgv_PrestLib.RowTemplate.Height = 46;
            this.dgv_PrestLib.Size = new System.Drawing.Size(1669, 348);
            this.dgv_PrestLib.TabIndex = 10;
            // 
            // btn_Agregar_PrestLib
            // 
            this.btn_Agregar_PrestLib.Location = new System.Drawing.Point(1803, 530);
            this.btn_Agregar_PrestLib.Name = "btn_Agregar_PrestLib";
            this.btn_Agregar_PrestLib.Size = new System.Drawing.Size(179, 84);
            this.btn_Agregar_PrestLib.TabIndex = 11;
            this.btn_Agregar_PrestLib.Text = "Agregar";
            this.btn_Agregar_PrestLib.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar_PrestLib
            // 
            this.btn_Eliminar_PrestLib.Location = new System.Drawing.Point(1803, 721);
            this.btn_Eliminar_PrestLib.Name = "btn_Eliminar_PrestLib";
            this.btn_Eliminar_PrestLib.Size = new System.Drawing.Size(179, 84);
            this.btn_Eliminar_PrestLib.TabIndex = 12;
            this.btn_Eliminar_PrestLib.Text = "Eliminar";
            this.btn_Eliminar_PrestLib.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "ID ";
            this.Column1.MinimumWidth = 15;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 15;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "Libro";
            this.Column3.MinimumWidth = 15;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 50F;
            this.Column4.HeaderText = "Categoria";
            this.Column4.MinimumWidth = 15;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 50F;
            this.Column5.HeaderText = "Fecha de Prestamo";
            this.Column5.MinimumWidth = 15;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 50F;
            this.Column6.HeaderText = "Fecha De Devolucion";
            this.Column6.MinimumWidth = 15;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 200;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 30F;
            this.Column7.HeaderText = "Total a Pagar";
            this.Column7.MinimumWidth = 15;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 200;
            // 
            // FrmRealizarP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2220, 1383);
            this.Controls.Add(this.btn_Eliminar_PrestLib);
            this.Controls.Add(this.btn_Agregar_PrestLib);
            this.Controls.Add(this.dgv_PrestLib);
            this.Controls.Add(this.txt_Nombre_PrestamoLib);
            this.Controls.Add(this.txt_ID_PrestamoLib);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRealizarP";
            this.Text = "PRESTAMO";
            this.Load += new System.EventHandler(this.FrmRealizarP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PrestLib)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateT_FDevolu_PrestLib;
        private System.Windows.Forms.DateTimePicker dateT_FPrest_PrestLib;
        private System.Windows.Forms.ComboBox comBox_Libro_PrestLib;
        private System.Windows.Forms.ComboBox comBox_Cat_PrestLib;
        private System.Windows.Forms.TextBox txt_ID_PrestamoLib;
        private System.Windows.Forms.TextBox txt_Nombre_PrestamoLib;
        private System.Windows.Forms.DataGridView dgv_PrestLib;
        private System.Windows.Forms.Button btn_Agregar_PrestLib;
        private System.Windows.Forms.Button btn_Eliminar_PrestLib;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}