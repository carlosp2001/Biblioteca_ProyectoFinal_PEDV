using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Biblioteca
{
    //Formulario para seleccionar el prestamo el cual generará una factura
    /// <summary>
    /// Formulario para seleccionar el prestamo el cual generará una factura
    /// </summary>
    public partial class DGV_Prestamos : Form
    {
        
        public DGV_Prestamos()
        {
            
            InitializeComponent();
        }
        

        clsConexion clsConexion1 = new clsConexion();
        //Metodo al cargar del formulario
        /// <summary>
        /// Metodo al cargar del formulario
        /// 
        /// </summary>
        /// <param name="clsConexion"></Crea una instancia a la clase conexion>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_Prestamos_Load(object sender, EventArgs e)
        {
            clsConexion1.cargarDatosPrestDevuelto(dataGridView1);
        }

        static string id_prestamo;

       

        //Boton que realiza la accion de abrir el formulario para generar la factura
        /// <summary>
        /// Boton que realiza la accion de abrir el formulario para generar la factura
        /// </summary>
        /// <param name="@"></Identificador que crea una relacion entre el comando sql y una variable de c#>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Generar_Factura_Click(object sender, EventArgs e)
        {
            id_prestamo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FrmFactura frmFactura = new FrmFactura(id_prestamo);
            this.Hide();
            frmFactura.ShowDialog();
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
