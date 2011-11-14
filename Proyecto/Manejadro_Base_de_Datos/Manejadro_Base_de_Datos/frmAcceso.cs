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



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            int Tipo=-1;
            if(cmbUsuario.Text!="" && txtPassword.Text!="")
            {
                Tipo = verificarTipo();
                if (Tipo != -1)
                {
                    try
                    {
                        currentUser = new Usuario(cmbUsuario.Text, txtPassword.Text, Tipo);
                    }
                    catch(SqlException exc){
                        MessageBox.Show(exc.Message);
                    }
                }//if
            }
        }

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

        private void frmAcceso_Load(object sender, EventArgs e)
        {
            rdSQLServer.Checked = true;
        }
    }
}
