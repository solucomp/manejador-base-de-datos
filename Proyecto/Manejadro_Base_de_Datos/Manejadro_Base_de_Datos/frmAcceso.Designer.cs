namespace Manejadro_Base_de_Datos
{
    partial class frmAcceso
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAcceso = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rdSQLServer = new System.Windows.Forms.RadioButton();
            this.rdMySQL = new System.Windows.Forms.RadioButton();
            this.rdSQLite = new System.Windows.Forms.RadioButton();
            this.rdAccess = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbAcceso
            // 
            this.lbAcceso.AutoSize = true;
            this.lbAcceso.Location = new System.Drawing.Point(200, 9);
            this.lbAcceso.Name = "lbAcceso";
            this.lbAcceso.Size = new System.Drawing.Size(92, 13);
            this.lbAcceso.TabIndex = 0;
            this.lbAcceso.Text = "Acceso al sistema";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Items.AddRange(new object[] {
            "SA"});
            this.cmbUsuario.Location = new System.Drawing.Point(220, 42);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(160, 21);
            this.cmbUsuario.TabIndex = 1;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(147, 45);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbUsuario.TabIndex = 2;
            this.lbUsuario.Text = "Usuario";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(147, 83);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(61, 13);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(220, 76);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(158, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(133, 285);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(303, 285);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rdSQLServer
            // 
            this.rdSQLServer.AutoSize = true;
            this.rdSQLServer.Location = new System.Drawing.Point(164, 152);
            this.rdSQLServer.Name = "rdSQLServer";
            this.rdSQLServer.Size = new System.Drawing.Size(80, 17);
            this.rdSQLServer.TabIndex = 7;
            this.rdSQLServer.TabStop = true;
            this.rdSQLServer.Text = "SQL Server";
            this.rdSQLServer.UseVisualStyleBackColor = true;
            // 
            // rdMySQL
            // 
            this.rdMySQL.AutoSize = true;
            this.rdMySQL.Location = new System.Drawing.Point(164, 175);
            this.rdMySQL.Name = "rdMySQL";
            this.rdMySQL.Size = new System.Drawing.Size(60, 17);
            this.rdMySQL.TabIndex = 8;
            this.rdMySQL.TabStop = true;
            this.rdMySQL.Text = "MySQL";
            this.rdMySQL.UseVisualStyleBackColor = true;
            // 
            // rdSQLite
            // 
            this.rdSQLite.AutoSize = true;
            this.rdSQLite.Location = new System.Drawing.Point(164, 198);
            this.rdSQLite.Name = "rdSQLite";
            this.rdSQLite.Size = new System.Drawing.Size(57, 17);
            this.rdSQLite.TabIndex = 9;
            this.rdSQLite.TabStop = true;
            this.rdSQLite.Text = "SQLite";
            this.rdSQLite.UseVisualStyleBackColor = true;
            // 
            // rdAccess
            // 
            this.rdAccess.AutoSize = true;
            this.rdAccess.Location = new System.Drawing.Point(164, 221);
            this.rdAccess.Name = "rdAccess";
            this.rdAccess.Size = new System.Drawing.Size(60, 17);
            this.rdAccess.TabIndex = 10;
            this.rdAccess.TabStop = true;
            this.rdAccess.Text = "Access";
            this.rdAccess.UseVisualStyleBackColor = true;
            // 
            // frmAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 364);
            this.Controls.Add(this.rdAccess);
            this.Controls.Add(this.rdSQLite);
            this.Controls.Add(this.rdMySQL);
            this.Controls.Add(this.rdSQLServer);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.lbAcceso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso";
            this.Load += new System.EventHandler(this.frmAcceso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAcceso;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rdSQLServer;
        private System.Windows.Forms.RadioButton rdMySQL;
        private System.Windows.Forms.RadioButton rdSQLite;
        private System.Windows.Forms.RadioButton rdAccess;
    }
}

