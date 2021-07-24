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
    public partial class FrmRealizarP : Form
    {
        public FrmRealizarP(string tipodeaccion)
        {
            InitializeComponent();
            if (tipodeaccion == "Entrega")
            {
                dtp_fechalimite.Enabled = false;
                dateT_FPrest_PrestLib.Enabled = false;
                dgv_libros.Enabled = false;
                txt_ID_PrestamoLib.Enabled = false;
                txt_Nombre_PrestamoLib.Enabled = false;
                dateT_FDevolu_PrestLib.Enabled = true;
                btn_Devolucion.Visible = true;
                btn_Agregar_PrestLib.Visible = false;
                btn_Eliminar_PrestLib.Visible = false;

            }
        }
        clsConexion clsConexion1 = new clsConexion();
        private void FrmRealizarP_Load(object sender, EventArgs e)
        {
            clsConexion1.cargarDatos(dgv_PrestLib, "Prestamo");
            clsConexion1.cargarDatos(dgv_libros);
            txt_ID_PrestamoLib.Enabled = false;
            
        }

        private void btn_Agregar_PrestLib_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Nombre_PrestamoLib.Text == string.Empty || libro_code == string.Empty)
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string fecha_prestamo = dateT_FPrest_PrestLib.Value.ToString();
                    string fecha_limite = dtp_fechalimite.Value.ToString();
                    string conexion1 = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
                    SqlConnection sconexion1 = new SqlConnection();
                    sconexion1.ConnectionString = conexion1;
                    sconexion1.Open();
                    SqlCommand agregar = new SqlCommand("Insert into Prestamo(DNI_USUARIO, FECHA_PRESTAMO,FECHA_LIMITE, ID_LIBRO) VALUES(@DNI_USUARIO1, @FECHA_PRESTAMO1, @FECHA_LIMITE1 ,@ID_LIBRO1)", sconexion1);
                    agregar.Parameters.AddWithValue("@DNI_USUARIO1", txt_Nombre_PrestamoLib.Text);
                    agregar.Parameters.AddWithValue("@FECHA_PRESTAMO1",fecha_prestamo);
                    agregar.Parameters.AddWithValue("@FECHA_LIMITE1",fecha_limite);
                    agregar.Parameters.AddWithValue("@ID_LIBRO1",libro_code);
                    

                    agregar.ExecuteNonQuery();
                    sconexion1.Close();
                    txt_ID_PrestamoLib.Clear();
                    txt_Nombre_PrestamoLib.Clear();
                    libro_code = string.Empty;
                    this.txt_ID_PrestamoLib.Focus();

                    clsConexion clsConexion1 = new clsConexion();
                    clsConexion1.cargarDatos(dgv_PrestLib);
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
        }

        private void txt_Nombre_PrestamoLib_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        int i;
        string libro_code;
        private void dgv_libros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            libro_code= dgv_libros.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_Eliminar_PrestLib_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ID_PrestamoLib.Text == string.Empty || txt_Nombre_PrestamoLib.Text == string.Empty || libro_code == string.Empty)
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string conexion1 = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
                    SqlConnection sconexion1 = new SqlConnection();
                    sconexion1.ConnectionString = conexion1;
                    sconexion1.Open();
                    string cod = dgv_PrestLib.CurrentRow.Cells[0].Value.ToString();
                    SqlCommand cmd = new SqlCommand("delete from Prestamo where ID_PRESTAMO = @ID_PRESTAMO1", sconexion1);
                    cmd.Parameters.AddWithValue("@ID_PRESTAMO1", cod);
                    cmd.ExecuteNonQuery();
                    dgv_PrestLib.Rows.RemoveAt(y);
                    MessageBox.Show("El registro ha sido eliminado");
                    txt_ID_PrestamoLib.Clear();
                    txt_Nombre_PrestamoLib.Clear();
                    libro_code = string.Empty;
                    this.txt_ID_PrestamoLib.Focus();

                    clsConexion clsConexion1 = new clsConexion();
                    clsConexion1.cargarDatos(dgv_libros);
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
        }

        int y;
        private void dgv_PrestLib_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            y = e.RowIndex;
            txt_ID_PrestamoLib.Text = dgv_PrestLib.CurrentRow.Cells[0].Value.ToString();
            txt_Nombre_PrestamoLib.Text = dgv_PrestLib.CurrentRow.Cells[1].Value.ToString();
            dateT_FPrest_PrestLib.Value = Convert.ToDateTime(dgv_PrestLib.CurrentRow.Cells[2].Value.ToString());
            dtp_fechalimite.Value = Convert.ToDateTime(dgv_PrestLib.CurrentRow.Cells[3].Value.ToString());
            if (dgv_PrestLib.CurrentRow.Cells[4].Value.ToString() != string.Empty)
            { 
                dateT_FDevolu_PrestLib.Value = Convert.ToDateTime(dgv_PrestLib.CurrentRow.Cells[4].Value.ToString());
            }
            
            libro_code = dgv_PrestLib.CurrentRow.Cells[5].Value.ToString();
            dgv_libros.Enabled = false;


        }

        private void btn_Devolucion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ID_PrestamoLib.Text == string.Empty || libro_code == string.Empty)
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string id_prestamo = txt_ID_PrestamoLib.Text;
                    string fecha_devolucion = dateT_FDevolu_PrestLib.Value.ToString();
                    string conexion1 = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
                    SqlConnection sconexion1 = new SqlConnection();
                    sconexion1.ConnectionString = conexion1;
                    sconexion1.Open();
                    SqlCommand agregar = new SqlCommand("Update Prestamo set FECHA_DEVOLUCION=@FECHA_DEVOLUCION1 where ID_PRESTAMO=@ID_PRESTAMO1", sconexion1);
                    agregar.Parameters.AddWithValue("@ID_PRESTAMO1", id_prestamo);
                    agregar.Parameters.AddWithValue("@FECHA_DEVOLUCION1", fecha_devolucion);

                    

                    agregar.ExecuteNonQuery();
                    sconexion1.Close();
                    txt_ID_PrestamoLib.Clear();
                    txt_Nombre_PrestamoLib.Clear();
                    libro_code = string.Empty;
                    this.txt_ID_PrestamoLib.Focus();

                    clsConexion clsConexion1 = new clsConexion();
                    clsConexion1.cargarDatos(dgv_PrestLib, "Prestamo");
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }

        }

        private void dgv_PrestLib_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
