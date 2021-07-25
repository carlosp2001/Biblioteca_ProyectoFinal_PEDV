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
    public partial class FrmFactura : Form
    {
        //Metodo constructor recibe el id del prestamo a generar factura
        /// <summary>
        /// Metodo constructor recibe el id del prestamo a generar factura
        /// </summary>
        /// <param name="id_prestamo1"></Parametro que recibe el id del prestamo con el cual identificaremos que 
        /// datos generara la factura>
        public FrmFactura(string id_prestamo1)
        {
            
            InitializeComponent();
            DGV_Prestamos dGV_Prestamos = new DGV_Prestamos();
            id_prestamo = id_prestamo1;
        }
        string id_prestamo;

        //Polimorfismo:Metodo que nos devolvera un datatable con los datos que solicitamos de la base de datos
        /// <summary>
        /// Polimorfismo:Metodo que nos devolvera un datatable con los datos que solicitamos de la base de datos
        /// </summary>
        /// <param name="query"></Recibe la linea de comando de Sql que eejecutaremos>
        /// <param name="id"></Recibe el id con el cual se comparara el parametro de la base de datos>
        /// <returns></returns>
        private DataTable conseguirquerybd(string query, string id)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
            sqlConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(query +id, sqlConnection);
            
            DataTable dt = new DataTable();
            da.Fill(dt);

            sqlConnection.Close();
            return dt;

        }
        //Metodo que nos devolvera un datatable con los datos que solicitamos de la base de datos
        /// <summary>
        /// Metodo que nos devolvera un datatable con los datos que solicitamos de la base de datos
        /// </summary>
        /// <param name="id"></Recibe el id con el cual se comparara el parametro de la base de datos>
        /// <returns></returns>
        private DateTime conseguirqueryfechanac(string id)
        {
            SqlConnection sqlConnection1 = new SqlConnection();
            sqlConnection1.ConnectionString = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
            sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Select FECHA_NACIMIENTO from Usuario_Lector where DNI_USUARIO =@DNI_USUARIO1", sqlConnection1);
            cmd.Parameters.AddWithValue("@DNI_USUARIO1", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
        
            da.Fill(dt);

            sqlConnection1.Close();
            DateTime fechanaci = Convert.ToDateTime(dt.Rows[0][0].ToString());
            return fechanaci;

        }

        //Metodo para calcular la mora
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fechadev"></Recibe la fecha en la cual fue devuelta el libro>
        /// <param name="fecha_limit"></Recibe la fecha limite calculada en base al dia de entrega>
        /// <returns></returns>
        private double calcularmora(DateTime fechadev, DateTime fecha_limit)
        {
            double mora=20;
            while (fecha_limit < fechadev)
            {
                mora = (mora * 0.20) + mora;
                fecha_limit=fecha_limit.AddDays(1);
                Console.WriteLine(fecha_limit);
                Console.WriteLine(fechadev);
            }
            return mora;
        }

        //Metodo al cargar del formulario
        /// <summary>
        /// Metodo al cargar del formulario
        /// 
        /// </summary>
        /// <param name="clsConexion"></Crea una instancia a la clase conexion>
        /// <param name="fecha_actual"></Define la fecha actual del sistema>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFactura_Load(object sender, EventArgs e)
        {
            
            try
            {
                string queryprestamo = "Select * from Prestamo where ID_PRESTAMO=";
                DataTable dt = conseguirquerybd(queryprestamo, id_prestamo);
                string dni_usuario = dt.Rows[0][1].ToString();
                DateTime fecha_prestamo = Convert.ToDateTime(dt.Rows[0][2].ToString());
                DateTime fecha_devolucion = Convert.ToDateTime(dt.Rows[0][3].ToString());
                string id_libro =dt.Rows[0][4].ToString();
                string querylibro = "Select TITULO_DEL_LIBRO from Libros where ID_LIBRO=";
                DataTable dt1 = conseguirquerybd(querylibro, id_libro);
                string nombre_libro = dt1.Rows[0][0].ToString();
                DateTime fechanacimiento = Convert.ToDateTime(conseguirqueryfechanac(dni_usuario));
               
                DateTime fecha_actual = DateTime.Today;
                int edad = fecha_actual.Year - fechanacimiento.Year;
                DateTime fechalimite = fecha_prestamo.AddDays(4);
               
                label7.Text = nombre_libro;
                label6.Text = dni_usuario;
                double subtotal = 20;
                double mora;
                if (fecha_devolucion > fechalimite)
                {
                    mora = calcularmora(fecha_devolucion, fechalimite);
                }
                else
                {
                    mora = 0;
                }
                subtotal = subtotal + mora;
                double descuento;
                if (edad > 60)
                {
                    descuento = subtotal * 0.25;
                }
                else
                {
                    descuento = 0;
                }
                double impuesto = subtotal * 0.15;
                double total = impuesto + subtotal - descuento;
                lbl_descuento.Text = descuento.ToString();
                lbl_impuesto.Text = impuesto.ToString();
                lbl_mora.Text = mora.ToString();
                lbl_subtotal.Text = subtotal.ToString();
                lbl_total.Text = total.ToString();
                
                
                
                
                
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden cargar los datos " + ex.ToString());
            }

        }
    }
}
