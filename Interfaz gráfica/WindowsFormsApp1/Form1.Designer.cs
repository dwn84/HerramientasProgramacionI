namespace WindowsFormsApp1
{
    partial class frmVentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbColores = new System.Windows.Forms.GroupBox();
            this.rdbAzul = new System.Windows.Forms.RadioButton();
            this.rdbRojo = new System.Windows.Forms.RadioButton();
            this.rdbFucsia = new System.Windows.Forms.RadioButton();
            this.rdbNegro = new System.Windows.Forms.RadioButton();
            this.gpbColores.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbColores
            // 
            this.gpbColores.Controls.Add(this.rdbAzul);
            this.gpbColores.Controls.Add(this.rdbRojo);
            this.gpbColores.Controls.Add(this.rdbFucsia);
            this.gpbColores.Controls.Add(this.rdbNegro);
            this.gpbColores.Location = new System.Drawing.Point(54, 28);
            this.gpbColores.Name = "gpbColores";
            this.gpbColores.Size = new System.Drawing.Size(200, 145);
            this.gpbColores.TabIndex = 0;
            this.gpbColores.TabStop = false;
            this.gpbColores.Text = "Seleccione un color de fondo";
            // 
            // rdbAzul
            // 
            this.rdbAzul.AutoSize = true;
            this.rdbAzul.Location = new System.Drawing.Point(44, 102);
            this.rdbAzul.Name = "rdbAzul";
            this.rdbAzul.Size = new System.Drawing.Size(45, 17);
            this.rdbAzul.TabIndex = 3;
            this.rdbAzul.TabStop = true;
            this.rdbAzul.Text = "Azul";
            this.rdbAzul.UseVisualStyleBackColor = true;
            this.rdbAzul.CheckedChanged += new System.EventHandler(this.rdbAzul_CheckedChanged);
            // 
            // rdbRojo
            // 
            this.rdbRojo.AutoSize = true;
            this.rdbRojo.Location = new System.Drawing.Point(44, 79);
            this.rdbRojo.Name = "rdbRojo";
            this.rdbRojo.Size = new System.Drawing.Size(47, 17);
            this.rdbRojo.TabIndex = 2;
            this.rdbRojo.TabStop = true;
            this.rdbRojo.Text = "Rojo";
            this.rdbRojo.UseVisualStyleBackColor = true;
            this.rdbRojo.CheckedChanged += new System.EventHandler(this.rdbRojo_CheckedChanged);
            // 
            // rdbFucsia
            // 
            this.rdbFucsia.AutoSize = true;
            this.rdbFucsia.Location = new System.Drawing.Point(44, 56);
            this.rdbFucsia.Name = "rdbFucsia";
            this.rdbFucsia.Size = new System.Drawing.Size(56, 17);
            this.rdbFucsia.TabIndex = 1;
            this.rdbFucsia.TabStop = true;
            this.rdbFucsia.Text = "Fucsia";
            this.rdbFucsia.UseVisualStyleBackColor = true;
            this.rdbFucsia.CheckedChanged += new System.EventHandler(this.rdbFucsia_CheckedChanged);
            // 
            // rdbNegro
            // 
            this.rdbNegro.AutoSize = true;
            this.rdbNegro.Location = new System.Drawing.Point(44, 33);
            this.rdbNegro.Name = "rdbNegro";
            this.rdbNegro.Size = new System.Drawing.Size(54, 17);
            this.rdbNegro.TabIndex = 0;
            this.rdbNegro.TabStop = true;
            this.rdbNegro.Text = "Negro";
            this.rdbNegro.UseVisualStyleBackColor = true;
            this.rdbNegro.CheckedChanged += new System.EventHandler(this.rdbNegro_CheckedChanged);
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 199);
            this.Controls.Add(this.gpbColores);
            this.Name = "frmVentanaPrincipal";
            this.Text = "Configuración de colores";
            this.Load += new System.EventHandler(this.frmVentanaPrincipal_Load);
            this.gpbColores.ResumeLayout(false);
            this.gpbColores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbColores;
        private System.Windows.Forms.RadioButton rdbAzul;
        private System.Windows.Forms.RadioButton rdbRojo;
        private System.Windows.Forms.RadioButton rdbFucsia;
        private System.Windows.Forms.RadioButton rdbNegro;
    }
}

