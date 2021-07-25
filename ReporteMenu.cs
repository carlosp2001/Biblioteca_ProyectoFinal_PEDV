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
    public partial class ReporteMenu : Form
    {
        public ReporteMenu()
        {
            InitializeComponent();
        }

        ReportePrestamos reportePrestamos = new ReportePrestamos();
        private void button1_Click(object sender, EventArgs e)
        {
            reportePrestamos.ShowDialog();
        }

        FrmReporteLibros frmReportelibros = new FrmReporteLibros();

        private void button2_Click(object sender, EventArgs e)
        {
            frmReportelibros.ShowDialog();
        }
    }
}
