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
    public partial class FrmUsuario : FrmAdministrador
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btn_Admi_Click(object sender, EventArgs e)
        {

        }
        FrmLector frmLector1 = new FrmLector("Empleado");
        private void btn_Empleado_Click(object sender, EventArgs e)
        {

            frmLector.ShowDialog();
                       
            
            
        }

        
    }
}
