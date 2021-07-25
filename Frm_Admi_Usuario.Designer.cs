
namespace Proyecto_Biblioteca
{
    partial class Frm_Admi_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Admi_Usuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Id_UsuarioSist = new System.Windows.Forms.TextBox();
            this.txt_Nombre_UsuarioSist = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Eliminar_Usuario = new System.Windows.Forms.Button();
            this.txt_nombreusuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(571, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(863, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario Sistema ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(106, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(106, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(112, 653);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Usuario:";
            // 
            // txt_Id_UsuarioSist
            // 
            this.txt_Id_UsuarioSist.Location = new System.Drawing.Point(453, 290);
            this.txt_Id_UsuarioSist.Name = "txt_Id_UsuarioSist";
            this.txt_Id_UsuarioSist.Size = new System.Drawing.Size(99, 44);
            this.txt_Id_UsuarioSist.TabIndex = 5;
            // 
            // txt_Nombre_UsuarioSist
            // 
            this.txt_Nombre_UsuarioSist.Location = new System.Drawing.Point(453, 511);
            this.txt_Nombre_UsuarioSist.Name = "txt_Nombre_UsuarioSist";
            this.txt_Nombre_UsuarioSist.Size = new System.Drawing.Size(330, 44);
            this.txt_Nombre_UsuarioSist.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 777);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 46;
            this.dataGridView1.Size = new System.Drawing.Size(1723, 546);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(1473, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 94);
            this.button1.TabIndex = 14;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button2.Location = new System.Drawing.Point(1473, 605);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 102);
            this.button2.TabIndex = 15;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(453, 635);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(375, 45);
            this.comboBox1.TabIndex = 16;
            // 
            // btn_Eliminar_Usuario
            // 
            this.btn_Eliminar_Usuario.BackColor = System.Drawing.Color.Silver;
            this.btn_Eliminar_Usuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Eliminar_Usuario.Location = new System.Drawing.Point(1473, 454);
            this.btn_Eliminar_Usuario.Name = "btn_Eliminar_Usuario";
            this.btn_Eliminar_Usuario.Size = new System.Drawing.Size(196, 102);
            this.btn_Eliminar_Usuario.TabIndex = 17;
            this.btn_Eliminar_Usuario.Text = "Eliminar";
            this.btn_Eliminar_Usuario.UseVisualStyleBackColor = false;
            this.btn_Eliminar_Usuario.Click += new System.EventHandler(this.btn_Eliminar_Usuario_Click);
            // 
            // txt_nombreusuario
            // 
            this.txt_nombreusuario.Location = new System.Drawing.Point(453, 393);
            this.txt_nombreusuario.Name = "txt_nombreusuario";
            this.txt_nombreusuario.Size = new System.Drawing.Size(330, 44);
            this.txt_nombreusuario.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(106, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 37);
            this.label5.TabIndex = 19;
            this.label5.Text = "Id Usuario:";
            // 
            // Frm_Admi_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1925, 1378);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nombreusuario);
            this.Controls.Add(this.btn_Eliminar_Usuario);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Nombre_UsuarioSist);
            this.Controls.Add(this.txt_Id_UsuarioSist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Admi_Usuario";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario Sistema";
            this.Load += new System.EventHandler(this.Frm_Admi_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Id_UsuarioSist;
        private System.Windows.Forms.TextBox txt_Nombre_UsuarioSist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Eliminar_Usuario;
        private System.Windows.Forms.TextBox txt_nombreusuario;
        private System.Windows.Forms.Label label5;
    }
}