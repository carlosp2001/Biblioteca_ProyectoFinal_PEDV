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
