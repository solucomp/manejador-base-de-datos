using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Manejadro_Base_de_Datos
{
    public partial class frmAcceso : Form
    {
        public frmAcceso()
        {
            InitializeComponent();
        }
        
        //Datos privados
        private Usuario currentUser;
        //Datos estáticos públicos de uso general para otras clases.


        //Acción del botón cerrar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Termina la aplicacion
            Application.Exit();
        }

        //Funcion click del boton de coneccion
        private void btnConectar_Click(object sender, EventArgs e)
        {
            //Indica el tipo de coneccion seleccionado
            int Tipo=-1;
            //Verifica que los campos contengan informacion
            if(txtUsuario.Text!="" && txtPassword.Text!="")
            {
                Tipo = verificarTipo();
                if (Tipo != -1)
                {
                    try
                    {
                        frmManagement objfrmManagement;
                        currentUser = new Usuario(txtUsuario.Text, txtPassword.Text, Tipo);
                        objfrmManagement = new frmManagement(currentUser);
                        objfrmManagement.Show();                        
                        this.Hide();
                        
                    }
                    catch(Exception exc){
                        MessageBox.Show(exc.Message);
                    }
                }//if
            }
        }

        //Regresa el tipo de servidor o archivo seleccionado necesario para la conexion
        private int verificarTipo()
        {
            if (rdSQLServer.Checked)
            {
                return (int)Usuario.enumTipo.SQLServer;
            }
            if (rdMySQL.Checked)
            {
                return (int)Usuario.enumTipo.MySQL;
            }
            if (rdSQLite.Checked)
            {
                return (int)Usuario.enumTipo.SQLite;
            }
            if (rdAccess.Checked)
            {
                return (int)Usuario.enumTipo.Access;
            }
            return -1;
        }

        //Establece el radioButton de sqlserver en verdadero al cargar el formulario
        private void frmAcceso_Load(object sender, EventArgs e)
        {
            rdSQLServer.Checked = true;
        }

        private void frmAcceso_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
