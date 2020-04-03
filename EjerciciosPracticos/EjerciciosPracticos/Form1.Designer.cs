namespace EjerciciosPracticos
{
    partial class Form1
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
            this.lblDato = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.lblListaInicial = new System.Windows.Forms.Label();
            this.lblInvertidos = new System.Windows.Forms.Label();
            this.lstInvertidos = new System.Windows.Forms.ListBox();
            this.btnInvertir = new System.Windows.Forms.Button();
            this.btnCapicua = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.Location = new System.Drawing.Point(48, 44);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(84, 13);
            this.lblDato.TabIndex = 0;
            this.lblDato.Text = "Ingrese un dato:";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(138, 41);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 20);
            this.txtDato.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(51, 87);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(187, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Location = new System.Drawing.Point(286, 67);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(120, 186);
            this.lstDatos.TabIndex = 3;
            // 
            // lblListaInicial
            // 
            this.lblListaInicial.AutoSize = true;
            this.lblListaInicial.Location = new System.Drawing.Point(283, 41);
            this.lblListaInicial.Name = "lblListaInicial";
            this.lblListaInicial.Size = new System.Drawing.Size(82, 13);
            this.lblListaInicial.TabIndex = 4;
            this.lblListaInicial.Text = "Datos originales";
            // 
            // lblInvertidos
            // 
            this.lblInvertidos.AutoSize = true;
            this.lblInvertidos.Location = new System.Drawing.Point(428, 41);
            this.lblInvertidos.Name = "lblInvertidos";
            this.lblInvertidos.Size = new System.Drawing.Size(83, 13);
            this.lblInvertidos.TabIndex = 6;
            this.lblInvertidos.Text = "Datos invertidos";
            // 
            // lstInvertidos
            // 
            this.lstInvertidos.FormattingEnabled = true;
            this.lstInvertidos.Location = new System.Drawing.Point(431, 67);
            this.lstInvertidos.Name = "lstInvertidos";
            this.lstInvertidos.Size = new System.Drawing.Size(120, 186);
            this.lstInvertidos.TabIndex = 5;
            // 
            // btnInvertir
            // 
            this.btnInvertir.Location = new System.Drawing.Point(51, 132);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(187, 23);
            this.btnInvertir.TabIndex = 7;
            this.btnInvertir.Text = "Invertir datos";
            this.btnInvertir.UseVisualStyleBackColor = true;
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
            // 
            // btnCapicua
            // 
            this.btnCapicua.Location = new System.Drawing.Point(51, 179);
            this.btnCapicua.Name = "btnCapicua";
            this.btnCapicua.Size = new System.Drawing.Size(187, 23);
            this.btnCapicua.TabIndex = 8;
            this.btnCapicua.Text = "Validar Capicua";
            this.btnCapicua.UseVisualStyleBackColor = true;
            this.btnCapicua.Click += new System.EventHandler(this.btnCapicua_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(51, 219);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(187, 23);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borra datos";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 333);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCapicua);
            this.Controls.Add(this.btnInvertir);
            this.Controls.Add(this.lblInvertidos);
            this.Controls.Add(this.lstInvertidos);
            this.Controls.Add(this.lblListaInicial);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.lblDato);
            this.Name = "Form1";
            this.Text = "Inversor de datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDato;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.Label lblListaInicial;
        private System.Windows.Forms.Label lblInvertidos;
        private System.Windows.Forms.ListBox lstInvertidos;
        private System.Windows.Forms.Button btnInvertir;
        private System.Windows.Forms.Button btnCapicua;
        private System.Windows.Forms.Button btnBorrar;
    }
}

