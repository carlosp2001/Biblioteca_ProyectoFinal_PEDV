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
    //Clase para realizar la conexion a sql server
    /// <summary>
    /// Clase para realizar la conexion a sql server
    /// <param name="conexion"/>Genera la linea fuente para la conexion de Sql Server
    /// <param name="sconexion"/>Define la nueva conexion a Sql Server
    /// </summary>
    public class clsConexion
    {
        
        string conexion ="Data Source= Windows10\\SQLEXPRESS; Initial Catalog=BIBLIOTECA ;Integrated Security=True";
        SqlConnection sconexion = new SqlConnection();
        
        //Constructor de la clase conexión
        /// <summary>
        /// Constructor de la clase conexión
        /// <param name="sconexion.ConnectionString"></Define la linea de conexion que tendra la variable de Sql Server>
        /// </summary>
        public clsConexion()
        {
            sconexion.ConnectionString = conexion;

        }

        //Metodo para abrir la conexion a Sql Server
        /// <summary>
        /// Metodo para abrir la conexion a Sql Server
        /// </summary>
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

        //Metodo para cerrar la conexion a Sql Server
        /// <summary>
        /// Metodo para cerrar la conexion a Sql Server
        /// </summary>
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

        //Metodo para realizar la verificacion de usuario, identificar si es Administrador o Empleado
        /// <summary>
        /// Metodo para realizar la verificacion de usuario, identificar si es Administrador o Empleado
        /// 
        /// </summary>
        /// <param name="username"></Parametro que recibe el usuario mandado del textbox usuario del form1>
        /// <param name="password"></Parametro que recibe la contrasena mandada del textbox contrasena del form1>
        /// <param name="cmd"></Define la linea de comando Sql que ejecutara el select mediante un if para determinar
        /// si el usuario se encuentra en la tabal de administrador o en la de empleado>
        /// <param name="tipologin"></Es la variable que almacena un valor dependiendo del tipo de login>
        /// <param name="sda" & <param name="dt"></El DataAdapter recibe los datos encontrados del select y los almacena 
        /// en el datatable>
        /// <returns></returns>
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

        //Polimorfismo: Funcion para cargarDatos de cualquier tabla y asignarlos a un datagridview
        //Homonimia o sobrecarga:Existe una funcion del mismo nombre pero recibe diferentes parametros
        /// <summary>
        ///Polimorfismo: Funcion para cargarDatos de cualquier tabla y asignarlos a un datagridview
        ///Homonimia o sobrecarga:Existe una funcion del mismo nombre pero recibe diferentes parametros
        /// </summary>
        /// <param name="dgv"></Recibe el DataGridView en el cual queremos cargar los datos>
        /// <param name="NameTable"></Recibe la tablade Sql en la cual se buscaran los datos a cargar>
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


        //Polimorfismo: Funcion para cargarDatos de la tabla Libro a un datagridview
        //Homonimia o sobrecarga:Existe una funcion del mismo nombre pero recibe diferentes parametros
        /// <summary>
        ///Polimorfismo: Funcion para cargarDatos tabla Libro y asignarlos a un datagridview
        ///Homonimia o sobrecarga:Existe una funcion del mismo nombre pero recibe diferentes parametros
        /// </summary>
        /// <param name="dgv"></Recibe el DataGridView en el cual queremos cargar los datos>
        public void cargarDatos(DataGridView dgv)
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
        //Funcion para cargar los Usuarios del Sistema de la tabla administrador y empleado
        /// <summary>
        ///Funcion para cargar los Usuarios del Sistema de la tabla administrador y empleado 
        /// </summary>
        /// <param name="dgv"></Recibe el datagridview en el cual queremos cargar los usuarios>
        public void cargarDatosUsuarios(DataGridView dgv)
        {
            try
            {
                sconexion.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT ID_ADMIN, USERNAME_ADMIN, PASSWORD_ADMIN, NOMBRE_TIPO FROM Administradores,Tipo_de_Usuario WHERE Administradores.ID_TIPO=Tipo_de_Usuario.ID_Tipo UNION SELECT ID_USUARIO, USERNAME_USUARIO, PASSWORD_USUARIO, NOMBRE_TIPO FROM Usuarios, Tipo_de_Usuario WHERE Usuarios.ID_TIPO=Tipo_de_Usuario.ID_Tipo", conexion);
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

        //Metodo para cargar los datos de la tabla Autores en un combobox
        /// <summary>
        /// Metodo para cargar los datos de la tabla Autores en un combobox
        /// </summary>
        /// <param name="cmb1"></Recibe el combobox donde se guardaran los datos de sql>
        public void cargarDatoscomboboxAutor(ComboBox cmb1)
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

        //Metodo para cargar los datos del DNI del Usuario en un combobox
        /// <summary>
        /// Metodo para cargar los datos del DNI del Usuario en un combobox
        /// </summary>
        /// <param name="cmb1"></Recibe el combobox en el cual se cargaran los datos del DNI Usuario>
        public void cargarDatoscomboboxDNIUsuario(ComboBox cmb1)
        {

            sconexion.Open();
            SqlCommand cmd = new SqlCommand("Select DNI_USUARIO FROM Usuario_Lector", sconexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sconexion.Close();
            cmb1.DisplayMember = "DNI_USUARIO";
            cmb1.ValueMember = "DNI_USUARIO";
            DataRow fila = dt.NewRow();
            dt.Rows.InsertAt(fila, 0);
            cmb1.ValueMember = "DNI_USUARIO";
            cmb1.DisplayMember = "DNI_USUARIO";
            cmb1.DataSource = dt;

        }

        //Metodo para cargar las categorias de los libros en un combobox
        /// <summary>
        /// Metodo para cargar las categorias de los libros en un combobox
        /// </summary>
        /// <param name="cmb1"></Recibe el combobox en el cual se cargaran los datos de las categorias de la tabla Libros>
        public void cargarDatoscomboboxCategoria(ComboBox cmb1)
        {

            sconexion.Open();
            SqlCommand cmd = new SqlCommand("Select ID_CATEGORIA, NOMBRE_CATEGORIA FROM Categoria", sconexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sconexion.Close();
            cmb1.DisplayMember = "NOMBRE_CATEGORIA";
            cmb1.ValueMember = "ID_CATEGORIA";
            DataRow fila = dt.NewRow();
            dt.Rows.InsertAt(fila, 0);
            cmb1.ValueMember = "ID_CATEGORIA";
            cmb1.DisplayMember = "NOMBRE_CATEGORIA";
            cmb1.DataSource = dt;

        }

        //Metodo para cargar los datos del Editorial en un combobox
        /// <summary>
        /// Metodo para cargar los datos del Editorial en un combobox
        /// </summary>
        /// <param name="cmb1"></Recibe el combobox en el cual se cargaran los datos del Editorial>
        public void cargarDatoscomboboxEditorial(ComboBox cmb1)
        {

            sconexion.Open();
            SqlCommand cmd = new SqlCommand("Select ID_EDITORIAL, NOMBRE_EDITORIAL FROM Editorial", sconexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sconexion.Close();
            cmb1.DisplayMember = "NOMBRE_EDITORIAL";
            cmb1.ValueMember = "ID_EDITORIAL";
            cmb1.DataSource = dt;

        }


        //Metodo para cargar en un combobox los Tipos de Usuario ya sea Administrador o Usuario
        /// <summary>
        /// Metodo para cargar en un combobox los Tipos de Usuario ya sea Administrador o Usuario
        /// </summary>
        /// <param name="cmb1"></Recibe el combobox en donde se mostraran los tipos de usuarios>
        public void cargarDatoscomboboxTiposdeUsuarios(ComboBox cmb1)
        {

            sconexion.Open();
            SqlCommand cmd = new SqlCommand("Select ID_TIPO, NOMBRE_TIPO FROM Tipo_de_Usuario", sconexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sconexion.Close();
            cmb1.DisplayMember = "NOMBRE_TIPO";
            cmb1.ValueMember = "ID_TIPO";
            cmb1.DataSource = dt;

        }

        //Metodo para cargar solamente los prestamo que cuenta con una fecha de devolucion
        /// <summary>
        /// Metodo para cargar solamente los prestamo que cuenta con una fecha de devolucion
        /// </summary>
        /// <param name="dgv"></Recibe el datagridview en donde se mostraran los prestamos>
        public void cargarDatosPrestDevuelto(DataGridView dgv)
        {
            try
            {
                sconexion.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Prestamo where FECHA_DEVOLUCION is not null", conexion);
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

        
    }
}
