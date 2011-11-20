namespace Manejadro_Base_de_Datos
{
    partial class frmManagement
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
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.btnEliminarBasedeDatos = new System.Windows.Forms.Button();
            this.btnCrearBaseDeDatos = new System.Windows.Forms.Button();
            this.cmbBasesDeDatos = new System.Windows.Forms.ComboBox();
            this.lbBaseDeDatos = new System.Windows.Forms.Label();
            this.listTablas = new System.Windows.Forms.ListBox();
            this.lbTablas = new System.Windows.Forms.Label();
            this.btnCrearTabla = new System.Windows.Forms.Button();
            this.gbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.btnCrearTabla);
            this.gbMenu.Controls.Add(this.btnEliminarBasedeDatos);
            this.gbMenu.Controls.Add(this.btnCrearBaseDeDatos);
            this.gbMenu.Location = new System.Drawing.Point(12, 70);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(211, 482);
            this.gbMenu.TabIndex = 0;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Menú";
            // 
            // btnEliminarBasedeDatos
            // 
            this.btnEliminarBasedeDatos.Location = new System.Drawing.Point(28, 52);
            this.btnEliminarBasedeDatos.Name = "btnEliminarBasedeDatos";
            this.btnEliminarBasedeDatos.Size = new System.Drawing.Size(150, 27);
            this.btnEliminarBasedeDatos.TabIndex = 3;
            this.btnEliminarBasedeDatos.Text = "Eliminar Base de Datos";
            this.btnEliminarBasedeDatos.UseVisualStyleBackColor = true;
            this.btnEliminarBasedeDatos.Click += new System.EventHandler(this.btnEliminarBasedeDatos_Click);
            // 
            // btnCrearBaseDeDatos
            // 
            this.btnCrearBaseDeDatos.Location = new System.Drawing.Point(28, 19);
            this.btnCrearBaseDeDatos.Name = "btnCrearBaseDeDatos";
            this.btnCrearBaseDeDatos.Size = new System.Drawing.Size(150, 27);
            this.btnCrearBaseDeDatos.TabIndex = 0;
            this.btnCrearBaseDeDatos.Text = "Crear Base de Datos";
            this.btnCrearBaseDeDatos.UseVisualStyleBackColor = true;
            this.btnCrearBaseDeDatos.Click += new System.EventHandler(this.btnCrearBaseDeDatos_Click);
            // 
            // cmbBasesDeDatos
            // 
            this.cmbBasesDeDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBasesDeDatos.FormattingEnabled = true;
            this.cmbBasesDeDatos.Location = new System.Drawing.Point(12, 38);
            this.cmbBasesDeDatos.Name = "cmbBasesDeDatos";
            this.cmbBasesDeDatos.Size = new System.Drawing.Size(211, 21);
            this.cmbBasesDeDatos.TabIndex = 1;
            this.cmbBasesDeDatos.SelectedIndexChanged += new System.EventHandler(this.cmbBasesDeDatos_SelectedIndexChanged);
            // 
            // lbBaseDeDatos
            // 
            this.lbBaseDeDatos.AutoSize = true;
            this.lbBaseDeDatos.Location = new System.Drawing.Point(12, 18);
            this.lbBaseDeDatos.Name = "lbBaseDeDatos";
            this.lbBaseDeDatos.Size = new System.Drawing.Size(82, 13);
            this.lbBaseDeDatos.TabIndex = 2;
            this.lbBaseDeDatos.Text = "Bases de Datos";
            // 
            // listTablas
            // 
            this.listTablas.FormattingEnabled = true;
            this.listTablas.Location = new System.Drawing.Point(272, 38);
            this.listTablas.Name = "listTablas";
            this.listTablas.Size = new System.Drawing.Size(191, 95);
            this.listTablas.TabIndex = 3;
            // 
            // lbTablas
            // 
            this.lbTablas.AutoSize = true;
            this.lbTablas.Location = new System.Drawing.Point(269, 18);
            this.lbTablas.Name = "lbTablas";
            this.lbTablas.Size = new System.Drawing.Size(82, 13);
            this.lbTablas.TabIndex = 4;
            this.lbTablas.Text = "Bases de Datos";
            // 
            // btnCrearTabla
            // 
            this.btnCrearTabla.Location = new System.Drawing.Point(28, 85);
            this.btnCrearTabla.Name = "btnCrearTabla";
            this.btnCrearTabla.Size = new System.Drawing.Size(150, 27);
            this.btnCrearTabla.TabIndex = 4;
            this.btnCrearTabla.Text = "Crear Tabla";
            this.btnCrearTabla.UseVisualStyleBackColor = true;
            this.btnCrearTabla.Click += new System.EventHandler(this.btnCrearTabla_Click);
            // 
            // frmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 564);
            this.Controls.Add(this.lbTablas);
            this.Controls.Add(this.listTablas);
            this.Controls.Add(this.lbBaseDeDatos);
            this.Controls.Add(this.cmbBasesDeDatos);
            this.Controls.Add(this.gbMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManagement_FormClosing);
            this.Load += new System.EventHandler(this.frmManagement_Load);
            this.gbMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Button btnCrearBaseDeDatos;
        private System.Windows.Forms.ComboBox cmbBasesDeDatos;
        private System.Windows.Forms.Label lbBaseDeDatos;
        private System.Windows.Forms.Button btnEliminarBasedeDatos;
        private System.Windows.Forms.ListBox listTablas;
        private System.Windows.Forms.Label lbTablas;
        private System.Windows.Forms.Button btnCrearTabla;
    }
}