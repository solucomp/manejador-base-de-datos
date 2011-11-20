
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Manejadro_Base_de_Datos
{
    public partial class frmCrearTabla : Form
    {
        public frmCrearTabla(Usuario u,string dataBase)
        {
            usuarioActual = u;
            BasedeDatos = dataBase;

            InitializeComponent();
        }

        private Usuario usuarioActual;
        private string BasedeDatos;

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioActual.crearTabla(txtNombre.Text,BasedeDatos,listaCampos);
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 2)
            {
                txtlongitud.Enabled = true;
            }
            else
            {
                txtlongitud.Enabled = false;
            }
        }

        List<string> listaCampos = new List<string>();

        private void btnAgregarCampo_Click(object sender, EventArgs e)
        {            
            int longitud;
            
            try
            {
                

                if (chnotnull.Checked == false)
                {
                    if (cmbTipo.SelectedIndex != 2)
                    {
                        listaCampos.Add(txtnombrecampo.Text + " " + cmbTipo.Text);
                    }
                    else
                    {
                        longitud = int.Parse(txtlongitud.Text);
                        listaCampos.Add(txtnombrecampo.Text + " " + cmbTipo.Text + " (" + txtlongitud.Text + ")");
                    }
                }
                else
                {
                    if (cmbTipo.SelectedIndex != 2)
                    {
                        listaCampos.Add(txtnombrecampo.Text + " " + cmbTipo.Text+" NOT NULL");
                    }
                    else
                    {
                        listaCampos.Add(txtnombrecampo.Text + " " + cmbTipo.Text + " (" + txtlongitud.Text + ") NOT NULL");
                    }

                }

                if(chclave.Checked == true)
                {
                    listaCampos.Add("PRIMARY KEY ("+txtnombrecampo.Text+")");
                    chclave.Checked = false;
                    chclave.Visible = false;
                }

                txtnombrecampo.Clear();
                cmbTipo.SelectedIndex = -1;
                txtlongitud.Text = "";
                chnotnull.Checked = false;
                txtnombrecampo.Focus();


            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);                            
            }


        }

        

        
    }
}

