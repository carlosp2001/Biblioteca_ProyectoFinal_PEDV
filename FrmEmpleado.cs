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

        FrmLector frmLector1 = new FrmLector("Empleado");

        private void btn_Emple_AgreLect_Click(object sender, EventArgs e)
        {
            frmLector1.ShowDialog();
        }

        FrmRealizarP frmRealizarP = new FrmRealizarP("Realizar");

        private void btn_Emple_Presta_Click(object sender, EventArgs e)
        {
            frmRealizarP.ShowDialog();

        }

        FrmRealizarP frmRealizar = new FrmRealizarP("Entrega");
        private void btn_Emple_EntreLib_Click(object sender, EventArgs e)
        {
            frmRealizar.ShowDialog();

        }
        DGV_Prestamos dGV_Prestamos = new DGV_Prestamos();

        private void btn_Emple_Fact_Click(object sender, EventArgs e)
        {
            dGV_Prestamos.ShowDialog();

        }
    }
}
