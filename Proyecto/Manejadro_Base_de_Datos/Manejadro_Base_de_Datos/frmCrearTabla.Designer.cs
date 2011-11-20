namespace Manejadro_Base_de_Datos
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombreTabla = new System.Windows.Forms.TextBox();
            this.BtnCrearTabla = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.DataGridTabla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre de la tabla";
            // 
            // TxtNombreTabla
            // 
            this.TxtNombreTabla.Location = new System.Drawing.Point(138, 29);
            this.TxtNombreTabla.Name = "TxtNombreTabla";
            this.TxtNombreTabla.Size = new System.Drawing.Size(248, 20);
            this.TxtNombreTabla.TabIndex = 7;
            // 
            // BtnCrearTabla
            // 
            this.BtnCrearTabla.Location = new System.Drawing.Point(165, 328);
            this.BtnCrearTabla.Name = "BtnCrearTabla";
            this.BtnCrearTabla.Size = new System.Drawing.Size(98, 31);
            this.BtnCrearTabla.TabIndex = 8;
            this.BtnCrearTabla.Text = "Crear Tabla";
            this.BtnCrearTabla.UseVisualStyleBackColor = true;
            this.BtnCrearTabla.Click += new System.EventHandler(this.BtnCrearTabla_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(336, 328);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(104, 32);
            this.BtnRegresar.TabIndex = 6;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // DataGridTabla
            // 
            this.DataGridTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridTabla.Location = new System.Drawing.Point(23, 83);
            this.DataGridTabla.Name = "DataGridTabla";
            this.DataGridTabla.Size = new System.Drawing.Size(443, 226);
            this.DataGridTabla.TabIndex = 5;
            // 
            // frmCrearTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombreTabla);
            this.Controls.Add(this.BtnCrearTabla);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.DataGridTabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCrearTabla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Tabla";
            this.Load += new System.EventHandler(this.frmCrearTabla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombreTabla;
        private System.Windows.Forms.Button BtnCrearTabla;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.DataGridView DataGridTabla;
    }
}