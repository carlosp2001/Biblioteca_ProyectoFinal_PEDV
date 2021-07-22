
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
            this.components = new System.ComponentModel.Container();
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
            this.bIBLIOTECADataSet3 = new Proyecto_Biblioteca.BIBLIOTECADataSet3();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosTableAdapter = new Proyecto_Biblioteca.BIBLIOTECADataSet3TableAdapters.LibrosTableAdapter();
            this.btn_Eliminar_Libros = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bIBLIOTECADataSet4 = new Proyecto_Biblioteca.BIBLIOTECADataSet4();
            this.editorialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editorialTableAdapter = new Proyecto_Biblioteca.BIBLIOTECADataSet4TableAdapters.EditorialTableAdapter();
            this.bIBLIOTECADataSet5 = new Proyecto_Biblioteca.BIBLIOTECADataSet5();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new Proyecto_Biblioteca.BIBLIOTECADataSet5TableAdapters.CategoriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admi_libro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Modi_libro
            // 
            this.btn_Modi_libro.Location = new System.Drawing.Point(533, 236);
            this.btn_Modi_libro.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Modi_libro.Name = "btn_Modi_libro";
            this.btn_Modi_libro.Size = new System.Drawing.Size(62, 36);
            this.btn_Modi_libro.TabIndex = 42;
            this.btn_Modi_libro.Text = "Modificar";
            this.btn_Modi_libro.UseVisualStyleBackColor = true;
            // 
            // btn_Agre_libro
            // 
            this.btn_Agre_libro.Location = new System.Drawing.Point(533, 117);
            this.btn_Agre_libro.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Agre_libro.Name = "btn_Agre_libro";
            this.btn_Agre_libro.Size = new System.Drawing.Size(62, 33);
            this.btn_Agre_libro.TabIndex = 41;
            this.btn_Agre_libro.Text = "Agregar";
            this.btn_Agre_libro.UseVisualStyleBackColor = true;
            this.btn_Agre_libro.Click += new System.EventHandler(this.btn_Agre_libro_Click);
            // 
            // dgv_admi_libro
            // 
            this.dgv_admi_libro.AllowUserToAddRows = false;
            this.dgv_admi_libro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_admi_libro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admi_libro.Location = new System.Drawing.Point(54, 330);
            this.dgv_admi_libro.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgv_admi_libro.Name = "dgv_admi_libro";
            this.dgv_admi_libro.RowHeadersWidth = 40;
            this.dgv_admi_libro.RowTemplate.Height = 46;
            this.dgv_admi_libro.Size = new System.Drawing.Size(577, 79);
            this.dgv_admi_libro.TabIndex = 40;
            // 
            // txt_npaginas_libro
            // 
            this.txt_npaginas_libro.Location = new System.Drawing.Point(123, 263);
            this.txt_npaginas_libro.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txt_npaginas_libro.Name = "txt_npaginas_libro";
            this.txt_npaginas_libro.Size = new System.Drawing.Size(61, 20);
            this.txt_npaginas_libro.TabIndex = 39;
            // 
            // txt_edicion_libro
            // 
            this.txt_edicion_libro.Location = new System.Drawing.Point(123, 216);
            this.txt_edicion_libro.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txt_edicion_libro.Name = "txt_edicion_libro";
            this.txt_edicion_libro.Size = new System.Drawing.Size(61, 20);
            this.txt_edicion_libro.TabIndex = 38;
            // 
            // txt_titulo_libro
            // 
            this.txt_titulo_libro.Location = new System.Drawing.Point(123, 167);
            this.txt_titulo_libro.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txt_titulo_libro.Name = "txt_titulo_libro";
            this.txt_titulo_libro.Size = new System.Drawing.Size(61, 20);
            this.txt_titulo_libro.TabIndex = 37;
            // 
            // txt_Id_libro
            // 
            this.txt_Id_libro.Location = new System.Drawing.Point(123, 119);
            this.txt_Id_libro.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txt_Id_libro.Name = "txt_Id_libro";
            this.txt_Id_libro.Size = new System.Drawing.Size(61, 20);
            this.txt_Id_libro.TabIndex = 36;
            // 
            // Telefono_UsuarioSist
            // 
            this.Telefono_UsuarioSist.AutoSize = true;
            this.Telefono_UsuarioSist.Location = new System.Drawing.Point(50, 264);
            this.Telefono_UsuarioSist.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Telefono_UsuarioSist.Name = "Telefono_UsuarioSist";
            this.Telefono_UsuarioSist.Size = new System.Drawing.Size(62, 13);
            this.Telefono_UsuarioSist.TabIndex = 35;
            this.Telefono_UsuarioSist.Text = "N. Paginas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Edicion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "LIBRO";
            // 
            // bIBLIOTECADataSet3
            // 
            this.bIBLIOTECADataSet3.DataSetName = "BIBLIOTECADataSet3";
            this.bIBLIOTECADataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "Libros";
            this.librosBindingSource.DataSource = this.bIBLIOTECADataSet3;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Eliminar_Libros
            // 
            this.btn_Eliminar_Libros.Location = new System.Drawing.Point(533, 178);
            this.btn_Eliminar_Libros.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Eliminar_Libros.Name = "btn_Eliminar_Libros";
            this.btn_Eliminar_Libros.Size = new System.Drawing.Size(62, 33);
            this.btn_Eliminar_Libros.TabIndex = 43;
            this.btn_Eliminar_Libros.Text = "Eliminar";
            this.btn_Eliminar_Libros.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Editorial:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.editorialBindingSource, "NOMBRE_EDITORIAL", true));
            this.comboBox1.DataSource = this.editorialBindingSource;
            this.comboBox1.DisplayMember = "NOMBRE_EDITORIAL";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(310, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 45;
            this.comboBox1.ValueMember = "NOMBRE_EDITORIAL";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoriaBindingSource, "NOMBRE_CATEGORIA", true));
            this.comboBox2.DataSource = this.categoriaBindingSource;
            this.comboBox2.DisplayMember = "NOMBRE_CATEGORIA";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(310, 167);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 47;
            this.comboBox2.ValueMember = "NOMBRE_CATEGORIA";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 170);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Categoria:";
            // 
            // bIBLIOTECADataSet4
            // 
            this.bIBLIOTECADataSet4.DataSetName = "BIBLIOTECADataSet4";
            this.bIBLIOTECADataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editorialBindingSource
            // 
            this.editorialBindingSource.DataMember = "Editorial";
            this.editorialBindingSource.DataSource = this.bIBLIOTECADataSet4;
            // 
            // editorialTableAdapter
            // 
            this.editorialTableAdapter.ClearBeforeFill = true;
            // 
            // bIBLIOTECADataSet5
            // 
            this.bIBLIOTECADataSet5.DataSetName = "BIBLIOTECADataSet5";
            this.bIBLIOTECADataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.bIBLIOTECADataSet5;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 448);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Eliminar_Libros);
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
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FrmLibro";
            this.Text = "LIBRO ";
            this.Load += new System.EventHandler(this.FrmLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admi_libro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
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
        private BIBLIOTECADataSet3 bIBLIOTECADataSet3;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private BIBLIOTECADataSet3TableAdapters.LibrosTableAdapter librosTableAdapter;
        private System.Windows.Forms.Button btn_Eliminar_Libros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private BIBLIOTECADataSet4 bIBLIOTECADataSet4;
        private System.Windows.Forms.BindingSource editorialBindingSource;
        private BIBLIOTECADataSet4TableAdapters.EditorialTableAdapter editorialTableAdapter;
        private BIBLIOTECADataSet5 bIBLIOTECADataSet5;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private BIBLIOTECADataSet5TableAdapters.CategoriaTableAdapter categoriaTableAdapter;
    }
}