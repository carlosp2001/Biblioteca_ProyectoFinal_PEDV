using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca
{
    public partial class ReportePrestamos : Form
    {
        public ReportePrestamos()
        {
            InitializeComponent();
        }

        private void ReportePrestamos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Prestamo' table. You can move, or remove it, as needed.
            this.PrestamoTableAdapter.Fill(this.DataSet1.Prestamo);
            // TODO: This line of code loads data into the 'DataSet1.Libros' table. You can move, or remove it, as needed.
            this.LibrosTableAdapter.Fill(this.DataSet1.Libros);

            this.reportViewer1.RefreshReport();
        }
    }
}
