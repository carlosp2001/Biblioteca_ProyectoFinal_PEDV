
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLector));
            this.btn_modi_lector = new System.Windows.Forms.Button();
            this.btn_agre_lector = new System.Windows.Forms.Button();
            this.dgv_admi_lector = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Direcc_lector = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Telefono_lector = new System.Windows.Forms.TextBox();
            this.txt_Nombre_lector = new System.Windows.Forms.TextBox();
            this.Telefono_UsuarioSist = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.txt_dni_lector = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admi_lector)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_modi_lector
            // 
            this.btn_modi_lector.BackColor = System.Drawing.Color.Silver;
            this.btn_modi_lector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_modi_lector.Location = new System.Drawing.Point(500, 197);
            this.btn_modi_lector.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_modi_lector.Name = "btn_modi_lector";
            this.btn_modi_lector.Size = new System.Drawing.Size(62, 36);
            this.btn_modi_lector.TabIndex = 31;
            this.btn_modi_lector.Text = "Modificar";
            this.btn_modi_lector.UseVisualStyleBackColor = false;
            this.btn_modi_lector.Click += new System.EventHandler(this.btn_modi_lector_Click);
            // 
            // btn_agre_lector
            // 
            this.btn_agre_lector.BackColor = System.Drawing.Color.Silver;
            this.btn_agre_lector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_agre_lector.Location = new System.Drawing.Point(500, 78);
            this.btn_agre_lector.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_agre_lector.Name = "btn_agre_lector";
            this.btn_agre_lector.Size = new System.Drawing.Size(62, 33);
            this.btn_agre_lector.TabIndex = 30;
            this.btn_agre_lector.Text = "Agregar";
            this.btn_agre_lector.UseVisualStyleBackColor = false;
            this.btn_agre_lector.Click += new System.EventHandler(this.btn_agre_lector_Click);
            // 
            // dgv_admi_lector
            // 
            this.dgv_admi_lector.AllowUserToAddRows = false;
            this.dgv_admi_lector.AllowUserToDeleteRows = false;
            this.dgv_admi_lector.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgv_admi_lector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admi_lector.Location = new System.Drawing.Point(18, 268);
            this.dgv_admi_lector.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgv_admi_lector.Name = "dgv_admi_lector";
            this.dgv_admi_lector.ReadOnly = true;
            this.dgv_admi_lector.RowHeadersWidth = 123;
            this.dgv_admi_lector.RowTemplate.Height = 46;
            this.dgv_admi_lector.Size = new System.Drawing.Size(608, 188);
            this.dgv_admi_lector.TabIndex = 29;
            this.dgv_admi_lector.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_admi_lector_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(216, 185);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Fecha de Nacimiento:";
            // 
            // txt_Direcc_lector
            // 
            this.txt_Direcc_lector.Location = new System.Drawing.Point(279, 144);
            this.txt_Direcc_lector.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txt_Direcc_lector.Name = "txt_Direcc_lector";
            this.txt_Direcc_lector.Size = new System.Drawing.Size(125, 20);
            this.txt_Direcc_lector.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(218, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Direccion: ";
            // 
            // txt_Telefono_lector
            // 
            this.txt_Telefono_lector.Location = new System.Drawing.Point(75, 206);
            this.txt_Telefono_lector.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txt_Telefono_lector.Name = "txt_Telefono_lector";
            this.txt_Telefono_lector.Size = new System.Drawing.Size(101, 20);
            this.txt_Telefono_lector.TabIndex = 24;
            // 
            // txt_Nombre_lector
            // 
            this.txt_Nombre_lector.Location = new System.Drawing.Point(75, 144);
            this.txt_Nombre_lector.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txt_Nombre_lector.Name = "txt_Nombre_lector";
            this.txt_Nombre_lector.Size = new System.Drawing.Size(101, 20);
            this.txt_Nombre_lector.TabIndex = 22;
            // 
            // Telefono_UsuarioSist
            // 
            this.Telefono_UsuarioSist.AutoSize = true;
            this.Telefono_UsuarioSist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono_UsuarioSist.ForeColor = System.Drawing.Color.Silver;
            this.Telefono_UsuarioSist.Location = new System.Drawing.Point(15, 209);
            this.Telefono_UsuarioSist.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Telefono_UsuarioSist.Name = "Telefono_UsuarioSist";
            this.Telefono_UsuarioSist.Size = new System.Drawing.Size(61, 13);
            this.Telefono_UsuarioSist.TabIndex = 20;
            this.Telefono_UsuarioSist.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(15, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(254, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lector";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.Silver;
            this.btn_Eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Eliminar.Location = new System.Drawing.Point(500, 136);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(62, 36);
            this.btn_Eliminar.TabIndex = 32;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // txt_dni_lector
            // 
            this.txt_dni_lector.Location = new System.Drawing.Point(75, 86);
            this.txt_dni_lector.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txt_dni_lector.Name = "txt_dni_lector";
            this.txt_dni_lector.Size = new System.Drawing.Size(101, 20);
            this.txt_dni_lector.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(17, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "DNI:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(331, 183);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // FrmLector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(647, 486);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_dni_lector);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_modi_lector);
            this.Controls.Add(this.btn_agre_lector);
            this.Controls.Add(this.dgv_admi_lector);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Direcc_lector);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Telefono_lector);
            this.Controls.Add(this.txt_Nombre_lector);
            this.Controls.Add(this.Telefono_UsuarioSist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FrmLector";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LECTOR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLector_FormClosed);
            this.Load += new System.EventHandler(this.FrmLector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admi_lector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modi_lector;
        private System.Windows.Forms.Button btn_agre_lector;
        private System.Windows.Forms.DataGridView dgv_admi_lector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Direcc_lector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Telefono_lector;
        private System.Windows.Forms.TextBox txt_Nombre_lector;
        private System.Windows.Forms.Label Telefono_UsuarioSist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.TextBox txt_dni_lector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}