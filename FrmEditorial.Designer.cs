
namespace Proyecto_Biblioteca
{
    partial class FrmEditorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditorial));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Modi_editorial = new System.Windows.Forms.Button();
            this.btn_Agre_editorial = new System.Windows.Forms.Button();
            this.dgv_admi_editorial = new System.Windows.Forms.DataGridView();
            this.iDEDITORIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREEDITORIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAISLUGARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bIBLIOTECADataSet2 = new Proyecto_Biblioteca.BIBLIOTECADataSet2();
            this.txt_pais_editorial = new System.Windows.Forms.TextBox();
            this.txt_Nombre_editorial = new System.Windows.Forms.TextBox();
            this.txt_Id_editorial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editorialTableAdapter = new Proyecto_Biblioteca.BIBLIOTECADataSet2TableAdapters.EditorialTableAdapter();
            this.btn_Eliminar_Editorial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admi_editorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(156, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editorial";
            // 
            // btn_Modi_editorial
            // 
            this.btn_Modi_editorial.BackColor = System.Drawing.Color.Silver;
            this.btn_Modi_editorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Modi_editorial.Location = new System.Drawing.Point(349, 210);
            this.btn_Modi_editorial.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Modi_editorial.Name = "btn_Modi_editorial";
            this.btn_Modi_editorial.Size = new System.Drawing.Size(62, 36);
            this.btn_Modi_editorial.TabIndex = 41;
            this.btn_Modi_editorial.Text = "Modificar";
            this.btn_Modi_editorial.UseVisualStyleBackColor = false;
            this.btn_Modi_editorial.Click += new System.EventHandler(this.btn_Modi_editorial_Click);
            // 
            // btn_Agre_editorial
            // 
            this.btn_Agre_editorial.BackColor = System.Drawing.Color.Silver;
            this.btn_Agre_editorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Agre_editorial.Location = new System.Drawing.Point(349, 93);
            this.btn_Agre_editorial.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Agre_editorial.Name = "btn_Agre_editorial";
            this.btn_Agre_editorial.Size = new System.Drawing.Size(62, 33);
            this.btn_Agre_editorial.TabIndex = 40;
            this.btn_Agre_editorial.Text = "Agregar";
            this.btn_Agre_editorial.UseVisualStyleBackColor = false;
            this.btn_Agre_editorial.Click += new System.EventHandler(this.btn_Agre_editorial_Click);
            // 
            // dgv_admi_editorial
            // 
            this.dgv_admi_editorial.AllowUserToAddRows = false;
            this.dgv_admi_editorial.AllowUserToOrderColumns = true;
            this.dgv_admi_editorial.AutoGenerateColumns = false;
            this.dgv_admi_editorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_admi_editorial.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgv_admi_editorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admi_editorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEDITORIALDataGridViewTextBoxColumn,
            this.nOMBREEDITORIALDataGridViewTextBoxColumn,
            this.pAISLUGARDataGridViewTextBoxColumn});
            this.dgv_admi_editorial.DataSource = this.editorialBindingSource;
            this.dgv_admi_editorial.Location = new System.Drawing.Point(10, 288);
            this.dgv_admi_editorial.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgv_admi_editorial.Name = "dgv_admi_editorial";
            this.dgv_admi_editorial.RowHeadersWidth = 50;
            this.dgv_admi_editorial.RowTemplate.Height = 46;
            this.dgv_admi_editorial.Size = new System.Drawing.Size(464, 79);
            this.dgv_admi_editorial.TabIndex = 39;
            this.dgv_admi_editorial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_admi_editorial_CellClick);
            this.dgv_admi_editorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_admi_editorial_CellContentClick);
            // 
            // iDEDITORIALDataGridViewTextBoxColumn
            // 
            this.iDEDITORIALDataGridViewTextBoxColumn.DataPropertyName = "ID_EDITORIAL";
            this.iDEDITORIALDataGridViewTextBoxColumn.HeaderText = "ID_EDITORIAL";
            this.iDEDITORIALDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.iDEDITORIALDataGridViewTextBoxColumn.Name = "iDEDITORIALDataGridViewTextBoxColumn";
            // 
            // nOMBREEDITORIALDataGridViewTextBoxColumn
            // 
            this.nOMBREEDITORIALDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_EDITORIAL";
            this.nOMBREEDITORIALDataGridViewTextBoxColumn.HeaderText = "NOMBRE_EDITORIAL";
            this.nOMBREEDITORIALDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nOMBREEDITORIALDataGridViewTextBoxColumn.Name = "nOMBREEDITORIALDataGridViewTextBoxColumn";
            // 
            // pAISLUGARDataGridViewTextBoxColumn
            // 
            this.pAISLUGARDataGridViewTextBoxColumn.DataPropertyName = "PAIS_LUGAR";
            this.pAISLUGARDataGridViewTextBoxColumn.HeaderText = "PAIS_LUGAR";
            this.pAISLUGARDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.pAISLUGARDataGridViewTextBoxColumn.Name = "pAISLUGARDataGridViewTextBoxColumn";
            // 
            // editorialBindingSource
            // 
            this.editorialBindingSource.DataMember = "Editorial";
            this.editorialBindingSource.DataSource = this.bIBLIOTECADataSet2;
            // 
            // bIBLIOTECADataSet2
            // 
            this.bIBLIOTECADataSet2.DataSetName = "BIBLIOTECADataSet2";
            this.bIBLIOTECADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_pais_editorial
            // 
            this.txt_pais_editorial.Location = new System.Drawing.Point(113, 209);
            this.txt_pais_editorial.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txt_pais_editorial.Name = "txt_pais_editorial";
            this.txt_pais_editorial.Size = new System.Drawing.Size(61, 20);
            this.txt_pais_editorial.TabIndex = 37;
            // 
            // txt_Nombre_editorial
            // 
            this.txt_Nombre_editorial.Location = new System.Drawing.Point(113, 159);
            this.txt_Nombre_editorial.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txt_Nombre_editorial.Name = "txt_Nombre_editorial";
            this.txt_Nombre_editorial.Size = new System.Drawing.Size(61, 20);
            this.txt_Nombre_editorial.TabIndex = 36;
            // 
            // txt_Id_editorial
            // 
            this.txt_Id_editorial.Location = new System.Drawing.Point(113, 111);
            this.txt_Id_editorial.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txt_Id_editorial.Name = "txt_Id_editorial";
            this.txt_Id_editorial.Size = new System.Drawing.Size(61, 20);
            this.txt_Id_editorial.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(42, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Pais:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(40, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(40, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Id:";
            // 
            // editorialTableAdapter
            // 
            this.editorialTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Eliminar_Editorial
            // 
            this.btn_Eliminar_Editorial.BackColor = System.Drawing.Color.Silver;
            this.btn_Eliminar_Editorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Eliminar_Editorial.Location = new System.Drawing.Point(349, 149);
            this.btn_Eliminar_Editorial.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Eliminar_Editorial.Name = "btn_Eliminar_Editorial";
            this.btn_Eliminar_Editorial.Size = new System.Drawing.Size(62, 36);
            this.btn_Eliminar_Editorial.TabIndex = 42;
            this.btn_Eliminar_Editorial.Text = "Eliminar";
            this.btn_Eliminar_Editorial.UseVisualStyleBackColor = false;
            this.btn_Eliminar_Editorial.Click += new System.EventHandler(this.btn_Eliminar_Editorial_Click);
            // 
            // FrmEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(489, 393);
            this.Controls.Add(this.btn_Eliminar_Editorial);
            this.Controls.Add(this.btn_Modi_editorial);
            this.Controls.Add(this.btn_Agre_editorial);
            this.Controls.Add(this.dgv_admi_editorial);
            this.Controls.Add(this.txt_pais_editorial);
            this.Controls.Add(this.txt_Nombre_editorial);
            this.Controls.Add(this.txt_Id_editorial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FrmEditorial";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDITORIAL";
            this.Load += new System.EventHandler(this.FrmEditorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admi_editorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Modi_editorial;
        private System.Windows.Forms.Button btn_Agre_editorial;
        private System.Windows.Forms.DataGridView dgv_admi_editorial;
        private System.Windows.Forms.TextBox txt_pais_editorial;
        private System.Windows.Forms.TextBox txt_Nombre_editorial;
        private System.Windows.Forms.TextBox txt_Id_editorial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private BIBLIOTECADataSet2 bIBLIOTECADataSet2;
        private System.Windows.Forms.BindingSource editorialBindingSource;
        private BIBLIOTECADataSet2TableAdapters.EditorialTableAdapter editorialTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEDITORIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREEDITORIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAISLUGARDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Eliminar_Editorial;
    }
}