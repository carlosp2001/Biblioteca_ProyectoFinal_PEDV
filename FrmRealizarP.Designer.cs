
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateT_FDevolu_PrestLib = new System.Windows.Forms.DateTimePicker();
            this.dateT_FPrest_PrestLib = new System.Windows.Forms.DateTimePicker();
            this.lbl_fechalimite = new System.Windows.Forms.Label();
            this.txt_ID_PrestamoLib = new System.Windows.Forms.TextBox();
            this.txt_Nombre_PrestamoLib = new System.Windows.Forms.TextBox();
            this.dgv_PrestLib = new System.Windows.Forms.DataGridView();
            this.btn_Agregar_PrestLib = new System.Windows.Forms.Button();
            this.btn_Eliminar_PrestLib = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_libros = new System.Windows.Forms.DataGridView();
            this.dtp_fechalimite = new System.Windows.Forms.DateTimePicker();
            this.btn_Devolucion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PrestLib)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_libros)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_LIBRO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_LIBRO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TITULO_DEL_LIBRO";
            this.dataGridViewTextBoxColumn2.HeaderText = "TITULO_DEL_LIBRO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EDICION_DEL_LIBRO";
            this.dataGridViewTextBoxColumn3.HeaderText = "EDICION_DEL_LIBRO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NUMERO_DE_PAGINAS";
            this.dataGridViewTextBoxColumn4.HeaderText = "NUMERO_DE_PAGINAS";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NOMBRE_CATEGORIA";
            this.dataGridViewTextBoxColumn5.HeaderText = "NOMBRE_CATEGORIA";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NOMBRE_EDITORIAL";
            this.dataGridViewTextBoxColumn6.HeaderText = "NOMBRE_EDITORIAL";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NOMBRES_AUTOR";
            this.dataGridViewTextBoxColumn7.HeaderText = "NOMBRES_AUTOR";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRESTAMO DE LIBRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI Lector:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha De Prestamo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha De Devolucion";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dtp_fechalimite);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dgv_libros);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateT_FDevolu_PrestLib);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_fechalimite);
            this.groupBox1.Controls.Add(this.dateT_FPrest_PrestLib);
            this.groupBox1.Location = new System.Drawing.Point(37, 192);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(629, 225);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Del Libro";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(682, 36);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(1);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(82, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2021, 7, 12, 0, 0, 0, 0);
            // 
            // dateT_FDevolu_PrestLib
            // 
            this.dateT_FDevolu_PrestLib.Enabled = false;
            this.dateT_FDevolu_PrestLib.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateT_FDevolu_PrestLib.Location = new System.Drawing.Point(531, 159);
            this.dateT_FDevolu_PrestLib.Margin = new System.Windows.Forms.Padding(1);
            this.dateT_FDevolu_PrestLib.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateT_FDevolu_PrestLib.Name = "dateT_FDevolu_PrestLib";
            this.dateT_FDevolu_PrestLib.Size = new System.Drawing.Size(82, 20);
            this.dateT_FDevolu_PrestLib.TabIndex = 10;
            this.dateT_FDevolu_PrestLib.Value = new System.DateTime(2021, 7, 12, 0, 0, 0, 0);
            // 
            // dateT_FPrest_PrestLib
            // 
            this.dateT_FPrest_PrestLib.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateT_FPrest_PrestLib.Location = new System.Drawing.Point(531, 30);
            this.dateT_FPrest_PrestLib.Margin = new System.Windows.Forms.Padding(1);
            this.dateT_FPrest_PrestLib.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateT_FPrest_PrestLib.Name = "dateT_FPrest_PrestLib";
            this.dateT_FPrest_PrestLib.Size = new System.Drawing.Size(76, 20);
            this.dateT_FPrest_PrestLib.TabIndex = 9;
            this.dateT_FPrest_PrestLib.Value = new System.DateTime(2021, 7, 12, 0, 0, 0, 0);
            // 
            // lbl_fechalimite
            // 
            this.lbl_fechalimite.AutoSize = true;
            this.lbl_fechalimite.Location = new System.Drawing.Point(418, 95);
            this.lbl_fechalimite.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_fechalimite.Name = "lbl_fechalimite";
            this.lbl_fechalimite.Size = new System.Drawing.Size(70, 13);
            this.lbl_fechalimite.TabIndex = 11;
            this.lbl_fechalimite.Text = "Fecha Limite:";
            // 
            // txt_ID_PrestamoLib
            // 
            this.txt_ID_PrestamoLib.Location = new System.Drawing.Point(139, 89);
            this.txt_ID_PrestamoLib.Margin = new System.Windows.Forms.Padding(1);
            this.txt_ID_PrestamoLib.Name = "txt_ID_PrestamoLib";
            this.txt_ID_PrestamoLib.Size = new System.Drawing.Size(127, 20);
            this.txt_ID_PrestamoLib.TabIndex = 8;
            // 
            // txt_Nombre_PrestamoLib
            // 
            this.txt_Nombre_PrestamoLib.Location = new System.Drawing.Point(139, 140);
            this.txt_Nombre_PrestamoLib.Margin = new System.Windows.Forms.Padding(1);
            this.txt_Nombre_PrestamoLib.Name = "txt_Nombre_PrestamoLib";
            this.txt_Nombre_PrestamoLib.Size = new System.Drawing.Size(127, 20);
            this.txt_Nombre_PrestamoLib.TabIndex = 9;
            this.txt_Nombre_PrestamoLib.TextChanged += new System.EventHandler(this.txt_Nombre_PrestamoLib_TextChanged);
            // 
            // dgv_PrestLib
            // 
            this.dgv_PrestLib.AllowUserToAddRows = false;
            this.dgv_PrestLib.AllowUserToDeleteRows = false;
            this.dgv_PrestLib.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgv_PrestLib.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PrestLib.Location = new System.Drawing.Point(37, 449);
            this.dgv_PrestLib.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_PrestLib.Name = "dgv_PrestLib";
            this.dgv_PrestLib.ReadOnly = true;
            this.dgv_PrestLib.RowHeadersWidth = 123;
            this.dgv_PrestLib.RowTemplate.Height = 46;
            this.dgv_PrestLib.Size = new System.Drawing.Size(607, 234);
            this.dgv_PrestLib.TabIndex = 10;
            this.dgv_PrestLib.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PrestLib_CellClick);
            this.dgv_PrestLib.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PrestLib_CellContentClick);
            // 
            // btn_Agregar_PrestLib
            // 
            this.btn_Agregar_PrestLib.Location = new System.Drawing.Point(609, 56);
            this.btn_Agregar_PrestLib.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Agregar_PrestLib.Name = "btn_Agregar_PrestLib";
            this.btn_Agregar_PrestLib.Size = new System.Drawing.Size(57, 30);
            this.btn_Agregar_PrestLib.TabIndex = 11;
            this.btn_Agregar_PrestLib.Text = "Agregar";
            this.btn_Agregar_PrestLib.UseVisualStyleBackColor = true;
            this.btn_Agregar_PrestLib.Click += new System.EventHandler(this.btn_Agregar_PrestLib_Click);
            // 
            // btn_Eliminar_PrestLib
            // 
            this.btn_Eliminar_PrestLib.Location = new System.Drawing.Point(609, 111);
            this.btn_Eliminar_PrestLib.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Eliminar_PrestLib.Name = "btn_Eliminar_PrestLib";
            this.btn_Eliminar_PrestLib.Size = new System.Drawing.Size(57, 30);
            this.btn_Eliminar_PrestLib.TabIndex = 12;
            this.btn_Eliminar_PrestLib.Text = "Eliminar";
            this.btn_Eliminar_PrestLib.UseVisualStyleBackColor = true;
            this.btn_Eliminar_PrestLib.Click += new System.EventHandler(this.btn_Eliminar_PrestLib_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "DNI del Usuario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 92);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Id de Prestamo:";
            // 
            // dgv_libros
            // 
            this.dgv_libros.AllowUserToAddRows = false;
            this.dgv_libros.AllowUserToDeleteRows = false;
            this.dgv_libros.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgv_libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_libros.Location = new System.Drawing.Point(18, 36);
            this.dgv_libros.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_libros.Name = "dgv_libros";
            this.dgv_libros.ReadOnly = true;
            this.dgv_libros.RowHeadersWidth = 123;
            this.dgv_libros.RowTemplate.Height = 46;
            this.dgv_libros.Size = new System.Drawing.Size(382, 168);
            this.dgv_libros.TabIndex = 15;
            this.dgv_libros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_libros_CellClick);
            // 
            // dtp_fechalimite
            // 
            this.dtp_fechalimite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechalimite.Location = new System.Drawing.Point(531, 95);
            this.dtp_fechalimite.Margin = new System.Windows.Forms.Padding(1);
            this.dtp_fechalimite.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtp_fechalimite.Name = "dtp_fechalimite";
            this.dtp_fechalimite.Size = new System.Drawing.Size(76, 20);
            this.dtp_fechalimite.TabIndex = 16;
            this.dtp_fechalimite.Value = new System.DateTime(2021, 7, 12, 0, 0, 0, 0);
            // 
            // btn_Devolucion
            // 
            this.btn_Devolucion.Location = new System.Drawing.Point(370, 74);
            this.btn_Devolucion.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Devolucion.Name = "btn_Devolucion";
            this.btn_Devolucion.Size = new System.Drawing.Size(155, 67);
            this.btn_Devolucion.TabIndex = 15;
            this.btn_Devolucion.Text = "Confirmar Devolucion";
            this.btn_Devolucion.UseVisualStyleBackColor = true;
            this.btn_Devolucion.Visible = false;
            this.btn_Devolucion.Click += new System.EventHandler(this.btn_Devolucion_Click);
            // 
            // FrmRealizarP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 729);
            this.Controls.Add(this.btn_Devolucion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Eliminar_PrestLib);
            this.Controls.Add(this.btn_Agregar_PrestLib);
            this.Controls.Add(this.dgv_PrestLib);
            this.Controls.Add(this.txt_Nombre_PrestamoLib);
            this.Controls.Add(this.txt_ID_PrestamoLib);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRealizarP";
            this.Text = "PRESTAMO";
            this.Load += new System.EventHandler(this.FrmRealizarP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PrestLib)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_libros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateT_FDevolu_PrestLib;
        private System.Windows.Forms.DateTimePicker dateT_FPrest_PrestLib;
        private System.Windows.Forms.TextBox txt_ID_PrestamoLib;
        private System.Windows.Forms.TextBox txt_Nombre_PrestamoLib;
        private System.Windows.Forms.DataGridView dgv_PrestLib;
        private System.Windows.Forms.Button btn_Agregar_PrestLib;
        private System.Windows.Forms.Button btn_Eliminar_PrestLib;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_fechalimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_libros;
        private System.Windows.Forms.DateTimePicker dtp_fechalimite;
        private System.Windows.Forms.Button btn_Devolucion;
    }
}