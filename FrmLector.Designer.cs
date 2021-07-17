
namespace Proyecto_Biblioteca
{
    partial class FrmLector
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
            this.btn_modi_lector = new System.Windows.Forms.Button();
            this.btn_agre_lector = new System.Windows.Forms.Button();
            this.dgv_admi_lector = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_FechaNac_lector = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Direcc_lector = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Telefono_lector = new System.Windows.Forms.TextBox();
            this.txt_Apellido_lector = new System.Windows.Forms.TextBox();
            this.txt_Nombre_lector = new System.Windows.Forms.TextBox();
            this.txt_Id_lector = new System.Windows.Forms.TextBox();
            this.Telefono_UsuarioSist = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admi_lector)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_modi_lector
            // 
            this.btn_modi_lector.Location = new System.Drawing.Point(1226, 542);
            this.btn_modi_lector.Name = "btn_modi_lector";
            this.btn_modi_lector.Size = new System.Drawing.Size(196, 102);
            this.btn_modi_lector.TabIndex = 31;
            this.btn_modi_lector.Text = "Modificar";
            this.btn_modi_lector.UseVisualStyleBackColor = true;
            // 
            // btn_agre_lector
            // 
            this.btn_agre_lector.Location = new System.Drawing.Point(1226, 377);
            this.btn_agre_lector.Name = "btn_agre_lector";
            this.btn_agre_lector.Size = new System.Drawing.Size(196, 94);
            this.btn_agre_lector.TabIndex = 30;
            this.btn_agre_lector.Text = "Agregar";
            this.btn_agre_lector.UseVisualStyleBackColor = true;
            // 
            // dgv_admi_lector
            // 
            this.dgv_admi_lector.AllowUserToAddRows = false;
            this.dgv_admi_lector.AllowUserToDeleteRows = false;
            this.dgv_admi_lector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admi_lector.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgv_admi_lector.Location = new System.Drawing.Point(58, 1072);
            this.dgv_admi_lector.Name = "dgv_admi_lector";
            this.dgv_admi_lector.ReadOnly = true;
            this.dgv_admi_lector.RowHeadersWidth = 123;
            this.dgv_admi_lector.RowTemplate.Height = 46;
            this.dgv_admi_lector.Size = new System.Drawing.Size(1924, 226);
            this.dgv_admi_lector.TabIndex = 29;
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
            this.Column3.HeaderText = "Apellido";
            this.Column3.MinimumWidth = 15;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefono";
            this.Column4.MinimumWidth = 15;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Direccion";
            this.Column5.MinimumWidth = 15;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 250;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fecha de Nacimiento";
            this.Column6.MinimumWidth = 15;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 250;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Actividad";
            this.Column7.MinimumWidth = 15;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 250;
            // 
            // txt_FechaNac_lector
            // 
            this.txt_FechaNac_lector.Location = new System.Drawing.Point(536, 909);
            this.txt_FechaNac_lector.Name = "txt_FechaNac_lector";
            this.txt_FechaNac_lector.Size = new System.Drawing.Size(100, 44);
            this.txt_FechaNac_lector.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 917);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 37);
            this.label6.TabIndex = 27;
            this.label6.Text = "Fecha de Nacimiento:";
            // 
            // txt_Direcc_lector
            // 
            this.txt_Direcc_lector.Location = new System.Drawing.Point(382, 801);
            this.txt_Direcc_lector.Name = "txt_Direcc_lector";
            this.txt_Direcc_lector.Size = new System.Drawing.Size(100, 44);
            this.txt_Direcc_lector.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 808);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 37);
            this.label5.TabIndex = 25;
            this.label5.Text = "Dirrecion: ";
            // 
            // txt_Telefono_lector
            // 
            this.txt_Telefono_lector.Location = new System.Drawing.Point(382, 675);
            this.txt_Telefono_lector.Name = "txt_Telefono_lector";
            this.txt_Telefono_lector.Size = new System.Drawing.Size(100, 44);
            this.txt_Telefono_lector.TabIndex = 24;
            // 
            // txt_Apellido_lector
            // 
            this.txt_Apellido_lector.Location = new System.Drawing.Point(382, 535);
            this.txt_Apellido_lector.Name = "txt_Apellido_lector";
            this.txt_Apellido_lector.Size = new System.Drawing.Size(100, 44);
            this.txt_Apellido_lector.TabIndex = 23;
            // 
            // txt_Nombre_lector
            // 
            this.txt_Nombre_lector.Location = new System.Drawing.Point(382, 393);
            this.txt_Nombre_lector.Name = "txt_Nombre_lector";
            this.txt_Nombre_lector.Size = new System.Drawing.Size(100, 44);
            this.txt_Nombre_lector.TabIndex = 22;
            // 
            // txt_Id_lector
            // 
            this.txt_Id_lector.Location = new System.Drawing.Point(382, 257);
            this.txt_Id_lector.Name = "txt_Id_lector";
            this.txt_Id_lector.Size = new System.Drawing.Size(100, 44);
            this.txt_Id_lector.TabIndex = 21;
            // 
            // Telefono_UsuarioSist
            // 
            this.Telefono_UsuarioSist.AutoSize = true;
            this.Telefono_UsuarioSist.Location = new System.Drawing.Point(183, 675);
            this.Telefono_UsuarioSist.Name = "Telefono_UsuarioSist";
            this.Telefono_UsuarioSist.Size = new System.Drawing.Size(150, 37);
            this.Telefono_UsuarioSist.TabIndex = 20;
            this.Telefono_UsuarioSist.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 37);
            this.label4.TabIndex = 19;
            this.label4.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 37);
            this.label2.TabIndex = 17;
            this.label2.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(839, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 64);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lector";
            // 
            // FrmLector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2014, 1387);
            this.Controls.Add(this.btn_modi_lector);
            this.Controls.Add(this.btn_agre_lector);
            this.Controls.Add(this.dgv_admi_lector);
            this.Controls.Add(this.txt_FechaNac_lector);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Direcc_lector);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Telefono_lector);
            this.Controls.Add(this.txt_Apellido_lector);
            this.Controls.Add(this.txt_Nombre_lector);
            this.Controls.Add(this.txt_Id_lector);
            this.Controls.Add(this.Telefono_UsuarioSist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLector";
            this.Text = "LECTOR";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admi_lector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modi_lector;
        private System.Windows.Forms.Button btn_agre_lector;
        private System.Windows.Forms.DataGridView dgv_admi_lector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox txt_FechaNac_lector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Direcc_lector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Telefono_lector;
        private System.Windows.Forms.TextBox txt_Apellido_lector;
        private System.Windows.Forms.TextBox txt_Nombre_lector;
        private System.Windows.Forms.TextBox txt_Id_lector;
        private System.Windows.Forms.Label Telefono_UsuarioSist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}