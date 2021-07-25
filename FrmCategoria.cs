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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bIBLIOTECADataSet1.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.bIBLIOTECADataSet1.Categoria);

        }
        int i;
        clsConexion clsConexion1 = new clsConexion();
        private void dgv_Admi_Cat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            txt_Id_Cat.Text=dgv_Admi_Cat.CurrentRow.Cells[0].Value.ToString();
            txt_Nombre_Cat.Text= dgv_Admi_Cat.CurrentRow.Cells[1].Value.ToString();
            
        }

        private void btn_Agregar_Cat_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_Nombre_Cat .Text == string.Empty )
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string conexion1 = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
                    SqlConnection sconexion1 = new SqlConnection();
                    sconexion1.ConnectionString = conexion1;
                    sconexion1.Open();
                    SqlCommand agregar = new SqlCommand("Insert into Categoria(NOMBRE_CATEGORIA) VALUES(@NOMBRE_CATEGORIA1)", sconexion1);
                    agregar.Parameters.AddWithValue("@NOMBRE_CATEGORIA1", txt_Nombre_Cat.Text);
                                       
                    agregar.ExecuteNonQuery();
                    sconexion1.Close();
                    txt_Id_Cat.Clear();
                    txt_Nombre_Cat.Clear();
                    this.txt_Nombre_Cat.Focus();
                    clsConexion1.cargarDatos(dgv_Admi_Cat, "Categoria");
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
        

        }

        private void btn_Eliminar_cat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Nombre_Cat.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string conexion1 = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
                    SqlConnection sconexion1 = new SqlConnection();
                    sconexion1.ConnectionString = conexion1;
                    sconexion1.Open();
                    string cod = dgv_Admi_Cat.CurrentRow.Cells[0].Value.ToString();
                    SqlCommand cmd = new SqlCommand("delete from Categoria where ID_CATEGORIA = " + cod, sconexion1);
                    cmd.ExecuteNonQuery();
                    dgv_Admi_Cat.Rows.RemoveAt(i);
                    MessageBox.Show("El registro ha sido eliminado");

                   
                    sconexion1.Close();
                    txt_Id_Cat.Clear();
                    txt_Nombre_Cat.Clear();
                    this.txt_Nombre_Cat.Focus();
                    clsConexion1.cargarDatos(dgv_Admi_Cat, "Categoria");
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }

        }

        private void btn_Modi_Cat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Nombre_Cat.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string conexion1 = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
                    SqlConnection sconexion1 = new SqlConnection();
                    sconexion1.ConnectionString = conexion1;
                    sconexion1.Open();
                    SqlCommand modificar = new SqlCommand("update Categoria set NOMBRE_CATEGORIA=@NOMBRE_CATEGORIA1 where ID_CATEGORIA = " + txt_Id_Cat.Text, sconexion1);
                    modificar.Parameters.AddWithValue("@NOMBRE_CATEGORIA1", txt_Nombre_Cat.Text);

                    modificar.ExecuteNonQuery();
                    MessageBox.Show("El registro ha sido actualizado");
                    sconexion1.Close();
                    txt_Id_Cat.Clear();
                    txt_Nombre_Cat.Clear();
                    this.txt_Nombre_Cat.Focus();
                    clsConexion1.cargarDatos(dgv_Admi_Cat, "Categoria");
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }

        }
    }
}
