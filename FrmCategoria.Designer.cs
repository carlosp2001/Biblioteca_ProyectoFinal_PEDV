
namespace Proyecto_Biblioteca
{
    partial class FrmCategoria
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
            this.btn_Modi_Cat = new System.Windows.Forms.Button();
            this.btn_Agregar_Cat = new System.Windows.Forms.Button();
            this.dgv_Admi_Cat = new System.Windows.Forms.DataGridView();
            this.txt_Nombre_Cat = new System.Windows.Forms.TextBox();
            this.txt_Id_Cat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Eliminar_cat = new System.Windows.Forms.Button();
            this.bIBLIOTECADataSet1 = new Proyecto_Biblioteca.BIBLIOTECADataSet1();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new Proyecto_Biblioteca.BIBLIOTECADataSet1TableAdapters.CategoriaTableAdapter();
            this.iDCATEGORIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRECATEGORIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Admi_Cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Modi_Cat
            // 
            this.btn_Modi_Cat.Location = new System.Drawing.Point(314, 215);
            this.btn_Modi_Cat.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Modi_Cat.Name = "btn_Modi_Cat";
            this.btn_Modi_Cat.Size = new System.Drawing.Size(62, 36);
            this.btn_Modi_Cat.TabIndex = 42;
            this.btn_Modi_Cat.Text = "Modificar";
            this.btn_Modi_Cat.UseVisualStyleBackColor = true;
            this.btn_Modi_Cat.Click += new System.EventHandler(this.btn_Modi_Cat_Click);
            // 
            // btn_Agregar_Cat
            // 
            this.btn_Agregar_Cat.Location = new System.Drawing.Point(314, 109);
            this.btn_Agregar_Cat.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Agregar_Cat.Name = "btn_Agregar_Cat";
            this.btn_Agregar_Cat.Size = new System.Drawing.Size(62, 33);
            this.btn_Agregar_Cat.TabIndex = 41;
            this.btn_Agregar_Cat.Text = "Agregar";
            this.btn_Agregar_Cat.UseVisualStyleBackColor = true;
            this.btn_Agregar_Cat.Click += new System.EventHandler(this.btn_Agregar_Cat_Click);
            // 
            // dgv_Admi_Cat
            // 
            this.dgv_Admi_Cat.AllowUserToAddRows = false;
            this.dgv_Admi_Cat.AutoGenerateColumns = false;
            this.dgv_Admi_Cat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Admi_Cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Admi_Cat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCATEGORIADataGridViewTextBoxColumn,
            this.nOMBRECATEGORIADataGridViewTextBoxColumn});
            this.dgv_Admi_Cat.DataSource = this.categoriaBindingSource;
            this.dgv_Admi_Cat.Location = new System.Drawing.Point(56, 287);
            this.dgv_Admi_Cat.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgv_Admi_Cat.Name = "dgv_Admi_Cat";
            this.dgv_Admi_Cat.RowHeadersWidth = 123;
            this.dgv_Admi_Cat.RowTemplate.Height = 46;
            this.dgv_Admi_Cat.Size = new System.Drawing.Size(393, 79);
            this.dgv_Admi_Cat.TabIndex = 40;
            this.dgv_Admi_Cat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Admi_Cat_CellClick);
            // 
            // txt_Nombre_Cat
            // 
            this.txt_Nombre_Cat.Location = new System.Drawing.Point(122, 186);
            this.txt_Nombre_Cat.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txt_Nombre_Cat.Name = "txt_Nombre_Cat";
            this.txt_Nombre_Cat.Size = new System.Drawing.Size(61, 20);
            this.txt_Nombre_Cat.TabIndex = 37;
            // 
            // txt_Id_Cat
            // 
            this.txt_Id_Cat.Enabled = false;
            this.txt_Id_Cat.Location = new System.Drawing.Point(122, 138);
            this.txt_Id_Cat.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txt_Id_Cat.Name = "txt_Id_Cat";
            this.txt_Id_Cat.Size = new System.Drawing.Size(61, 20);
            this.txt_Id_Cat.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 137);
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
            this.label1.Location = new System.Drawing.Point(150, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Categoria";
            // 
            // btn_Eliminar_cat
            // 
            this.btn_Eliminar_cat.Location = new System.Drawing.Point(314, 158);
            this.btn_Eliminar_cat.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Eliminar_cat.Name = "btn_Eliminar_cat";
            this.btn_Eliminar_cat.Size = new System.Drawing.Size(62, 33);
            this.btn_Eliminar_cat.TabIndex = 43;
            this.btn_Eliminar_cat.Text = "Eliminar";
            this.btn_Eliminar_cat.UseVisualStyleBackColor = true;
            this.btn_Eliminar_cat.Click += new System.EventHandler(this.btn_Eliminar_cat_Click);
            // 
            // bIBLIOTECADataSet1
            // 
            this.bIBLIOTECADataSet1.DataSetName = "BIBLIOTECADataSet1";
            this.bIBLIOTECADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.bIBLIOTECADataSet1;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // iDCATEGORIADataGridViewTextBoxColumn
            // 
            this.iDCATEGORIADataGridViewTextBoxColumn.DataPropertyName = "ID_CATEGORIA";
            this.iDCATEGORIADataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDCATEGORIADataGridViewTextBoxColumn.Name = "iDCATEGORIADataGridViewTextBoxColumn";
            this.iDCATEGORIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBRECATEGORIADataGridViewTextBoxColumn
            // 
            this.nOMBRECATEGORIADataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_CATEGORIA";
            this.nOMBRECATEGORIADataGridViewTextBoxColumn.HeaderText = "Nombre de Categoria";
            this.nOMBRECATEGORIADataGridViewTextBoxColumn.Name = "nOMBRECATEGORIADataGridViewTextBoxColumn";
            this.nOMBRECATEGORIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 417);
            this.Controls.Add(this.btn_Eliminar_cat);
            this.Controls.Add(this.btn_Modi_Cat);
            this.Controls.Add(this.btn_Agregar_Cat);
            this.Controls.Add(this.dgv_Admi_Cat);
            this.Controls.Add(this.txt_Nombre_Cat);
            this.Controls.Add(this.txt_Id_Cat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FrmCategoria";
            this.Text = "FrmCategoria";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Admi_Cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Modi_Cat;
        private System.Windows.Forms.Button btn_Agregar_Cat;
        private System.Windows.Forms.DataGridView dgv_Admi_Cat;
        private System.Windows.Forms.TextBox txt_Nombre_Cat;
        private System.Windows.Forms.TextBox txt_Id_Cat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Eliminar_cat;
        private BIBLIOTECADataSet1 bIBLIOTECADataSet1;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private BIBLIOTECADataSet1TableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCATEGORIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRECATEGORIADataGridViewTextBoxColumn;
    }
}