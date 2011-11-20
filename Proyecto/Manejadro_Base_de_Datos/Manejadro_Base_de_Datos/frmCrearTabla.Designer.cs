
﻿namespace Manejadro_Base_de_Datos
{
    partial class frmCrearTabla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtnombrecampo = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.chnotnull = new System.Windows.Forms.CheckBox();
            this.chclave = new System.Windows.Forms.CheckBox();
            this.txtlongitud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarCampo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(508, 162);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(427, 162);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(13, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(56, 9);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(100, 13);
            this.lbNombre.TabIndex = 4;
            this.lbNombre.Text = "Nombre de la Tabla";
            // 
            // txtnombrecampo
            // 
            this.txtnombrecampo.Location = new System.Drawing.Point(12, 81);
            this.txtnombrecampo.Name = "txtnombrecampo";
            this.txtnombrecampo.Size = new System.Drawing.Size(121, 20);
            this.txtnombrecampo.TabIndex = 8;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "int",
            "float",
            "varchar"});
            this.cmbTipo.Location = new System.Drawing.Point(139, 81);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 9;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // chnotnull
            // 
            this.chnotnull.AutoSize = true;
            this.chnotnull.Location = new System.Drawing.Point(408, 83);
            this.chnotnull.Name = "chnotnull";
            this.chnotnull.Size = new System.Drawing.Size(63, 17);
            this.chnotnull.TabIndex = 10;
            this.chnotnull.Text = "No nulo";
            this.chnotnull.UseVisualStyleBackColor = true;
            // 
            // chclave
            // 
            this.chclave.AutoSize = true;
            this.chclave.Location = new System.Drawing.Point(491, 83);
            this.chclave.Name = "chclave";
            this.chclave.Size = new System.Drawing.Size(92, 17);
            this.chclave.TabIndex = 11;
            this.chclave.Text = "Clave primaria";
            this.chclave.UseVisualStyleBackColor = true;
            // 
            // txtlongitud
            // 
            this.txtlongitud.Enabled = false;
            this.txtlongitud.Location = new System.Drawing.Point(280, 81);
            this.txtlongitud.Name = "txtlongitud";
            this.txtlongitud.Size = new System.Drawing.Size(100, 20);
            this.txtlongitud.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre del campo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Longitud";
            // 
            // btnAgregarCampo
            // 
            this.btnAgregarCampo.Location = new System.Drawing.Point(418, 118);
            this.btnAgregarCampo.Name = "btnAgregarCampo";
            this.btnAgregarCampo.Size = new System.Drawing.Size(93, 23);
            this.btnAgregarCampo.TabIndex = 16;
            this.btnAgregarCampo.Text = "Agregar campo";
            this.btnAgregarCampo.UseVisualStyleBackColor = true;
            this.btnAgregarCampo.Click += new System.EventHandler(this.btnAgregarCampo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Debe agregar un campo almenos antes de crear la Tabla.";
            // 
            // frmCrearTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 191);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregarCampo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlongitud);
            this.Controls.Add(this.chclave);
            this.Controls.Add(this.chnotnull);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtnombrecampo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCrearTabla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Tabla";            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtnombrecampo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.CheckBox chnotnull;
        private System.Windows.Forms.CheckBox chclave;
        private System.Windows.Forms.TextBox txtlongitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarCampo;
        private System.Windows.Forms.Label label4;
    }
}
﻿