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
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }


        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm_Login_Empleado frm_Login_Empleado = new Frm_Login_Empleado();
            frm_Login_Empleado.Show();
        }
    }
}
