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
    //Formulario para elegir que accion desea realizar el administrador
    /// <summary>
    ///Formulario para elegir que accion desea realizar el administrador
    /// </summary>
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

        //Boton para abrir y crear la instancia del formulario de usuarios del Sistema
        /// <summary>
        /// Boton para abrir y crear la instancia del formulario de usuarios del Sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Admi_UsuarioSist_Click(object sender, EventArgs e)
        {
            Frm_Admi_Usuario frm_Admi_Usuario = new Frm_Admi_Usuario();
            frm_Admi_Usuario.ShowDialog();
        }

        //Boton para abrir y crear la instancia del formulario de autores
        /// <summary>
        /// Boton para abrir y crear la instancia del formulario de autores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Admi_Autor_Click(object sender, EventArgs e)
        {
            FrmAutorTable frmAutor = new FrmAutorTable();
            frmAutor.ShowDialog();
        }
        FrmCategoria frmCategoria = new FrmCategoria();


        //Boton para abrir y crear la instancia del formulario de Categorias de Libros
        /// <summary>
        /// Boton para abrir y crear la instancia del formulario de Categorias de Libros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Admi_Cat_Click(object sender, EventArgs e)
        {
            frmCategoria.ShowDialog();
            
        }
        FrmEditorial frmEditorial = new FrmEditorial();

        //Boton para abrir y crear la instancia del formulario de Editoriales
        /// <summary>
        /// Boton para abrir y crear la instancia del formulario de Editoriales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Admi_Edi_Click(object sender, EventArgs e)
        {
            frmEditorial.ShowDialog();
        }


        FrmLibro frmLibro = new FrmLibro();
        //Boton para abrir y crear la instancia del formulario de Libros
        /// <summary>
        /// Boton para abrir y crear la instancia del formulario de Libros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Admi_Libro_Click(object sender, EventArgs e)
        {
            frmLibro.ShowDialog();
        }


        protected FrmLector frmLector = new FrmLector("Administrador");
        //Boton para abrir y crear la instancia del formulario de Usuario Lector y envia el tipo de usuario que esta abriendo 
        //el formulario
        /// <summary>
        /// Boton para abrir y crear la instancia del formulario de Usuario Lector y envia el tipo de usuario que esta abriendo 
        /// el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Admi_Lector_Click(object sender, EventArgs e)
        {
            frmLector.ShowDialog();

        }

        private void FrmAdministrador_Load(object sender, EventArgs e)
        {

        }

        ReporteMenu reporteMenu = new ReporteMenu();
        //Boton para abrir y crear la instancia del formulario menu de Generar reportes
        /// <summary>
        /// Boton para abrir y crear la instancia del formulario menu de Generar reportes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_generar_reporte_Click(object sender, EventArgs e)
        {
            reporteMenu.ShowDialog();
        }
    }
}
