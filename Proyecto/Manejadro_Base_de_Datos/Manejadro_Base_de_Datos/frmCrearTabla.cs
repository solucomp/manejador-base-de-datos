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
    public partial class frmCrearTabla : Form
    {
        Usuario usuario_actual;
        string campos, basededatos;

        public frmCrearTabla(Usuario us, string BD)
        {
            InitializeComponent();
            usuario_actual = us;
            basededatos = BD;
        }

        private void frmCrearTabla_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn dgtxtbox = new DataGridViewTextBoxColumn();
            DataGridViewComboBoxColumn dgcmb = new DataGridViewComboBoxColumn();
            DataGridViewCheckBoxColumn dgchkboxnull = new DataGridViewCheckBoxColumn(false);
            DataGridViewCheckBoxColumn dgchkboxpk = new DataGridViewCheckBoxColumn(false);

            dgcmb.Items.Add("int");
            dgcmb.Items.Add("float");
            dgcmb.Items.Add("bit");
            dgcmb.Items.Add("varchar(MAX)");

            DataGridTabla.Columns.AddRange(new DataGridViewColumn[]{
            dgtxtbox,dgcmb,dgchkboxpk,dgchkboxnull});

            dgtxtbox.HeaderText = "Campo";
            dgcmb.HeaderText = "Tipo";
            dgchkboxpk.HeaderText = "PK";
            dgchkboxnull.HeaderText = "NULL";
        }

        private void BtnCrearTabla_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGridTabla.Rows.Count - 1; i++)
            {
                campos = campos + DataGridTabla.Rows[i].Cells[0].Value.ToString() + " ";
                campos = campos + DataGridTabla.Rows[i].Cells[1].Value.ToString() + " ";

                if (DataGridTabla.Rows[i].Cells[2].Value != null)
                    campos = campos + "Primary Key ";

                if (DataGridTabla.Rows[i].Cells[3].Value != null)
                    campos = campos + "not null";

                if (i < DataGridTabla.Rows.Count - 1)
                    campos = campos + ",";
            }

            try
            {
                usuario_actual.crearTablas(basededatos, TxtNombreTabla.Text, campos);

                MessageBox.Show("Tabla creada exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
