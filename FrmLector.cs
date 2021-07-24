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
    public partial class FrmLector : Form
    {
        public FrmLector(string tipodeusuario)
        {
            InitializeComponent();
            if (tipodeusuario == "Empleado")
            {
                btn_Eliminar.Visible = false;
                btn_modi_lector.Visible = false;
                dgv_admi_lector.Enabled = false;
                  
            }

        }

        private void FrmLector_Load(object sender, EventArgs e)
        {
            clsConexion clsConexion1 = new clsConexion();
            clsConexion1.cargarDatosUsuarioLector(dgv_admi_lector);
        }
        int i;
        private void dgv_admi_lector_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            txt_dni_lector.Text = dgv_admi_lector.CurrentRow.Cells[0].Value.ToString();
            txt_Nombre_lector.Text = dgv_admi_lector.CurrentRow.Cells[1].Value.ToString();
            txt_Telefono_lector.Text = dgv_admi_lector.CurrentRow.Cells[2].Value.ToString();
            txt_Direcc_lector.Text=dgv_admi_lector.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Value=Convert.ToDateTime(dgv_admi_lector.CurrentRow.Cells[4].Value.ToString());

        }

        private void btn_agre_lector_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (txt_dni_lector.Text == string.Empty || txt_Nombre_lector.Text == string.Empty || txt_Telefono_lector.Text == string.Empty || txt_Direcc_lector.Text == string.Empty)
                    {
                        MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        String fecha_de_nacimiento = dateTimePicker1.Value.ToString();
                        string conexion1 = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
                        SqlConnection sconexion1 = new SqlConnection();
                        sconexion1.ConnectionString = conexion1;
                        sconexion1.Open();
                        SqlCommand agregar = new SqlCommand("Insert into Usuario_Lector(DNI_USUARIO,NOMBRE, DIRECCION, TELEFONO, FECHA_NACIMIENTO) VALUES(@DNI_USUARIO1, @NOMBRE1, @DIRECCION1 ,@TELEFONO1,@FECHA_NACIMIENTO1)", sconexion1);
                        agregar.Parameters.AddWithValue("@DNI_USUARIO1",txt_dni_lector.Text);
                        agregar.Parameters.AddWithValue("@NOMBRE1",txt_Nombre_lector.Text);
                        agregar.Parameters.AddWithValue("@DIRECCION1", txt_Direcc_lector.Text);
                        agregar.Parameters.AddWithValue("@TELEFONO1", txt_Telefono_lector.Text);
                        agregar.Parameters.AddWithValue("@FECHA_NACIMIENTO1", fecha_de_nacimiento);
                        

                        agregar.ExecuteNonQuery();
                        sconexion1.Close();
                        txt_dni_lector.Clear();
                        txt_Nombre_lector.Clear();
                        txt_Telefono_lector.Clear();
                        txt_Direcc_lector.Clear();
                        
                        this.txt_dni_lector.Focus();
                        clsConexion clsConexion1 = new clsConexion();
                        clsConexion1.cargarDatosUsuarioLector(dgv_admi_lector);
                    }
                }
                catch
                {
                    MessageBox.Show("Error...El codigo ya existe en la base de datos");
                }
            }
        }

        private void FrmLector_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_dni_lector.Text == string.Empty || txt_Nombre_lector.Text == string.Empty || txt_Telefono_lector.Text == string.Empty || txt_Direcc_lector.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                   else
                    {
                    string conexion1 = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
                    SqlConnection sconexion1 = new SqlConnection();
                    sconexion1.ConnectionString = conexion1;
                    sconexion1.Open();
                    string cod = dgv_admi_lector.CurrentRow.Cells[0].Value.ToString();
                    SqlCommand cmd = new SqlCommand("delete from Usuario_Lector where DNI_USUARIO = @DNI_USUARIO1", sconexion1);
                    cmd.Parameters.AddWithValue("@DNI_USUARIO1", cod);
                    cmd.ExecuteNonQuery();
                    dgv_admi_lector.Rows.RemoveAt(i);
                    MessageBox.Show("El registro ha sido eliminado");
                    txt_dni_lector.Clear();
                    txt_Nombre_lector.Clear();
                    txt_Telefono_lector.Clear();
                    txt_Direcc_lector.Clear();
                    this.txt_dni_lector.Focus();
                    clsConexion clsConexion1 = new clsConexion();
                    clsConexion1.cargarDatosUsuarioLector(dgv_admi_lector);



               }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
        }

        private void btn_modi_lector_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_dni_lector.Text == string.Empty || txt_Nombre_lector.Text == string.Empty || txt_Telefono_lector.Text == string.Empty || txt_Direcc_lector.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    String fecha_de_nacimiento = dateTimePicker1.Value.ToString();
                    string conexion1 = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
                    SqlConnection sconexion1 = new SqlConnection();
                    sconexion1.ConnectionString = conexion1;
                    sconexion1.Open();
                    string cod = txt_dni_lector.Text;
                    SqlCommand agregar = new SqlCommand("Update Usuario_Lector set DNI_USUARIO=@DNI_USUARIO1,NOMBRE=@NOMBRE1, DIRECCION=@DIRECCION1, TELEFONO=@TELEFONO1, FECHA_NACIMIENTO=@FECHA_NACIMIENTO1 where DNI_USUARIO=@COD ", sconexion1);
                    agregar.Parameters.AddWithValue("@COD", cod);
                    agregar.Parameters.AddWithValue("@DNI_USUARIO1", txt_dni_lector.Text);
                    agregar.Parameters.AddWithValue("@NOMBRE1", txt_Nombre_lector.Text);
                    agregar.Parameters.AddWithValue("@DIRECCION1", txt_Direcc_lector.Text);
                    agregar.Parameters.AddWithValue("@TELEFONO1", txt_Telefono_lector.Text);
                    agregar.Parameters.AddWithValue("@FECHA_NACIMIENTO1", fecha_de_nacimiento);


                    agregar.ExecuteNonQuery();
                    sconexion1.Close();
                    txt_dni_lector.Clear();
                    txt_Nombre_lector.Clear();
                    txt_Telefono_lector.Clear();
                    txt_Direcc_lector.Clear();

                    this.txt_dni_lector.Focus();
                    clsConexion clsConexion1 = new clsConexion();
                    clsConexion1.cargarDatosUsuarioLector(dgv_admi_lector);
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
        }
    }
}
