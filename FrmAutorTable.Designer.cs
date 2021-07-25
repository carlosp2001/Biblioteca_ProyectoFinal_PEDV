
namespace Proyecto_Biblioteca
{
    partial class FrmAutorTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutorTable));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Modi_autor = new System.Windows.Forms.Button();
            this.btn_Agre_autor = new System.Windows.Forms.Button();
            this.dgv_admi_cat = new System.Windows.Forms.DataGridView();
            this.iDAUTORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRESAUTORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDOSAUTORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nACIONALIDADAUTORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bIBLIOTECADataSet = new Proyecto_Biblioteca.BIBLIOTECADataSet();
            this.txt_Nacionalidad_autor = new System.Windows.Forms.TextBox();
            this.txt_Apellido_autor = new System.Windows.Forms.TextBox();
            this.txt_Nombre_autor = new System.Windows.Forms.TextBox();
            this.txt_Id_autor = new System.Windows.Forms.TextBox();
            this.Telefono_UsuarioSist = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.autoresTableAdapter = new Proyecto_Biblioteca.BIBLIOTECADataSetTableAdapters.AutoresTableAdapter();
            this.btn_Eli_Autor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admi_cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(682, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "AUTOR ";
            // 
            // btn_Modi_autor
            // 
            this.btn_Modi_autor.BackColor = System.Drawing.Color.Silver;
            this.btn_Modi_autor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Modi_autor.Location = new System.Drawing.Point(1257, 503);
            this.btn_Modi_autor.Name = "btn_Modi_autor";
            this.btn_Modi_autor.Size = new System.Drawing.Size(196, 102);
            this.btn_Modi_autor.TabIndex = 30;
            this.btn_Modi_autor.Text = "Modificar";
            this.btn_Modi_autor.UseVisualStyleBackColor = false;
            this.btn_Modi_autor.Click += new System.EventHandler(this.btn_Modi_autor_Click);
            // 
            // btn_Agre_autor
            // 
            this.btn_Agre_autor.BackColor = System.Drawing.Color.Silver;
            this.btn_Agre_autor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Agre_autor.Location = new System.Drawing.Point(1257, 338);
            this.btn_Agre_autor.Name = "btn_Agre_autor";
            this.btn_Agre_autor.Size = new System.Drawing.Size(196, 94);
            this.btn_Agre_autor.TabIndex = 29;
            this.btn_Agre_autor.Text = "Agregar";
            this.btn_Agre_autor.UseVisualStyleBackColor = false;
            this.btn_Agre_autor.Click += new System.EventHandler(this.btn_Agre_autor_Click);
            // 
            // dgv_admi_cat
            // 
            this.dgv_admi_cat.AllowUserToAddRows = false;
            this.dgv_admi_cat.AllowUserToOrderColumns = true;
            this.dgv_admi_cat.AutoGenerateColumns = false;
            this.dgv_admi_cat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_admi_cat.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgv_admi_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admi_cat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAUTORDataGridViewTextBoxColumn,
            this.nOMBRESAUTORDataGridViewTextBoxColumn,
            this.aPELLIDOSAUTORDataGridViewTextBoxColumn,
            this.nACIONALIDADAUTORDataGridViewTextBoxColumn});
            this.dgv_admi_cat.DataSource = this.autoresBindingSource;
            this.dgv_admi_cat.Location = new System.Drawing.Point(143, 912);
            this.dgv_admi_cat.Name = "dgv_admi_cat";
            this.dgv_admi_cat.RowHeadersWidth = 40;
            this.dgv_admi_cat.RowTemplate.Height = 46;
            this.dgv_admi_cat.Size = new System.Drawing.Size(1419, 225);
            this.dgv_admi_cat.TabIndex = 28;
            this.dgv_admi_cat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_admi_cat_CellClick);
            this.dgv_admi_cat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_admi_cat_CellContentClick);
            // 
            // iDAUTORDataGridViewTextBoxColumn
            // 
            this.iDAUTORDataGridViewTextBoxColumn.DataPropertyName = "ID_AUTOR";
            this.iDAUTORDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDAUTORDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.iDAUTORDataGridViewTextBoxColumn.Name = "iDAUTORDataGridViewTextBoxColumn";
            // 
            // nOMBRESAUTORDataGridViewTextBoxColumn
            // 
            this.nOMBRESAUTORDataGridViewTextBoxColumn.DataPropertyName = "NOMBRES_AUTOR";
            this.nOMBRESAUTORDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nOMBRESAUTORDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nOMBRESAUTORDataGridViewTextBoxColumn.Name = "nOMBRESAUTORDataGridViewTextBoxColumn";
            // 
            // aPELLIDOSAUTORDataGridViewTextBoxColumn
            // 
            this.aPELLIDOSAUTORDataGridViewTextBoxColumn.DataPropertyName = "APELLIDOS_AUTOR";
            this.aPELLIDOSAUTORDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.aPELLIDOSAUTORDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.aPELLIDOSAUTORDataGridViewTextBoxColumn.Name = "aPELLIDOSAUTORDataGridViewTextBoxColumn";
            // 
            // nACIONALIDADAUTORDataGridViewTextBoxColumn
            // 
            this.nACIONALIDADAUTORDataGridViewTextBoxColumn.DataPropertyName = "NACIONALIDAD_AUTOR";
            this.nACIONALIDADAUTORDataGridViewTextBoxColumn.HeaderText = "Nacionalidad";
            this.nACIONALIDADAUTORDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nACIONALIDADAUTORDataGridViewTextBoxColumn.Name = "nACIONALIDADAUTORDataGridViewTextBoxColumn";
            // 
            // autoresBindingSource
            // 
            this.autoresBindingSource.DataMember = "Autores";
            this.autoresBindingSource.DataSource = this.bIBLIOTECADataSet;
            this.autoresBindingSource.CurrentChanged += new System.EventHandler(this.autoresBindingSource_CurrentChanged);
            // 
            // bIBLIOTECADataSet
            // 
            this.bIBLIOTECADataSet.DataSetName = "BIBLIOTECADataSet";
            this.bIBLIOTECADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_Nacionalidad_autor
            // 
            this.txt_Nacionalidad_autor.Location = new System.Drawing.Point(432, 714);
            this.txt_Nacionalidad_autor.Name = "txt_Nacionalidad_autor";
            this.txt_Nacionalidad_autor.Size = new System.Drawing.Size(185, 44);
            this.txt_Nacionalidad_autor.TabIndex = 23;
            // 
            // txt_Apellido_autor
            // 
            this.txt_Apellido_autor.Location = new System.Drawing.Point(432, 580);
            this.txt_Apellido_autor.Name = "txt_Apellido_autor";
            this.txt_Apellido_autor.Size = new System.Drawing.Size(185, 44);
            this.txt_Apellido_autor.TabIndex = 22;
            // 
            // txt_Nombre_autor
            // 
            this.txt_Nombre_autor.Location = new System.Drawing.Point(432, 440);
            this.txt_Nombre_autor.Name = "txt_Nombre_autor";
            this.txt_Nombre_autor.Size = new System.Drawing.Size(185, 44);
            this.txt_Nombre_autor.TabIndex = 21;
            // 
            // txt_Id_autor
            // 
            this.txt_Id_autor.Location = new System.Drawing.Point(432, 304);
            this.txt_Id_autor.Name = "txt_Id_autor";
            this.txt_Id_autor.Size = new System.Drawing.Size(185, 44);
            this.txt_Id_autor.TabIndex = 20;
            // 
            // Telefono_UsuarioSist
            // 
            this.Telefono_UsuarioSist.AutoSize = true;
            this.Telefono_UsuarioSist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono_UsuarioSist.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Telefono_UsuarioSist.Location = new System.Drawing.Point(175, 721);
            this.Telefono_UsuarioSist.Name = "Telefono_UsuarioSist";
            this.Telefono_UsuarioSist.Size = new System.Drawing.Size(226, 37);
            this.Telefono_UsuarioSist.TabIndex = 19;
            this.Telefono_UsuarioSist.Text = "Nacionalidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(181, 588);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 37);
            this.label4.TabIndex = 18;
            this.label4.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(175, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 37);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(175, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "Id:";
            // 
            // autoresTableAdapter
            // 
            this.autoresTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Eli_Autor
            // 
            this.btn_Eli_Autor.BackColor = System.Drawing.Color.Silver;
            this.btn_Eli_Autor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Eli_Autor.Location = new System.Drawing.Point(1257, 674);
            this.btn_Eli_Autor.Name = "btn_Eli_Autor";
            this.btn_Eli_Autor.Size = new System.Drawing.Size(196, 94);
            this.btn_Eli_Autor.TabIndex = 31;
            this.btn_Eli_Autor.Text = "Eliminar";
            this.btn_Eli_Autor.UseVisualStyleBackColor = false;
            this.btn_Eli_Autor.Click += new System.EventHandler(this.btn_Eli_Autor_Click);
            // 
            // FrmAutorTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1732, 1221);
            this.Controls.Add(this.btn_Eli_Autor);
            this.Controls.Add(this.btn_Modi_autor);
            this.Controls.Add(this.btn_Agre_autor);
            this.Controls.Add(this.dgv_admi_cat);
            this.Controls.Add(this.txt_Nacionalidad_autor);
            this.Controls.Add(this.txt_Apellido_autor);
            this.Controls.Add(this.txt_Nombre_autor);
            this.Controls.Add(this.txt_Id_autor);
            this.Controls.Add(this.Telefono_UsuarioSist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAutorTable";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTOR";
            this.Load += new System.EventHandler(this.FrmAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admi_cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Modi_autor;
        private System.Windows.Forms.Button btn_Agre_autor;
        private System.Windows.Forms.DataGridView dgv_admi_cat;
        private System.Windows.Forms.TextBox txt_Nacionalidad_autor;
        private System.Windows.Forms.TextBox txt_Apellido_autor;
        private System.Windows.Forms.TextBox txt_Nombre_autor;
        private System.Windows.Forms.TextBox txt_Id_autor;
        private System.Windows.Forms.Label Telefono_UsuarioSist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private BIBLIOTECADataSet bIBLIOTECADataSet;
        private System.Windows.Forms.BindingSource autoresBindingSource;
        private BIBLIOTECADataSetTableAdapters.AutoresTableAdapter autoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAUTORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRESAUTORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDOSAUTORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nACIONALIDADAUTORDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Eli_Autor;
    }
}