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
            // TODO: This line of code loads data into the 'bIBLIOTECADataSet5.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.bIBLIOTECADataSet5.Categoria);
            // TODO: This line of code loads data into the 'bIBLIOTECADataSet4.Editorial' table. You can move, or remove it, as needed.
            this.editorialTableAdapter.Fill(this.bIBLIOTECADataSet4.Editorial);
            // TODO: This line of code loads data into the 'bIBLIOTECADataSet3.Libros' table. You can move, or remove it, as needed.
            this.librosTableAdapter.Fill(this.bIBLIOTECADataSet3.Libros);
            clsConexion clsConexion1 = new clsConexion();
            clsConexion1.cargarDatosLibros(dgv_admi_libro);


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
                    string conexion1 = "Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
                    SqlConnection sconexion1 = new SqlConnection();
                    sconexion1.ConnectionString = conexion1;
                    sconexion1.Open();
                    SqlCommand agregar = new SqlCommand("Insert into Libros(ID_LIBRO, TITULO_DEL_LIBRO, EDICION_DEL_LIBRO,NUMERO_DE_PAGINAS, ID_EDITORIAL, ID_CATEGORIA) VALUES(@ID_LIBRO1, @TITULO_DEL_LIBRO1, @EDICION_DEL_LIBRO1 ,@NUMERO_DE_PAGINAS1)", sconexion1);
                    SqlCommand agregar1 = new SqlCommand("Insert into Libros(ID_EDITORIAL) VALUES()", sconexion1);
                    agregar.Parameters.AddWithValue("@ID_LIBRO1",txt_Id_libro.Text);
                    agregar.Parameters.AddWithValue("@TITULO_DEL_LIBRO1", txt_titulo_libro.Text);
                    agregar.Parameters.AddWithValue("@EDICION_DEL_LIBRO1", txt_edicion_libro.Text);
                    agregar.Parameters.AddWithValue("@NUMERO_DE_PAGINAS1", txt_npaginas_libro.Text);
                    agregar.Parameters.AddWithValue("@ID_EDITORIAL1", comboBox1.SelectedIndex);


                    agregar.ExecuteNonQuery();
                    sconexion1.Close();
                  
                    clsConexion clsConexion1 = new clsConexion();
                    clsConexion1.cargarDatos(dgv_admi_libro, "Libros");
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
            codigoEditorial = comboBox1.SelectedIndex.ToString();
            
        }
        int codigoCategoria;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
