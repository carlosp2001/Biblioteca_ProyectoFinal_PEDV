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
            BD.login(usuario, contrasena);
        }
    }
}
