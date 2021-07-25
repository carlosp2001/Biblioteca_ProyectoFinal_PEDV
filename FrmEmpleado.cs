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
        //Boton para abrir y crear la instancia del formulario y envia el tipo de usuario que esta abriendo 
        //el formulario
        /// <summary>
        /// Boton para abrir y crear la instancia del formulario y envia el tipo de usuario que esta abriendo 
        ///el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Emple_AgreLect_Click(object sender, EventArgs e)
        {
            frmLector1.ShowDialog();
        }

        FrmRealizarP frmRealizarP = new FrmRealizarP("Realizar");
        //Boton para abrir y crear la instancia del formulario y envia el tipo de usuario que esta abriendo 
        //el formulario
        /// <summary>
        /// Boton para abrir y crear la instancia del formulario y envia el tipo de usuario que esta abriendo 
        ///el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Emple_Presta_Click(object sender, EventArgs e)
        {
            frmRealizarP.ShowDialog();

        }

        FrmRealizarP frmRealizar = new FrmRealizarP("Entrega");
        //Boton para abrir y crear la instancia del formulario y envia el tipo de usuario que esta abriendo 
        //el formulario
        /// <summary>
        /// Boton para abrir y crear la instancia del formulario y envia el tipo de usuario que esta abriendo 
        ///el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Emple_EntreLib_Click(object sender, EventArgs e)
        {
            frmRealizar.ShowDialog();

        }
        DGV_Prestamos dGV_Prestamos = new DGV_Prestamos();
        //Boton para abrir el formulario en el cual se seleccionara el prestamo del cual queremos generar factura
        /// <summary>
        /// Boton para abrir el formulario en el cual se seleccionara el prestamo del cual queremos generar factura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Emple_Fact_Click(object sender, EventArgs e)
        {
            dGV_Prestamos.ShowDialog();

        }
    }
}
