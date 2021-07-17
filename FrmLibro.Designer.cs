
namespace Proyecto_Biblioteca
{
    partial class FrmLibro
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
            this.btn_Modi_libro = new System.Windows.Forms.Button();
            this.btn_Agre_libro = new System.Windows.Forms.Button();
            this.dgv_admi_libro = new System.Windows.Forms.DataGridView();
            this.txt_npaginas_libro = new System.Windows.Forms.TextBox();
            this.txt_edicion_libro = new System.Windows.Forms.TextBox();
            this.txt_titulo_libro = new System.Windows.Forms.TextBox();
            this.txt_Id_libro = new System.Windows.Forms.TextBox();
            this.Telefono_UsuarioSist = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admi_libro)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Modi_libro
            // 
            this.btn_Modi_libro.Location = new System.Drawing.Point(1062, 586);
            this.btn_Modi_libro.Name = "btn_Modi_libro";
            this.btn_Modi_libro.Size = new System.Drawing.Size(196, 102);
            this.btn_Modi_libro.TabIndex = 42;
            this.btn_Modi_libro.Text = "Modificar";
            this.btn_Modi_libro.UseVisualStyleBackColor = true;
            // 
            // btn_Agre_libro
            // 
            this.btn_Agre_libro.Location = new System.Drawing.Point(1062, 421);
            this.btn_Agre_libro.Name = "btn_Agre_libro";
            this.btn_Agre_libro.Size = new System.Drawing.Size(196, 94);
            this.btn_Agre_libro.TabIndex = 41;
            this.btn_Agre_libro.Text = "Agregar";
            this.btn_Agre_libro.UseVisualStyleBackColor = true;
            // 
            // dgv_admi_libro
            // 
            this.dgv_admi_libro.AllowUserToAddRows = false;
            this.dgv_admi_libro.AllowUserToDeleteRows = false;
            this.dgv_admi_libro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admi_libro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_admi_libro.Location = new System.Drawing.Point(172, 938);
            this.dgv_admi_libro.Name = "dgv_admi_libro";
            this.dgv_admi_libro.ReadOnly = true;
            this.dgv_admi_libro.RowHeadersWidth = 123;
            this.dgv_admi_libro.RowTemplate.Height = 46;
            this.dgv_admi_libro.Size = new System.Drawing.Size(1173, 226);
            this.dgv_admi_libro.TabIndex = 40;
            // 
            // txt_npaginas_libro
            // 
            this.txt_npaginas_libro.Location = new System.Drawing.Point(389, 749);
            this.txt_npaginas_libro.Name = "txt_npaginas_libro";
            this.txt_npaginas_libro.Size = new System.Drawing.Size(183, 44);
            this.txt_npaginas_libro.TabIndex = 39;
            // 
            // txt_edicion_libro
            // 
            this.txt_edicion_libro.Location = new System.Drawing.Point(389, 616);
            this.txt_edicion_libro.Name = "txt_edicion_libro";
            this.txt_edicion_libro.Size = new System.Drawing.Size(183, 44);
            this.txt_edicion_libro.TabIndex = 38;
            // 
            // txt_titulo_libro
            // 
            this.txt_titulo_libro.Location = new System.Drawing.Point(389, 474);
            this.txt_titulo_libro.Name = "txt_titulo_libro";
            this.txt_titulo_libro.Size = new System.Drawing.Size(183, 44);
            this.txt_titulo_libro.TabIndex = 37;
            // 
            // txt_Id_libro
            // 
            this.txt_Id_libro.Location = new System.Drawing.Point(389, 338);
            this.txt_Id_libro.Name = "txt_Id_libro";
            this.txt_Id_libro.Size = new System.Drawing.Size(183, 44);
            this.txt_Id_libro.TabIndex = 36;
            // 
            // Telefono_UsuarioSist
            // 
            this.Telefono_UsuarioSist.AutoSize = true;
            this.Telefono_UsuarioSist.Location = new System.Drawing.Point(158, 752);
            this.Telefono_UsuarioSist.Name = "Telefono_UsuarioSist";
            this.Telefono_UsuarioSist.Size = new System.Drawing.Size(184, 37);
            this.Telefono_UsuarioSist.TabIndex = 35;
            this.Telefono_UsuarioSist.Text = "N. Paginas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 619);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 37);
            this.label4.TabIndex = 34;
            this.label4.Text = "Edicion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 37);
            this.label3.TabIndex = 33;
            this.label3.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 37);
            this.label2.TabIndex = 32;
            this.label2.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(674, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 64);
            this.label1.TabIndex = 31;
            this.label1.Text = "LIBRO";
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
            this.Column2.HeaderText = "Titulo";
            this.Column2.MinimumWidth = 15;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Edicion";
            this.Column3.MinimumWidth = 15;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "N. Paginas";
            this.Column4.MinimumWidth = 15;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            // 
            // FrmLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 1372);
            this.Controls.Add(this.btn_Modi_libro);
            this.Controls.Add(this.btn_Agre_libro);
            this.Controls.Add(this.dgv_admi_libro);
            this.Controls.Add(this.txt_npaginas_libro);
            this.Controls.Add(this.txt_edicion_libro);
            this.Controls.Add(this.txt_titulo_libro);
            this.Controls.Add(this.txt_Id_libro);
            this.Controls.Add(this.Telefono_UsuarioSist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLibro";
            this.Text = "LIBRO ";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admi_libro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Modi_libro;
        private System.Windows.Forms.Button btn_Agre_libro;
        private System.Windows.Forms.DataGridView dgv_admi_libro;
        private System.Windows.Forms.TextBox txt_npaginas_libro;
        private System.Windows.Forms.TextBox txt_edicion_libro;
        private System.Windows.Forms.TextBox txt_titulo_libro;
        private System.Windows.Forms.TextBox txt_Id_libro;
        private System.Windows.Forms.Label Telefono_UsuarioSist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}