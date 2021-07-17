
namespace Proyecto_Biblioteca
{
    partial class FrmRecibirEntre
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
            this.txt_Nombre_RecibirLib = new System.Windows.Forms.TextBox();
            this.txt_ID_RecibirLib = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateT_FDevolu_RecibLib = new System.Windows.Forms.DateTimePicker();
            this.dateT_FPrest_RecibLib = new System.Windows.Forms.DateTimePicker();
            this.comBox_Libro_RecibLib = new System.Windows.Forms.ComboBox();
            this.comBox_Cat_RecibLib = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Nombre_RecibirLib
            // 
            this.txt_Nombre_RecibirLib.Location = new System.Drawing.Point(410, 422);
            this.txt_Nombre_RecibirLib.Name = "txt_Nombre_RecibirLib";
            this.txt_Nombre_RecibirLib.Size = new System.Drawing.Size(100, 44);
            this.txt_Nombre_RecibirLib.TabIndex = 15;
            // 
            // txt_ID_RecibirLib
            // 
            this.txt_ID_RecibirLib.Location = new System.Drawing.Point(410, 301);
            this.txt_ID_RecibirLib.Name = "txt_ID_RecibirLib";
            this.txt_ID_RecibirLib.Size = new System.Drawing.Size(100, 44);
            this.txt_ID_RecibirLib.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dateT_FDevolu_RecibLib);
            this.groupBox1.Controls.Add(this.dateT_FPrest_RecibLib);
            this.groupBox1.Controls.Add(this.comBox_Libro_RecibLib);
            this.groupBox1.Controls.Add(this.comBox_Cat_RecibLib);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(181, 609);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1353, 388);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Del Libro";
            // 
            // dateT_FDevolu_RecibLib
            // 
            this.dateT_FDevolu_RecibLib.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateT_FDevolu_RecibLib.Location = new System.Drawing.Point(1018, 239);
            this.dateT_FDevolu_RecibLib.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateT_FDevolu_RecibLib.Name = "dateT_FDevolu_RecibLib";
            this.dateT_FDevolu_RecibLib.Size = new System.Drawing.Size(200, 44);
            this.dateT_FDevolu_RecibLib.TabIndex = 10;
            this.dateT_FDevolu_RecibLib.Value = new System.DateTime(2021, 7, 12, 0, 0, 0, 0);
            // 
            // dateT_FPrest_RecibLib
            // 
            this.dateT_FPrest_RecibLib.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateT_FPrest_RecibLib.Location = new System.Drawing.Point(365, 247);
            this.dateT_FPrest_RecibLib.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateT_FPrest_RecibLib.Name = "dateT_FPrest_RecibLib";
            this.dateT_FPrest_RecibLib.Size = new System.Drawing.Size(200, 44);
            this.dateT_FPrest_RecibLib.TabIndex = 9;
            this.dateT_FPrest_RecibLib.Value = new System.DateTime(2021, 7, 12, 0, 0, 0, 0);
            // 
            // comBox_Libro_RecibLib
            // 
            this.comBox_Libro_RecibLib.FormattingEnabled = true;
            this.comBox_Libro_RecibLib.Location = new System.Drawing.Point(820, 106);
            this.comBox_Libro_RecibLib.Name = "comBox_Libro_RecibLib";
            this.comBox_Libro_RecibLib.Size = new System.Drawing.Size(121, 45);
            this.comBox_Libro_RecibLib.TabIndex = 8;
            // 
            // comBox_Cat_RecibLib
            // 
            this.comBox_Cat_RecibLib.FormattingEnabled = true;
            this.comBox_Cat_RecibLib.Location = new System.Drawing.Point(215, 101);
            this.comBox_Cat_RecibLib.Name = "comBox_Cat_RecibLib";
            this.comBox_Cat_RecibLib.Size = new System.Drawing.Size(121, 45);
            this.comBox_Cat_RecibLib.TabIndex = 7;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(670, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(321, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha De Devolucion";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID Lector:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(767, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 70);
            this.label1.TabIndex = 10;
            this.label1.Text = "Recibir Libro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmRecibirEntre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2063, 1251);
            this.Controls.Add(this.txt_Nombre_RecibirLib);
            this.Controls.Add(this.txt_ID_RecibirLib);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRecibirEntre";
            this.Text = "ENTREGA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nombre_RecibirLib;
        private System.Windows.Forms.TextBox txt_ID_RecibirLib;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateT_FDevolu_RecibLib;
        private System.Windows.Forms.DateTimePicker dateT_FPrest_RecibLib;
        private System.Windows.Forms.ComboBox comBox_Libro_RecibLib;
        private System.Windows.Forms.ComboBox comBox_Cat_RecibLib;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}