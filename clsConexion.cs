using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace Proyecto_Biblioteca
{
    public class clsConexion
    {
        string conexion ="Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
        SqlConnection sconexion = new SqlConnection();
        public clsConexion()
        {
            sconexion.ConnectionString = conexion;

        }
        public void abrir()
        {
            try
            {
                sconexion.Open();
               
                
            }
            catch(Exception ex){
                MessageBox.Show("Ocurrio un error");
            }
        }
        public void cerrar()
        {
            try
            {
                sconexion.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error al cerrar");
            }
        }
        public int login(string username, string password)
        {


            int tipologin=0;
            SqlCommand cmd = new SqlCommand("SELECT USERNAME_ADMIN, PASSWORD_ADMIN FROM Administradores WHERE USERNAME_ADMIN=@usuario AND PASSWORD_ADMIN=@pas", sconexion);
                
            cmd.Parameters.AddWithValue("usuario", username);
            cmd.Parameters.AddWithValue("pas", password);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Usuario Encontrado");
                tipologin=1;
                


            }
            else
            {
                SqlCommand cmd1 = new SqlCommand("SELECT USERNAME_USUARIO, PASSWORD_USUARIO FROM Usuarios WHERE USERNAME_USUARIO=@usuario1 AND PASSWORD_USUARIO=@pas1", sconexion);

                cmd1.Parameters.AddWithValue("usuario1", username);
                cmd1.Parameters.AddWithValue("pas1", password);
                SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                if (dt1.Rows.Count == 1)
                {
                    MessageBox.Show("Usuario Encontrado");
                    tipologin = 2;
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }

            }
            sconexion.Close();
            return tipologin;

        }
        public void cargarDatos(DataGridView dgv, string NameTable)
        {
            try
            {
                sconexion.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from "+NameTable, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource =dt;
                sconexion.Close();

            }
            catch(Exception ex) {
                MessageBox.Show("No se pueden cargar los datos " + ex.ToString());
                    }
        }

        public void cargarDatosLibros(DataGridView dgv)
        {
            try
            {
                sconexion.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT ID_LIBRO, TITULO_DEL_LIBRO, EDICION_DEL_LIBRO, NUMERO_DE_PAGINAS, NOMBRE_CATEGORIA, NOMBRE_EDITORIAL, NOMBRES_AUTOR  FROM Libros,Categoria,Editorial,Autores WHERE Libros.ID_CATEGORIA = Categoria.ID_CATEGORIA AND Libros.ID_EDITORIAL = Editorial.ID_EDITORIAL AND Libros.ID_AUTOR = Autores.ID_AUTOR", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                sconexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden cargar los datos " + ex.ToString());
            }
        }

        public void cargarDatoscombobox(ComboBox cmb1)
        {
            
            sconexion.Open();
            SqlCommand cmd = new SqlCommand("Select ID_AUTOR, NOMBRES_AUTOR FROM Autores",sconexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sconexion.Close();
            cmb1.DisplayMember = "NOMBRES_AUTOR";
            cmb1.ValueMember = "ID_AUTOR";
            DataRow fila = dt.NewRow();
            dt.Rows.InsertAt(fila, 0);
            cmb1.ValueMember = "ID_AUTOR";
            cmb1.DisplayMember = "NOMBRES_AUTOR";
            cmb1.DataSource = dt;
                
        }
    }
}
