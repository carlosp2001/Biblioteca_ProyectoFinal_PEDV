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
    public partial class FrmLibro : Form
    {
        public FrmLibro()
        {
            InitializeComponent();
        }

        private void FrmLibro_Load(object sender, EventArgs e)
        {
            clsConexion clsConexion1 = new clsConexion();
            clsConexion1.cargarDatos(dgv_admi_libro);
            clsConexion1.cargarDatoscomboboxAutor(comboBox3);
            clsConexion1.cargarDatoscomboboxEditorial(comboBox1);
            clsConexion1.cargarDatoscomboboxCategoria(comboBox2);
            


            // TODO: This line of code loads data into the 'bIBLIOTECADataSet10.Autores' table. You can move, or remove it, as needed.



            // TODO: This line of code loads data into the 'bIBLIOTECADataSet9.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter1.Fill(this.bIBLIOTECADataSet9.Autores);
            // TODO: This line of code loads data into the 'bIBLIOTECADataSet8.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter1.Fill(this.bIBLIOTECADataSet8.Categoria);
            // TODO: This line of code loads data into the 'bIBLIOTECADataSet7.Editorial' table. You can move, or remove it, as needed.
            this.editorialTableAdapter1.Fill(this.bIBLIOTECADataSet7.Editorial);
            // TODO: This line of code loads data into the 'bIBLIOTECADataSet6.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.bIBLIOTECADataSet6.Autores);
            // TODO: This line of code loads data into the 'bIBLIOTECADataSet5.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.bIBLIOTECADataSet5.Categoria);
            // TODO: This line of code loads data into the 'bIBLIOTECADataSet4.Editorial' table. You can move, or remove it, as needed.
            this.editorialTableAdapter.Fill(this.bIBLIOTECADataSet4.Editorial);
            // TODO: This line of code loads data into the 'bIBLIOTECADataSet3.Libros' table. You can move, or remove it, as needed.
            this.librosTableAdapter.Fill(this.bIBLIOTECADataSet3.Libros);
            

        }

        private void btn_Agre_libro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Id_libro.Text == string.Empty || txt_titulo_libro.Text==string.Empty || txt_edicion_libro.Text==string.Empty || txt_npaginas_libro.Text==string.Empty)
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    codigoCategoria = comboBox2.SelectedValue.ToString();
                    codigoEditorial = comboBox1.SelectedValue.ToString();
                    codigoAutor = comboBox3.SelectedValue.ToString();
                    string conexion1 = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
                    SqlConnection sconexion1 = new SqlConnection();
                    sconexion1.ConnectionString = conexion1;
                    sconexion1.Open();                 
                    SqlCommand agregar = new SqlCommand("Insert into Libros(ID_LIBRO, TITULO_DEL_LIBRO, EDICION_DEL_LIBRO,NUMERO_DE_PAGINAS, ID_EDITORIAL, ID_CATEGORIA, ID_AUTOR) VALUES(@ID_LIBRO1, @TITULO_DEL_LIBRO1, @EDICION_DEL_LIBRO1 ,@NUMERO_DE_PAGINAS1,@ID_EDITORIAL1, @ID_CATEGORIA1, @ID_AUTOR1)", sconexion1);
                    agregar.Parameters.AddWithValue("@ID_LIBRO1",txt_Id_libro.Text);
                    agregar.Parameters.AddWithValue("@TITULO_DEL_LIBRO1", txt_titulo_libro.Text);
                    agregar.Parameters.AddWithValue("@EDICION_DEL_LIBRO1", txt_edicion_libro.Text);
                    agregar.Parameters.AddWithValue("@NUMERO_DE_PAGINAS1", txt_npaginas_libro.Text);
                    agregar.Parameters.AddWithValue("@ID_EDITORIAL1", codigoEditorial);
                    agregar.Parameters.AddWithValue("@ID_CATEGORIA1", codigoCategoria);
                    agregar.Parameters.AddWithValue("@ID_AUTOR1", codigoAutor);

                    agregar.ExecuteNonQuery();
                    sconexion1.Close();
                    txt_Id_libro.Clear();
                    txt_titulo_libro.Clear();
                    txt_edicion_libro.Clear();
                    txt_npaginas_libro.Clear();
                    comboBox1.Text=" ";
                    comboBox2.Text=" ";
                    comboBox3.Text=" ";
                    this.txt_Id_libro.Focus();
                  
                    clsConexion clsConexion1 = new clsConexion();
                    clsConexion1.cargarDatos(dgv_admi_libro);
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
        }
        String codigoEditorial;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigoEditorial = comboBox1.SelectedValue.ToString();
            

            
        }
        String codigoCategoria;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigoCategoria = comboBox2.SelectedValue.ToString();


        }
        String codigoAutor;

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            

        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            codigoAutor = comboBox3.SelectedValue.ToString();
            

        }

        private void btn_Eliminar_Libros_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Id_libro.Text == string.Empty || txt_titulo_libro.Text == string.Empty || txt_edicion_libro.Text == string.Empty || txt_npaginas_libro.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string conexion1 = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
                    SqlConnection sconexion1 = new SqlConnection();
                    sconexion1.ConnectionString = conexion1;
                    sconexion1.Open();
                    string cod = dgv_admi_libro.CurrentRow.Cells[0].Value.ToString();
                    SqlCommand cmd = new SqlCommand("delete from Libros where ID_LIBRO = " + cod, sconexion1);
                    cmd.ExecuteNonQuery();
                    dgv_admi_libro.Rows.RemoveAt(i);
                    MessageBox.Show("El registro ha sido eliminado");
                    txt_Id_libro.Clear();
                    txt_titulo_libro.Clear();
                    txt_edicion_libro.Clear();
                    txt_npaginas_libro.Clear();
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    comboBox3.Text = "";
                    this.txt_Id_libro.Focus();

                    clsConexion clsConexion1 = new clsConexion();
                    clsConexion1.cargarDatos(dgv_admi_libro);



                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
        }
        int i;

        

        private void dgv_admi_libro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            txt_Id_libro.Text = dgv_admi_libro.CurrentRow.Cells[0].Value.ToString();
            txt_titulo_libro.Text = dgv_admi_libro.CurrentRow.Cells[1].Value.ToString();
            txt_edicion_libro.Text = dgv_admi_libro.CurrentRow.Cells[2].Value.ToString();
            txt_npaginas_libro.Text = dgv_admi_libro.CurrentRow.Cells[3].Value.ToString();
            comboBox2.SelectedIndex=comboBox2.FindStringExact(dgv_admi_libro.CurrentRow.Cells[4].Value.ToString());
            comboBox1.SelectedIndex=comboBox1.FindStringExact(dgv_admi_libro.CurrentRow.Cells[5].Value.ToString());
            comboBox3.SelectedIndex=comboBox3.FindStringExact(dgv_admi_libro.CurrentRow.Cells[6].Value.ToString());
        }

        private void btn_Modi_libro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Id_libro.Text == string.Empty || txt_titulo_libro.Text == string.Empty || txt_edicion_libro.Text == string.Empty || txt_npaginas_libro.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    codigoCategoria = comboBox2.SelectedValue.ToString();
                    codigoEditorial = comboBox1.SelectedValue.ToString();
                    codigoAutor = comboBox3.SelectedValue.ToString();
                    string conexion1 = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
                    SqlConnection sconexion1 = new SqlConnection();
                    sconexion1.ConnectionString = conexion1;
                    sconexion1.Open();
                    SqlCommand agregar = new SqlCommand("update Libros set TITULO_DEL_LIBRO=@TITULO_DEL_LIBRO1, EDICION_DEL_LIBRO=@EDICION_DEL_LIBRO1,NUMERO_DE_PAGINAS=@NUMERO_DE_PAGINAS1, ID_EDITORIAL=@ID_EDITORIAL1, ID_CATEGORIA=@ID_CATEGORIA1, ID_AUTOR=@ID_AUTOR1 where ID_LIBRO="+ txt_Id_libro.Text, sconexion1);
                    
                    agregar.Parameters.AddWithValue("@TITULO_DEL_LIBRO1", txt_titulo_libro.Text);
                    agregar.Parameters.AddWithValue("@EDICION_DEL_LIBRO1", txt_edicion_libro.Text);
                    agregar.Parameters.AddWithValue("@NUMERO_DE_PAGINAS1", txt_npaginas_libro.Text);
                    agregar.Parameters.AddWithValue("@ID_EDITORIAL1", codigoEditorial);
                    agregar.Parameters.AddWithValue("@ID_CATEGORIA1", codigoCategoria);
                    agregar.Parameters.AddWithValue("@ID_AUTOR1", codigoAutor);

                    agregar.ExecuteNonQuery();
                    sconexion1.Close();
                    txt_Id_libro.Clear();
                    txt_titulo_libro.Clear();
                    txt_edicion_libro.Clear();
                    txt_npaginas_libro.Clear();
                    
                    this.txt_Id_libro.Focus();

                    clsConexion clsConexion1 = new clsConexion();
                    clsConexion1.cargarDatos(dgv_admi_libro);
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
        }

        private void FrmLibro_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
