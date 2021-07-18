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
    public partial class FrmAdministrador : Form
    {
        public FrmAdministrador()
        {
            InitializeComponent();
        }
        Frm_Login_Empleado frm_Login_Empleado = new Frm_Login_Empleado();

        private void FrmAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_Login_Empleado.Show();

        }

        private void btn_Admi_UsuarioSist_Click(object sender, EventArgs e)
        {
            Frm_Admi_Usuario frm_Admi_Usuario = new Frm_Admi_Usuario();
            frm_Admi_Usuario.ShowDialog();
        }

        private void btn_Admi_Autor_Click(object sender, EventArgs e)
        {
            FrmAutor frmAutor = new FrmAutor();
        }
    }
}
