
namespace Proyecto_Biblioteca
{
    partial class FrmAutor
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
            this.btn_Modi_autor = new System.Windows.Forms.Button();
            this.btn_Agre_autor = new System.Windows.Forms.Button();
            this.dgv_admi_cat = new System.Windows.Forms.DataGridView();
            this.txt_Telefono_autor = new System.Windows.Forms.TextBox();
            this.txt_Apellido_autor = new System.Windows.Forms.TextBox();
            this.txt_Nombre_autor = new System.Windows.Forms.TextBox();
            this.txt_Id_autor = new System.Windows.Forms.TextBox();
            this.Telefono_UsuarioSist = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admi_cat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(765, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "AUTOR ";
            // 
            // btn_Modi_autor
            // 
            this.btn_Modi_autor.Location = new System.Drawing.Point(1288, 559);
            this.btn_Modi_autor.Name = "btn_Modi_autor";
            this.btn_Modi_autor.Size = new System.Drawing.Size(196, 102);
            this.btn_Modi_autor.TabIndex = 30;
            this.btn_Modi_autor.Text = "Modificar";
            this.btn_Modi_autor.UseVisualStyleBackColor = true;
            // 
            // btn_Agre_autor
            // 
            this.btn_Agre_autor.Location = new System.Drawing.Point(1288, 394);
            this.btn_Agre_autor.Name = "btn_Agre_autor";
            this.btn_Agre_autor.Size = new System.Drawing.Size(196, 94);
            this.btn_Agre_autor.TabIndex = 29;
            this.btn_Agre_autor.Text = "Agregar";
            this.btn_Agre_autor.UseVisualStyleBackColor = true;
            // 
            // dgv_admi_cat
            // 
            this.dgv_admi_cat.AllowUserToAddRows = false;
            this.dgv_admi_cat.AllowUserToDeleteRows = false;
            this.dgv_admi_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admi_cat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_admi_cat.Location = new System.Drawing.Point(168, 916);
            this.dgv_admi_cat.Name = "dgv_admi_cat";
            this.dgv_admi_cat.ReadOnly = true;
            this.dgv_admi_cat.RowHeadersWidth = 123;
            this.dgv_admi_cat.RowTemplate.Height = 46;
            this.dgv_admi_cat.Size = new System.Drawing.Size(1427, 226);
            this.dgv_admi_cat.TabIndex = 28;
            // 
            // txt_Telefono_autor
            // 
            this.txt_Telefono_autor.Location = new System.Drawing.Point(392, 692);
            this.txt_Telefono_autor.Name = "txt_Telefono_autor";
            this.txt_Telefono_autor.Size = new System.Drawing.Size(183, 44);
            this.txt_Telefono_autor.TabIndex = 23;
            // 
            // txt_Apellido_autor
            // 
            this.txt_Apellido_autor.Location = new System.Drawing.Point(392, 559);
            this.txt_Apellido_autor.Name = "txt_Apellido_autor";
            this.txt_Apellido_autor.Size = new System.Drawing.Size(183, 44);
            this.txt_Apellido_autor.TabIndex = 22;
            // 
            // txt_Nombre_autor
            // 
            this.txt_Nombre_autor.Location = new System.Drawing.Point(392, 417);
            this.txt_Nombre_autor.Name = "txt_Nombre_autor";
            this.txt_Nombre_autor.Size = new System.Drawing.Size(183, 44);
            this.txt_Nombre_autor.TabIndex = 21;
            // 
            // txt_Id_autor
            // 
            this.txt_Id_autor.Location = new System.Drawing.Point(392, 281);
            this.txt_Id_autor.Name = "txt_Id_autor";
            this.txt_Id_autor.Size = new System.Drawing.Size(183, 44);
            this.txt_Id_autor.TabIndex = 20;
            // 
            // Telefono_UsuarioSist
            // 
            this.Telefono_UsuarioSist.AutoSize = true;
            this.Telefono_UsuarioSist.Location = new System.Drawing.Point(161, 695);
            this.Telefono_UsuarioSist.Name = "Telefono_UsuarioSist";
            this.Telefono_UsuarioSist.Size = new System.Drawing.Size(213, 37);
            this.Telefono_UsuarioSist.TabIndex = 19;
            this.Telefono_UsuarioSist.Text = "Nacionalidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 562);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 37);
            this.label4.TabIndex = 18;
            this.label4.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 37);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 37);
            this.label2.TabIndex = 16;
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
            this.Column5.HeaderText = "Nacionalidad";
            this.Column5.MinimumWidth = 15;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 250;
            // 
            // FrmAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 1410);
            this.Controls.Add(this.btn_Modi_autor);
            this.Controls.Add(this.btn_Agre_autor);
            this.Controls.Add(this.dgv_admi_cat);
            this.Controls.Add(this.txt_Telefono_autor);
            this.Controls.Add(this.txt_Apellido_autor);
            this.Controls.Add(this.txt_Nombre_autor);
            this.Controls.Add(this.txt_Id_autor);
            this.Controls.Add(this.Telefono_UsuarioSist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAutor";
            this.Text = "AUTOR";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admi_cat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Modi_autor;
        private System.Windows.Forms.Button btn_Agre_autor;
        private System.Windows.Forms.DataGridView dgv_admi_cat;
        private System.Windows.Forms.TextBox txt_Telefono_autor;
        private System.Windows.Forms.TextBox txt_Apellido_autor;
        private System.Windows.Forms.TextBox txt_Nombre_autor;
        private System.Windows.Forms.TextBox txt_Id_autor;
        private System.Windows.Forms.Label Telefono_UsuarioSist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}