using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Manejadro_Base_de_Datos
{
    public partial class frmCrearBasedeDatos : Form
    {
        private Usuario usuarioActual;

        public frmCrearBasedeDatos(Usuario u)
        {
            usuarioActual = u;
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioActual.crearBasedeDatos(txtNombre.Text);
                this.Close();
            }
            catch(Exception exc){
                MessageBox.Show(exc.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
