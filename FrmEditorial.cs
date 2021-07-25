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
    public partial class FrmEditorial : Form
    {
        public FrmEditorial()
        {
            InitializeComponent();
        }

        private void FrmEditorial_Load(object sender, EventArgs e)
        {
            txt_Id_editorial.Enabled = false;
            // TODO: This line of code loads data into the 'bIBLIOTECADataSet2.Editorial' table. You can move, or remove it, as needed.
            this.editorialTableAdapter.Fill(this.bIBLIOTECADataSet2.Editorial);

        }
        int i;
        
        private void dgv_admi_editorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        clsConexion clsConexion1 = new clsConexion();


        //Boton que realiza la accion de agregar los datos a la base de datos
        /// <summary>
        /// Boton que realiza la accion de agregar los datos a la base de datos
        /// </summary>
        /// <param name="@"></Identificador que crea una relacion entre el comando sql y una variable de c#>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Agre_editorial_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Nombre_editorial.Text == string.Empty || txt_pais_editorial.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string conexion1 = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
                    SqlConnection sconexion1 = new SqlConnection();
                    sconexion1.ConnectionString = conexion1;
                    sconexion1.Open();
                    SqlCommand agregar = new SqlCommand("Insert into Editorial(NOMBRE_EDITORIAL, PAIS_LUGAR) VALUES(@NOMBRE_EDITORIAL1, @PAIS_LUGAR1)", sconexion1);
                    agregar.Parameters.AddWithValue("@NOMBRE_EDITORIAL1", txt_Nombre_editorial.Text);
                    agregar.Parameters.AddWithValue("@PAIS_LUGAR1", txt_pais_editorial.Text);
                    agregar.ExecuteNonQuery();
                    sconexion1.Close();
                    txt_Id_editorial.Clear();
                    txt_Nombre_editorial.Clear();
                    txt_pais_editorial.Clear();
                    this.txt_Nombre_editorial.Focus();
                    
                    clsConexion1.cargarDatos(dgv_admi_editorial, "Editorial");
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }

        }

        //Boton que realiza la accion de eliminar los datos a la base de datos
        /// <summary>
        /// Boton que realiza la accion de eliminar los datos a la base de datos
        /// </summary>
        /// <param name="@"></Identificador que crea una relacion entre el comando sql y una variable de c#>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Eliminar_Editorial_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Nombre_editorial.Text == string.Empty || txt_pais_editorial.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string conexion1 = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
                    SqlConnection sconexion1 = new SqlConnection();
                    sconexion1.ConnectionString = conexion1;
                    sconexion1.Open();
                    string cod = dgv_admi_editorial.CurrentRow.Cells[0].Value.ToString();
                    SqlCommand cmd = new SqlCommand("delete from Editorial where ID_EDITORIAL = " + cod, sconexion1);
                    cmd.ExecuteNonQuery();
                    sconexion1.Close();
                    txt_Id_editorial.Clear();
                    txt_Nombre_editorial.Clear();
                    txt_pais_editorial.Clear();
                    this.txt_Nombre_editorial.Focus();
                   
                    clsConexion1.cargarDatos(dgv_admi_editorial, "Editorial");
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
        }

        //Boton que realiza la accion de editar los datos a la base de datos
        /// <summary>
        /// Boton que realiza la accion de editar los datos a la base de datos
        /// </summary>
        /// <param name="@"></Identificador que crea una relacion entre el comando sql y una variable de c#>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Modi_editorial_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Nombre_editorial.Text == string.Empty || txt_pais_editorial.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string conexion1 = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
                    SqlConnection sconexion1 = new SqlConnection();
                    sconexion1.ConnectionString = conexion1;
                    sconexion1.Open();
                    SqlCommand modificar = new SqlCommand("update Editorial set NOMBRE_EDITORIAL=@NOMBRE_EDITORIAL1, PAIS_LUGAR=@PAIS_LUGAR1 where ID_EDITORIAL = " + txt_Id_editorial.Text, sconexion1);
                    modificar.Parameters.AddWithValue("@NOMBRE_EDITORIAL1", txt_Nombre_editorial.Text);
                    modificar.Parameters.AddWithValue("@PAIS_LUGAR1", txt_pais_editorial.Text);
                    modificar.ExecuteNonQuery();
                    MessageBox.Show("El registro ha sido actualizado");
                    
                    sconexion1.Close();
                    txt_Id_editorial.Clear();
                    txt_Nombre_editorial.Clear();
                    txt_pais_editorial.Clear();
                    this.txt_Nombre_editorial.Focus();
                  
                    clsConexion1.cargarDatos(dgv_admi_editorial, "Editorial");
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }

        }


        //Metodo al seleccion una celda del datagridview
        /// <summary>
        /// Metodo al seleccion una celda del datagridview
        /// </summary>
        /// entre el combobox,textbox y la celda>
        /// <param name="sender"></param>
        /// <param name="e"></Indica el indice de la celda seleccionada>
        private void dgv_admi_editorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            txt_Id_editorial.Text = dgv_admi_editorial.CurrentRow.Cells[0].Value.ToString();
            txt_Nombre_editorial.Text = dgv_admi_editorial.CurrentRow.Cells[1].Value.ToString();
            txt_pais_editorial.Text = dgv_admi_editorial.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
