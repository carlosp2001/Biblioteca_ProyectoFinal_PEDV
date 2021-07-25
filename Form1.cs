using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca
{
    /// <summary>
    ///Formulario para realizar el login del usuario se detecta automaticamente si es admin o empleado
    /// </summary>
    public partial class Frm_Login_Empleado : Form
    {
        public Frm_Login_Empleado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        clsConexion BD = new clsConexion();

        private void Frm_Login_Empleado_Load(object sender, EventArgs e)
        {
            BD.abrir();
            


        }
        //Boton que realiza la accion de Ingresar al sistema
        /// <summary>
        /// Boton que realiza la accion de Ingresar al sistema
        /// </summary>
        /// <param name="usuario"></Recibe el usuario que la persona proporcione y luego se verifica si existe>
        /// <param name="contrasena"></Recibe la contraseña que persona proporcione y luego se verifica si existe>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            string usuario = txt_Usuario_Empl.Text;
            string contrasena = txt_Contraseña_Empl.Text;
            int login1=BD.login(usuario, contrasena);
            if (login1 == 1) 
            {
                this.Hide();
                FrmAdministrador frmAdministrador = new FrmAdministrador();
                frmAdministrador.Show();   
            }
            else if(login1==2){
                this.Hide();
                FrmEmpleado frmEmpleado = new FrmEmpleado();
                frmEmpleado.Show();
            }
            
        }

        //Metodo para ocultar la contraseña o mostrarla mediante un checkbox
        /// <summary>
        /// Metodo para ocultar la contraseña o mostrarla mediante un checkbox
        /// </summary>
        /// <param name="PasswordChar"></Define que caracter se mostrara en vez de la contraseña>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txt_Contraseña_Empl.PasswordChar = '\0';
            }
            else
            {
                txt_Contraseña_Empl.PasswordChar = '*';
                
            }
        }

        private void Frm_Login_Empleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
