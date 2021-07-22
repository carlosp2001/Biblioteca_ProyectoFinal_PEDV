using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Biblioteca
{
    public partial class FrmAutorTable : Form
    {
        public FrmAutorTable()
        {
            InitializeComponent();
        }
        int i;
        private void FrmAutor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bIBLIOTECADataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.bIBLIOTECADataSet.Autores);

        }

        private void dgv_admi_cat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        clsConexion clsConexion1 = new clsConexion();
        private void btn_Agre_autor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Id_autor.Text == string.Empty || txt_Nombre_autor.Text == string.Empty || txt_Apellido_autor.Text==string.Empty || txt_Nacionalidad_autor.Text==string.Empty)
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string conexion1 = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
                    SqlConnection sconexion1 = new SqlConnection();
                    sconexion1.ConnectionString = conexion1;
                    sconexion1.Open();
                    SqlCommand agregar= new SqlCommand("Insert into Autores(ID_AUTOR,NOMBRES_AUTOR, APELLIDOS_AUTOR, NACIONALIDAD_AUTOR) VALUES(@ID_AUTOR1,@NOMBRES_AUTOR1,@APELLIDOS_AUTOR1,@NACIONALIDAD_AUTOR1)",sconexion1);
                    agregar.Parameters.AddWithValue("@ID_AUTOR1", txt_Id_autor.Text);
                    agregar.Parameters.AddWithValue("@NOMBRES_AUTOR1", txt_Nombre_autor.Text);
                    agregar.Parameters.AddWithValue("@APELLIDOS_AUTOR1", txt_Apellido_autor.Text);
                    agregar.Parameters.AddWithValue("@NACIONALIDAD_AUTOR1", txt_Nacionalidad_autor.Text);
                    agregar.ExecuteNonQuery();
                    sconexion1.Close();
                    txt_Id_autor.Clear();
                    txt_Nombre_autor.Clear();
                    txt_Apellido_autor.Clear();
                    txt_Nacionalidad_autor.Clear();
                    this.txt_Id_autor.Focus();
                    clsConexion1.cargarDatos(dgv_admi_cat, "Autores");
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }



        }

        private void autoresBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btn_Eli_Autor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Id_autor.Text == string.Empty || txt_Nombre_autor.Text == string.Empty || txt_Apellido_autor.Text == string.Empty || txt_Nacionalidad_autor.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    if (i != -1)
                    {
                        string conexion1 = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
                        SqlConnection sconexion1 = new SqlConnection();
                        sconexion1.ConnectionString = conexion1;
                        sconexion1.Open();
                        string cod = dgv_admi_cat.CurrentRow.Cells[0].Value.ToString();
                        SqlCommand cmd = new SqlCommand("delete from Autores where ID_AUTOR = " + cod, sconexion1);
                        cmd.ExecuteNonQuery();
                        dgv_admi_cat.Rows.RemoveAt(i);
                        MessageBox.Show("El registro ha sido eliminado");
                        sconexion1.Close();
                        txt_Id_autor.Clear();
                        txt_Nombre_autor.Clear();
                        txt_Apellido_autor.Clear();
                        txt_Nacionalidad_autor.Clear();
                        this.txt_Id_autor.Focus();
                        clsConexion1.cargarDatos(dgv_admi_cat, "Autores");

                    }

                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }

        }

        private void dgv_admi_cat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;

            txt_Id_autor.Text = dgv_admi_cat.CurrentRow.Cells[0].Value.ToString();
            txt_Nombre_autor.Text = dgv_admi_cat.CurrentRow.Cells[1].Value.ToString();
            txt_Apellido_autor.Text = dgv_admi_cat.CurrentRow.Cells[2].Value.ToString();
            txt_Nacionalidad_autor.Text = dgv_admi_cat.CurrentRow.Cells[3].Value.ToString();


        }

        private void btn_Modi_autor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Id_autor.Text == string.Empty || txt_Nombre_autor.Text == string.Empty || txt_Apellido_autor.Text == string.Empty || txt_Nacionalidad_autor.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (i != -1)
                    {
                        string conexion1 = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
                        SqlConnection sconexion1 = new SqlConnection();
                        sconexion1.ConnectionString = conexion1;
                        sconexion1.Open();
                        SqlCommand cmd = new SqlCommand("update Autores set ID_AUTOR =@ID_AUTOR1, NOMBRES_AUTOR=@NOMBRES_AUTOR1, APELLIDOS_AUTOR=@APELLIDOS_AUTOR1, NACIONALIDAD_AUTOR=@NACIONALIDAD_AUTOR1  where ID_AUTOR = " + txt_Id_autor.Text, sconexion1);
                        cmd.Parameters.AddWithValue ("@ID_AUTOR1", txt_Id_autor.Text);
                        cmd.Parameters.AddWithValue("@NOMBRES_AUTOR1", txt_Nombre_autor.Text);
                        cmd.Parameters.AddWithValue("@APELLIDOS_AUTOR1", txt_Apellido_autor.Text);
                        cmd.Parameters.AddWithValue("@NACIONALIDAD_AUTOR1", txt_Nacionalidad_autor.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("El registro ha sido actualizado");
                        
                       
                        sconexion1.Close();
                        txt_Id_autor.Clear();
                        txt_Nombre_autor.Clear();
                        txt_Apellido_autor.Clear();
                        txt_Nacionalidad_autor.Clear();
                        this.txt_Id_autor.Focus();
                        clsConexion1.cargarDatos(dgv_admi_cat, "Autores");

                    }

                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }

        }
    }
}

