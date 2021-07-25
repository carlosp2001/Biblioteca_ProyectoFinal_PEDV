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
    public partial class Frm_Admi_Usuario : Form
    {
        public Frm_Admi_Usuario()
        {
            InitializeComponent();
        }

        private void Frm_Admi_Usuario_Load(object sender, EventArgs e)
        {
            clsConexion clsConexion1 = new clsConexion();
            clsConexion1.cargarDatosUsuarios(dataGridView1);
            clsConexion1.cargarDatoscomboboxTiposdeUsuarios(comboBox1);
            txt_Id_UsuarioSist.Enabled = false;
        }

        int i;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id_UsuarioSist.Enabled = false;
            comboBox1.Enabled = false;
            i = e.RowIndex;
            txt_Id_UsuarioSist.Text =dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_nombreusuario.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_Nombre_UsuarioSist.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.SelectedIndex =comboBox1.FindStringExact(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombreusuario.Text == string.Empty || txt_Nombre_UsuarioSist.Text == string.Empty || txt_nombreusuario.Text == string.Empty )
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    string conexion1 = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
                    SqlConnection sconexion1 = new SqlConnection();
                    sconexion1.ConnectionString = conexion1;
                    sconexion1.Open();
                    if (comboBox1.Text=="Administrador") {
                    SqlCommand agregar = new SqlCommand("Insert into Administradores(USERNAME_ADMIN, PASSWORD_ADMIN, ID_TIPO) VALUES(@USERNAME_ADMIN1, @PASSWORD_ADMIN1,'1')", sconexion1);
                    agregar.Parameters.AddWithValue("@USERNAME_ADMIN1", txt_nombreusuario.Text);
                    agregar.Parameters.AddWithValue("@PASSWORD_ADMIN1", txt_Nombre_UsuarioSist.Text);
                    agregar.ExecuteNonQuery();
                    sconexion1.Close();
                    }else if(comboBox1.Text == "Usuario"){
                        SqlCommand agregar = new SqlCommand("Insert into Usuarios(USERNAME_USUARIO, PASSWORD_USUARIO, ID_TIPO) VALUES(@USERNAME_USUARIO1, @PASSWORD_USUARIO1,'2')", sconexion1);
                        agregar.Parameters.AddWithValue("@USERNAME_USUARIO1", txt_nombreusuario.Text);
                        agregar.Parameters.AddWithValue("@PASSWORD_USUARIO1", txt_Nombre_UsuarioSist.Text);
                        agregar.ExecuteNonQuery();
                        sconexion1.Close();
                    }

                    txt_Id_UsuarioSist.Clear();
                    txt_nombreusuario.Clear();
                    txt_Nombre_UsuarioSist.Clear();
                    comboBox1.Enabled = true;
                    clsConexion clsConexion1 = new clsConexion();
                    clsConexion1.cargarDatosUsuarios(dataGridView1);
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
        }

        private void btn_Eliminar_Usuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombreusuario.Text == string.Empty || txt_Nombre_UsuarioSist.Text == string.Empty || txt_nombreusuario.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string conexion1 = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
                    SqlConnection sconexion1 = new SqlConnection();
                    sconexion1.ConnectionString = conexion1;
                    sconexion1.Open();
                    if (comboBox1.Text == "Administrador")
                    {
                        string cod = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        SqlCommand cmd = new SqlCommand("delete from Administradores where ID_ADMIN = " + cod, sconexion1);
                        cmd.ExecuteNonQuery();
                        dataGridView1.Rows.RemoveAt(i);
                        MessageBox.Show("El registro ha sido eliminado");
                        sconexion1.Close();
                    }
                    else if (comboBox1.Text == "Usuario")
                    {
                        string cod = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        SqlCommand cmd = new SqlCommand("delete from Usuarios where ID_USUARIO = " + cod, sconexion1);
                        cmd.ExecuteNonQuery();
                        dataGridView1.Rows.RemoveAt(i);
                        MessageBox.Show("El registro ha sido eliminado");
                        sconexion1.Close();
                    }
                    txt_Id_UsuarioSist.Clear();
                    txt_nombreusuario.Clear();
                    txt_Nombre_UsuarioSist.Clear();
                    comboBox1.Enabled = true;


                    clsConexion clsConexion1 = new clsConexion();
                    clsConexion1.cargarDatosUsuarios(dataGridView1);
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombreusuario.Text == string.Empty || txt_Nombre_UsuarioSist.Text == string.Empty || txt_nombreusuario.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string conexion1 = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
                    SqlConnection sconexion1 = new SqlConnection();
                    sconexion1.ConnectionString = conexion1;
                    sconexion1.Open();
                    if (comboBox1.Text == "Administrador")
                    {
                        SqlCommand agregar = new SqlCommand("Update Administradores set USERNAME_ADMIN=@USERNAME_ADMIN1, PASSWORD_ADMIN=@PASSWORD_ADMIN1, ID_TIPO=@ID_TIPO1 where ID_ADMIN="+txt_Id_UsuarioSist.Text, sconexion1);
                        agregar.Parameters.AddWithValue("@USERNAME_ADMIN1", txt_nombreusuario.Text);
                        agregar.Parameters.AddWithValue("@PASSWORD_ADMIN1", txt_Nombre_UsuarioSist.Text);
                        agregar.Parameters.AddWithValue("@ID_TIPO1", comboBox1.SelectedValue.ToString());
                        agregar.ExecuteNonQuery();
                        sconexion1.Close();
                    }
                    else if (comboBox1.Text == "Usuario")
                    {
                        SqlCommand agregar = new SqlCommand("Update Usuarios set USERNAME_USUARIO=@USERNAME_USUARIO1, PASSWORD_USUARIO=@PASWORD_USUARIO1, ID_TIPO=@ID_TIPO1 where ID_USUARIO=" + txt_Id_UsuarioSist.Text, sconexion1);
                        agregar.Parameters.AddWithValue("@USERNAME_ADMIN1", txt_nombreusuario.Text);
                        agregar.Parameters.AddWithValue("@PASSWORD_ADMIN1", txt_Nombre_UsuarioSist.Text);
                        agregar.Parameters.AddWithValue("@ID_TIPO1", comboBox1.SelectedValue.ToString());
                        agregar.ExecuteNonQuery();
                        sconexion1.Close();
                    }

                    txt_Id_UsuarioSist.Clear();
                    txt_nombreusuario.Clear();
                    txt_Nombre_UsuarioSist.Clear();
                    comboBox1.Enabled = true;
                    clsConexion clsConexion1 = new clsConexion();
                    clsConexion1.cargarDatosUsuarios(dataGridView1);
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
        }
    }
}
