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

        //int indice seleccionado actualmente del combobox
        int BasedeDatosActual = 0;
        bool flag = false;

        private void frmManagement_Load(object sender, EventArgs e)
        {
            //Al cargar se colocan las bases de datos existentes en el comboBox
            actualizarBasesdeDatos();
            BasedeDatosActual = cmbBasesDeDatos.SelectedIndex;            
        }

        //Actualiza las bases de datos del comboBox
        private void actualizarBasesdeDatos()
        {
            flag = true;

            DataSet tmpDataSetDataBases = usuarioActual.obtenerBasedeDatos();
            cmbBasesDeDatos.DisplayMember = "name";
            cmbBasesDeDatos.DataSource = tmpDataSetDataBases.Tables[0];

            if(cmbBasesDeDatos.Items.Count-1 >= BasedeDatosActual){
                cmbBasesDeDatos.SelectedIndex = BasedeDatosActual;
            }
            else{
                cmbBasesDeDatos.SelectedIndex = BasedeDatosActual - 1 ;
            }            

            DataSet tmpDataSetTables = usuarioActual.obtenerTablas(cmbBasesDeDatos.Text);
            listTablas.DisplayMember = "name";
            listTablas.DataSource = tmpDataSetTables.Tables[0];            

            flag = false;   
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

        private void cmbBasesDeDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag == false)
            {
                BasedeDatosActual = cmbBasesDeDatos.SelectedIndex;
                actualizarBasesdeDatos();          
            }          
        }


        private void btnCrearTabla_Click(object sender, EventArgs e)
        {
            frmCrearTabla objfrmCrear = new frmCrearTabla(usuarioActual,cmbBasesDeDatos.Text);
            objfrmCrear.ShowDialog();
            actualizarBasesdeDatos();
        }

        private void btnEliminarTabla_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar la tabla \"" + listTablas.Text + "\" ?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    usuarioActual.eliminarTabla(cmbBasesDeDatos.Text,listTablas.Text);
                    actualizarBasesdeDatos();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }

            }

        }
        

    }
}
