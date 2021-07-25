
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoria));
            this.btn_Modi_Cat = new System.Windows.Forms.Button();
            this.btn_Agregar_Cat = new System.Windows.Forms.Button();
            this.dgv_Admi_Cat = new System.Windows.Forms.DataGridView();
            this.iDCATEGORIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRECATEGORIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bIBLIOTECADataSet1 = new Proyecto_Biblioteca.BIBLIOTECADataSet1();
            this.txt_Nombre_Cat = new System.Windows.Forms.TextBox();
            this.txt_Id_Cat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Eliminar_cat = new System.Windows.Forms.Button();
            this.categoriaTableAdapter = new Proyecto_Biblioteca.BIBLIOTECADataSet1TableAdapters.CategoriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Admi_Cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Modi_Cat
            // 
            this.btn_Modi_Cat.BackColor = System.Drawing.Color.Silver;
            this.btn_Modi_Cat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Modi_Cat.Location = new System.Drawing.Point(1161, 620);
            this.btn_Modi_Cat.Name = "btn_Modi_Cat";
            this.btn_Modi_Cat.Size = new System.Drawing.Size(196, 102);
            this.btn_Modi_Cat.TabIndex = 42;
            this.btn_Modi_Cat.Text = "Modificar";
            this.btn_Modi_Cat.UseVisualStyleBackColor = false;
            this.btn_Modi_Cat.Click += new System.EventHandler(this.btn_Modi_Cat_Click);
            // 
            // btn_Agregar_Cat
            // 
            this.btn_Agregar_Cat.BackColor = System.Drawing.Color.Silver;
            this.btn_Agregar_Cat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Agregar_Cat.Location = new System.Drawing.Point(1161, 318);
            this.btn_Agregar_Cat.Name = "btn_Agregar_Cat";
            this.btn_Agregar_Cat.Size = new System.Drawing.Size(196, 94);
            this.btn_Agregar_Cat.TabIndex = 41;
            this.btn_Agregar_Cat.Text = "Agregar";
            this.btn_Agregar_Cat.UseVisualStyleBackColor = false;
            this.btn_Agregar_Cat.Click += new System.EventHandler(this.btn_Agregar_Cat_Click);
            // 
            // dgv_Admi_Cat
            // 
            this.dgv_Admi_Cat.AllowUserToAddRows = false;
            this.dgv_Admi_Cat.AutoGenerateColumns = false;
            this.dgv_Admi_Cat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Admi_Cat.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgv_Admi_Cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Admi_Cat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCATEGORIADataGridViewTextBoxColumn,
            this.nOMBRECATEGORIADataGridViewTextBoxColumn});
            this.dgv_Admi_Cat.DataSource = this.categoriaBindingSource;
            this.dgv_Admi_Cat.Location = new System.Drawing.Point(125, 824);
            this.dgv_Admi_Cat.Name = "dgv_Admi_Cat";
            this.dgv_Admi_Cat.RowHeadersWidth = 123;
            this.dgv_Admi_Cat.RowTemplate.Height = 46;
            this.dgv_Admi_Cat.Size = new System.Drawing.Size(1245, 225);
            this.dgv_Admi_Cat.TabIndex = 40;
            this.dgv_Admi_Cat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Admi_Cat_CellClick);
            // 
            // iDCATEGORIADataGridViewTextBoxColumn
            // 
            this.iDCATEGORIADataGridViewTextBoxColumn.DataPropertyName = "ID_CATEGORIA";
            this.iDCATEGORIADataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDCATEGORIADataGridViewTextBoxColumn.MinimumWidth = 15;
            this.iDCATEGORIADataGridViewTextBoxColumn.Name = "iDCATEGORIADataGridViewTextBoxColumn";
            this.iDCATEGORIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBRECATEGORIADataGridViewTextBoxColumn
            // 
            this.nOMBRECATEGORIADataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_CATEGORIA";
            this.nOMBRECATEGORIADataGridViewTextBoxColumn.HeaderText = "Nombre de Categoria";
            this.nOMBRECATEGORIADataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nOMBRECATEGORIADataGridViewTextBoxColumn.Name = "nOMBRECATEGORIADataGridViewTextBoxColumn";
            this.nOMBRECATEGORIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.bIBLIOTECADataSet1;
            // 
            // bIBLIOTECADataSet1
            // 
            this.bIBLIOTECADataSet1.DataSetName = "BIBLIOTECADataSet1";
            this.bIBLIOTECADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_Nombre_Cat
            // 
            this.txt_Nombre_Cat.Location = new System.Drawing.Point(386, 529);
            this.txt_Nombre_Cat.Name = "txt_Nombre_Cat";
            this.txt_Nombre_Cat.Size = new System.Drawing.Size(185, 44);
            this.txt_Nombre_Cat.TabIndex = 37;
            // 
            // txt_Id_Cat
            // 
            this.txt_Id_Cat.Enabled = false;
            this.txt_Id_Cat.Location = new System.Drawing.Point(386, 393);
            this.txt_Id_Cat.Name = "txt_Id_Cat";
            this.txt_Id_Cat.Size = new System.Drawing.Size(185, 44);
            this.txt_Id_Cat.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(155, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 37);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(155, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 37);
            this.label2.TabIndex = 32;
            this.label2.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(514, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 98);
            this.label1.TabIndex = 31;
            this.label1.Text = "Categoria";
            // 
            // btn_Eliminar_cat
            // 
            this.btn_Eliminar_cat.BackColor = System.Drawing.Color.Silver;
            this.btn_Eliminar_cat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Eliminar_cat.Location = new System.Drawing.Point(1161, 458);
            this.btn_Eliminar_cat.Name = "btn_Eliminar_cat";
            this.btn_Eliminar_cat.Size = new System.Drawing.Size(196, 94);
            this.btn_Eliminar_cat.TabIndex = 43;
            this.btn_Eliminar_cat.Text = "Eliminar";
            this.btn_Eliminar_cat.UseVisualStyleBackColor = false;
            this.btn_Eliminar_cat.Click += new System.EventHandler(this.btn_Eliminar_cat_Click);
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1574, 1187);
            this.Controls.Add(this.btn_Eliminar_cat);
            this.Controls.Add(this.btn_Modi_Cat);
            this.Controls.Add(this.btn_Agregar_Cat);
            this.Controls.Add(this.dgv_Admi_Cat);
            this.Controls.Add(this.txt_Nombre_Cat);
            this.Controls.Add(this.txt_Id_Cat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCategoria";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCategoria";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Admi_Cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet1)).EndInit();
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