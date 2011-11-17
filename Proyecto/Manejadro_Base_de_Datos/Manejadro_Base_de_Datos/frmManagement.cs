using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Manejadro_Base_de_Datos;

namespace Manejadro_Base_de_Datos
{
    public partial class frmManagement : Form
    {
        Usuario usuarioActual;       

        public frmManagement(Usuario us)
        {
            InitializeComponent();
            usuarioActual = us;
        }

        private void frmManagement_Load(object sender, EventArgs e)
        {
            //Al cargar se colocan las bases de datos existentes en el comboBox
            actualizarBasesdeDatos();
        }

        //Actualiza las bases de datos del comboBox
        private void actualizarBasesdeDatos()
        {
            DataSet tmpDataSet = usuarioActual.obtenerBasedeDatos();
            cmbBasesDeDatos.DisplayMember = "name";
            cmbBasesDeDatos.DataSource = tmpDataSet.Tables[0];      
        }

        private void frmManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            usuarioActual.cerrarConexion();            
            frmAcceso objfrmAcceso = new frmAcceso();
            objfrmAcceso.Show();            
        }

        private void btnCrearBaseDeDatos_Click(object sender, EventArgs e)
        {
            frmCrearBasedeDatos objfrmCrear = new frmCrearBasedeDatos(usuarioActual);
            objfrmCrear.ShowDialog();
            actualizarBasesdeDatos();
        }

        private void btnEliminarBasedeDatos_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que desea eliminar la base de datos \""+cmbBasesDeDatos.Text+"\" ?","Confirmar",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    usuarioActual.eliminarBasedeDatos(cmbBasesDeDatos.Text);
                    actualizarBasesdeDatos();
                }catch(Exception exc){
                    MessageBox.Show(exc.Message);
                }
                
            }

        }
    }
}
