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
        public void login(string username, string password)
        {

            
               
            SqlCommand cmd = new SqlCommand("SELECT USERNAME_ADMIN, PASSWORD_ADMIN FROM Administradores WHERE USERNAME_ADMIN=@usuario AND PASSWORD_ADMIN=@pas", sconexion);
                
            cmd.Parameters.AddWithValue("usuario", username);
            cmd.Parameters.AddWithValue("pas", password);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Usuario Encontrado");

            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
            
        

           
        }
        /*public void Frm_Login_Admi(string usuario, string contrasena)
        {
            try
            {
                conexion.Open();
                //SqlCommand cmd = new SqlCommand("SELECT USERNAME_ADMIN, PASSWORD_ADMIN FROM Administradores WHERE ");
                //cmd.Parameters.AddWithValue
                MessageBox.Show("Se abrio la conexion con el servidor SQL Server");
                conexion.Close();

            }
            catch
            {
                MessageBox.Show("No se creo la conexion con la base de datos");
            }
        }*/


    }
}
