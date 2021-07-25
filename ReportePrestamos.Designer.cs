
namespace Proyecto_Biblioteca
{
    partial class ReportePrestamos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new Proyecto_Biblioteca.DataSet1();
            this.PrestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrestamoTableAdapter = new Proyecto_Biblioteca.DataSet1TableAdapters.PrestamoTableAdapter();
            this.LibrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LibrosTableAdapter = new Proyecto_Biblioteca.DataSet1TableAdapters.LibrosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PrestamoBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.LibrosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Biblioteca.ReportedePrestamos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(799, 451);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PrestamoBindingSource
            // 
            this.PrestamoBindingSource.DataMember = "Prestamo";
            this.PrestamoBindingSource.DataSource = this.DataSet1;
            // 
            // PrestamoTableAdapter
            // 
            this.PrestamoTableAdapter.ClearBeforeFill = true;
            // 
            // LibrosBindingSource
            // 
            this.LibrosBindingSource.DataMember = "Libros";
            this.LibrosBindingSource.DataSource = this.DataSet1;
            // 
            // LibrosTableAdapter
            // 
            this.LibrosTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportePrestamos";
            this.Text = "ReportePrestamos";
            this.Load += new System.EventHandler(this.ReportePrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibrosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PrestamoBindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource LibrosBindingSource;
        private DataSet1TableAdapters.PrestamoTableAdapter PrestamoTableAdapter;
        private DataSet1TableAdapters.LibrosTableAdapter LibrosTableAdapter;
    }
}