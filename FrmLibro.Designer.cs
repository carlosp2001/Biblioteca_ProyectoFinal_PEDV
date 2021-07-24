
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
            this.editorialBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bIBLIOTECADataSet7 = new Proyecto_Biblioteca.BIBLIOTECADataSet7();
            this.editorialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bIBLIOTECADataSet4 = new Proyecto_Biblioteca.BIBLIOTECADataSet4();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bIBLIOTECADataSet8 = new Proyecto_Biblioteca.BIBLIOTECADataSet8();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bIBLIOTECADataSet5 = new Proyecto_Biblioteca.BIBLIOTECADataSet5();
            this.label6 = new System.Windows.Forms.Label();
            this.editorialTableAdapter = new Proyecto_Biblioteca.BIBLIOTECADataSet4TableAdapters.EditorialTableAdapter();
            this.categoriaTableAdapter = new Proyecto_Biblioteca.BIBLIOTECADataSet5TableAdapters.CategoriaTableAdapter();
            this.autoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bIBLIOTECADataSet9 = new Proyecto_Biblioteca.BIBLIOTECADataSet9();
            this.label7 = new System.Windows.Forms.Label();
            this.bIBLIOTECADataSet6 = new Proyecto_Biblioteca.BIBLIOTECADataSet6();
            this.autoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoresTableAdapter = new Proyecto_Biblioteca.BIBLIOTECADataSet6TableAdapters.AutoresTableAdapter();
            this.editorialTableAdapter1 = new Proyecto_Biblioteca.BIBLIOTECADataSet7TableAdapters.EditorialTableAdapter();
            this.categoriaTableAdapter1 = new Proyecto_Biblioteca.BIBLIOTECADataSet8TableAdapters.CategoriaTableAdapter();
            this.autoresTableAdapter1 = new Proyecto_Biblioteca.BIBLIOTECADataSet9TableAdapters.AutoresTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dgv_admi_libro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admi_libro)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Modi_libro
            // 
            this.btn_Modi_libro.Location = new System.Drawing.Point(533, 236);
            this.btn_Modi_libro.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Modi_libro.Name = "btn_Modi_libro";
            this.btn_Modi_libro.Size = new System.Drawing.Size(62, 36);
            this.btn_Modi_libro.TabIndex = 42;
            this.btn_Modi_libro.Text = "Modificar";
            this.btn_Modi_libro.UseVisualStyleBackColor = true;
            this.btn_Modi_libro.Click += new System.EventHandler(this.btn_Modi_libro_Click);
            // 
            // btn_Agre_libro
            // 
            this.btn_Agre_libro.Location = new System.Drawing.Point(533, 117);
            this.btn_Agre_libro.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Agre_libro.Name = "btn_Agre_libro";
            this.btn_Agre_libro.Size = new System.Drawing.Size(62, 33);
            this.btn_Agre_libro.TabIndex = 41;
            this.btn_Agre_libro.Text = "Agregar";
            this.btn_Agre_libro.UseVisualStyleBackColor = true;
            this.btn_Agre_libro.Click += new System.EventHandler(this.btn_Agre_libro_Click);
            // 
            // txt_npaginas_libro
            // 
            this.txt_npaginas_libro.Location = new System.Drawing.Point(123, 263);
            this.txt_npaginas_libro.Margin = new System.Windows.Forms.Padding(1);
            this.txt_npaginas_libro.Name = "txt_npaginas_libro";
            this.txt_npaginas_libro.Size = new System.Drawing.Size(61, 20);
            this.txt_npaginas_libro.TabIndex = 39;
            // 
            // txt_edicion_libro
            // 
            this.txt_edicion_libro.Location = new System.Drawing.Point(123, 216);
            this.txt_edicion_libro.Margin = new System.Windows.Forms.Padding(1);
            this.txt_edicion_libro.Name = "txt_edicion_libro";
            this.txt_edicion_libro.Size = new System.Drawing.Size(61, 20);
            this.txt_edicion_libro.TabIndex = 38;
            // 
            // txt_titulo_libro
            // 
            this.txt_titulo_libro.Location = new System.Drawing.Point(123, 167);
            this.txt_titulo_libro.Margin = new System.Windows.Forms.Padding(1);
            this.txt_titulo_libro.Name = "txt_titulo_libro";
            this.txt_titulo_libro.Size = new System.Drawing.Size(61, 20);
            this.txt_titulo_libro.TabIndex = 37;
            // 
            // txt_Id_libro
            // 
            this.txt_Id_libro.Location = new System.Drawing.Point(123, 119);
            this.txt_Id_libro.Margin = new System.Windows.Forms.Padding(1);
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
            this.btn_Eliminar_Libros.Click += new System.EventHandler(this.btn_Eliminar_Libros_Click);
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
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(310, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 45;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // editorialBindingSource1
            // 
            this.editorialBindingSource1.AllowNew = true;
            this.editorialBindingSource1.DataMember = "Editorial";
            this.editorialBindingSource1.DataSource = this.bIBLIOTECADataSet7;
            // 
            // bIBLIOTECADataSet7
            // 
            this.bIBLIOTECADataSet7.DataSetName = "BIBLIOTECADataSet7";
            this.bIBLIOTECADataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editorialBindingSource
            // 
            this.editorialBindingSource.DataMember = "Editorial";
            this.editorialBindingSource.DataSource = this.bIBLIOTECADataSet4;
            // 
            // bIBLIOTECADataSet4
            // 
            this.bIBLIOTECADataSet4.DataSetName = "BIBLIOTECADataSet4";
            this.bIBLIOTECADataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoriaBindingSource1, "ID_CATEGORIA", true));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(310, 167);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 47;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // categoriaBindingSource1
            // 
            this.categoriaBindingSource1.DataMember = "Categoria";
            this.categoriaBindingSource1.DataSource = this.bIBLIOTECADataSet8;
            // 
            // bIBLIOTECADataSet8
            // 
            this.bIBLIOTECADataSet8.DataSetName = "BIBLIOTECADataSet8";
            this.bIBLIOTECADataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.bIBLIOTECADataSet5;
            // 
            // bIBLIOTECADataSet5
            // 
            this.bIBLIOTECADataSet5.DataSetName = "BIBLIOTECADataSet5";
            this.bIBLIOTECADataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // editorialTableAdapter
            // 
            this.editorialTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // autoresBindingSource1
            // 
            this.autoresBindingSource1.DataMember = "Autores";
            this.autoresBindingSource1.DataSource = this.bIBLIOTECADataSet9;
            // 
            // bIBLIOTECADataSet9
            // 
            this.bIBLIOTECADataSet9.DataSetName = "BIBLIOTECADataSet9";
            this.bIBLIOTECADataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 216);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Autor:";
            // 
            // bIBLIOTECADataSet6
            // 
            this.bIBLIOTECADataSet6.DataSetName = "BIBLIOTECADataSet6";
            this.bIBLIOTECADataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autoresBindingSource
            // 
            this.autoresBindingSource.DataMember = "Autores";
            this.autoresBindingSource.DataSource = this.bIBLIOTECADataSet6;
            // 
            // autoresTableAdapter
            // 
            this.autoresTableAdapter.ClearBeforeFill = true;
            // 
            // editorialTableAdapter1
            // 
            this.editorialTableAdapter1.ClearBeforeFill = true;
            // 
            // categoriaTableAdapter1
            // 
            this.categoriaTableAdapter1.ClearBeforeFill = true;
            // 
            // autoresTableAdapter1
            // 
            this.autoresTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.autoresBindingSource1, "ID_AUTOR", true));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(310, 214);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 49;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged_2);
            // 
            // dgv_admi_libro
            // 
            this.dgv_admi_libro.AllowUserToAddRows = false;
            this.dgv_admi_libro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_admi_libro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admi_libro.Location = new System.Drawing.Point(54, 298);
            this.dgv_admi_libro.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_admi_libro.Name = "dgv_admi_libro";
            this.dgv_admi_libro.RowHeadersWidth = 40;
            this.dgv_admi_libro.RowTemplate.Height = 46;
            this.dgv_admi_libro.Size = new System.Drawing.Size(577, 140);
            this.dgv_admi_libro.TabIndex = 40;
            this.dgv_admi_libro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_admi_libro_CellClick);
            // 
            // FrmLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 448);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label7);
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
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FrmLibro";
            this.Text = "LIBRO ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLibro_FormClosed);
            this.Load += new System.EventHandler(this.FrmLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admi_libro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Modi_libro;
        private System.Windows.Forms.Button btn_Agre_libro;
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
        private System.Windows.Forms.Label label7;
        private BIBLIOTECADataSet6 bIBLIOTECADataSet6;
        private System.Windows.Forms.BindingSource autoresBindingSource;
        private BIBLIOTECADataSet6TableAdapters.AutoresTableAdapter autoresTableAdapter;
        private BIBLIOTECADataSet7 bIBLIOTECADataSet7;
        private System.Windows.Forms.BindingSource editorialBindingSource1;
        private BIBLIOTECADataSet7TableAdapters.EditorialTableAdapter editorialTableAdapter1;
        private BIBLIOTECADataSet8 bIBLIOTECADataSet8;
        private System.Windows.Forms.BindingSource categoriaBindingSource1;
        private BIBLIOTECADataSet8TableAdapters.CategoriaTableAdapter categoriaTableAdapter1;
        private BIBLIOTECADataSet9 bIBLIOTECADataSet9;
        private System.Windows.Forms.BindingSource autoresBindingSource1;
        private BIBLIOTECADataSet9TableAdapters.AutoresTableAdapter autoresTableAdapter1;
        private BIBLIOTECADataSet10 bIBLIOTECADataSet10;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dgv_admi_libro;
    }
}