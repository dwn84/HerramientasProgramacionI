namespace EjerciciosPracticos
{
    partial class Form2
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
            this.lblListaPedidos = new System.Windows.Forms.Label();
            this.lstPedidos = new System.Windows.Forms.ListBox();
            this.lblListaExistentes = new System.Windows.Forms.Label();
            this.lstExistentes = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtExistentes = new System.Windows.Forms.TextBox();
            this.lblExistente = new System.Windows.Forms.Label();
            this.txtPedidos = new System.Windows.Forms.TextBox();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblComprar = new System.Windows.Forms.Label();
            this.lstComprar = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblSumaCompras = new System.Windows.Forms.Label();
            this.lblSumaPedidos = new System.Windows.Forms.Label();
            this.lblSumaProductos = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblProm = new System.Windows.Forms.Label();
            this.lblPromCompras = new System.Windows.Forms.Label();
            this.lblPromPedidos = new System.Windows.Forms.Label();
            this.lblPromProductos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblListaPedidos
            // 
            this.lblListaPedidos.AutoSize = true;
            this.lblListaPedidos.Location = new System.Drawing.Point(451, 31);
            this.lblListaPedidos.Name = "lblListaPedidos";
            this.lblListaPedidos.Size = new System.Drawing.Size(89, 13);
            this.lblListaPedidos.TabIndex = 16;
            this.lblListaPedidos.Text = "Cantidad pedidas";
            // 
            // lstPedidos
            // 
            this.lstPedidos.FormattingEnabled = true;
            this.lstPedidos.Location = new System.Drawing.Point(454, 57);
            this.lstPedidos.Name = "lstPedidos";
            this.lstPedidos.Size = new System.Drawing.Size(120, 186);
            this.lstPedidos.TabIndex = 15;
            this.lstPedidos.Click += new System.EventHandler(this.lstPedidos_Click);
            // 
            // lblListaExistentes
            // 
            this.lblListaExistentes.AutoSize = true;
            this.lblListaExistentes.Location = new System.Drawing.Point(306, 31);
            this.lblListaExistentes.Name = "lblListaExistentes";
            this.lblListaExistentes.Size = new System.Drawing.Size(55, 13);
            this.lblListaExistentes.TabIndex = 14;
            this.lblListaExistentes.Text = "Productos";
            // 
            // lstExistentes
            // 
            this.lstExistentes.FormattingEnabled = true;
            this.lstExistentes.Location = new System.Drawing.Point(309, 57);
            this.lstExistentes.Name = "lstExistentes";
            this.lstExistentes.Size = new System.Drawing.Size(120, 186);
            this.lstExistentes.TabIndex = 13;
            this.lstExistentes.Click += new System.EventHandler(this.lstExistentes_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(21, 127);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(187, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtExistentes
            // 
            this.txtExistentes.Location = new System.Drawing.Point(183, 27);
            this.txtExistentes.Name = "txtExistentes";
            this.txtExistentes.Size = new System.Drawing.Size(100, 20);
            this.txtExistentes.TabIndex = 11;
            // 
            // lblExistente
            // 
            this.lblExistente.AutoSize = true;
            this.lblExistente.Location = new System.Drawing.Point(18, 30);
            this.lblExistente.Name = "lblExistente";
            this.lblExistente.Size = new System.Drawing.Size(159, 13);
            this.lblExistente.TabIndex = 10;
            this.lblExistente.Text = "Cantidad existente de productos";
            // 
            // txtPedidos
            // 
            this.txtPedidos.Location = new System.Drawing.Point(183, 80);
            this.txtPedidos.Name = "txtPedidos";
            this.txtPedidos.Size = new System.Drawing.Size(100, 20);
            this.txtPedidos.TabIndex = 18;
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Location = new System.Drawing.Point(18, 80);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(154, 13);
            this.lblPedidos.TabIndex = 17;
            this.lblPedidos.Text = "Cantidad de productos pedidos";
            // 
            // lblComprar
            // 
            this.lblComprar.AutoSize = true;
            this.lblComprar.Location = new System.Drawing.Point(591, 31);
            this.lblComprar.Name = "lblComprar";
            this.lblComprar.Size = new System.Drawing.Size(108, 13);
            this.lblComprar.TabIndex = 20;
            this.lblComprar.Text = "Cantidad por comprar";
            // 
            // lstComprar
            // 
            this.lstComprar.FormattingEnabled = true;
            this.lstComprar.Location = new System.Drawing.Point(594, 57);
            this.lstComprar.Name = "lstComprar";
            this.lstComprar.Size = new System.Drawing.Size(120, 186);
            this.lstComprar.TabIndex = 19;
            this.lstComprar.Click += new System.EventHandler(this.lstComprar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(21, 173);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(187, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblSumaCompras
            // 
            this.lblSumaCompras.AutoSize = true;
            this.lblSumaCompras.Location = new System.Drawing.Point(701, 273);
            this.lblSumaCompras.Name = "lblSumaCompras";
            this.lblSumaCompras.Size = new System.Drawing.Size(13, 13);
            this.lblSumaCompras.TabIndex = 24;
            this.lblSumaCompras.Text = "0";
            // 
            // lblSumaPedidos
            // 
            this.lblSumaPedidos.AutoSize = true;
            this.lblSumaPedidos.Location = new System.Drawing.Point(561, 273);
            this.lblSumaPedidos.Name = "lblSumaPedidos";
            this.lblSumaPedidos.Size = new System.Drawing.Size(13, 13);
            this.lblSumaPedidos.TabIndex = 23;
            this.lblSumaPedidos.Text = "0";
            this.lblSumaPedidos.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSumaProductos
            // 
            this.lblSumaProductos.AutoSize = true;
            this.lblSumaProductos.Location = new System.Drawing.Point(416, 273);
            this.lblSumaProductos.Name = "lblSumaProductos";
            this.lblSumaProductos.Size = new System.Drawing.Size(13, 13);
            this.lblSumaProductos.TabIndex = 22;
            this.lblSumaProductos.Text = "0";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(180, 273);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(73, 13);
            this.lblSum.TabIndex = 25;
            this.lblSum.Text = "Sumas totales";
            // 
            // lblProm
            // 
            this.lblProm.AutoSize = true;
            this.lblProm.Location = new System.Drawing.Point(180, 297);
            this.lblProm.Name = "lblProm";
            this.lblProm.Size = new System.Drawing.Size(59, 13);
            this.lblProm.TabIndex = 29;
            this.lblProm.Text = "Promedios ";
            // 
            // lblPromCompras
            // 
            this.lblPromCompras.AutoSize = true;
            this.lblPromCompras.Location = new System.Drawing.Point(701, 297);
            this.lblPromCompras.Name = "lblPromCompras";
            this.lblPromCompras.Size = new System.Drawing.Size(13, 13);
            this.lblPromCompras.TabIndex = 28;
            this.lblPromCompras.Text = "0";
            // 
            // lblPromPedidos
            // 
            this.lblPromPedidos.AutoSize = true;
            this.lblPromPedidos.Location = new System.Drawing.Point(561, 297);
            this.lblPromPedidos.Name = "lblPromPedidos";
            this.lblPromPedidos.Size = new System.Drawing.Size(13, 13);
            this.lblPromPedidos.TabIndex = 27;
            this.lblPromPedidos.Text = "0";
            // 
            // lblPromProductos
            // 
            this.lblPromProductos.AutoSize = true;
            this.lblPromProductos.Location = new System.Drawing.Point(416, 297);
            this.lblPromProductos.Name = "lblPromProductos";
            this.lblPromProductos.Size = new System.Drawing.Size(13, 13);
            this.lblPromProductos.TabIndex = 26;
            this.lblPromProductos.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 336);
            this.Controls.Add(this.lblProm);
            this.Controls.Add(this.lblPromCompras);
            this.Controls.Add(this.lblPromPedidos);
            this.Controls.Add(this.lblPromProductos);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblSumaCompras);
            this.Controls.Add(this.lblSumaPedidos);
            this.Controls.Add(this.lblSumaProductos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblComprar);
            this.Controls.Add(this.lstComprar);
            this.Controls.Add(this.txtPedidos);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.lblListaPedidos);
            this.Controls.Add(this.lstPedidos);
            this.Controls.Add(this.lblListaExistentes);
            this.Controls.Add(this.lstExistentes);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtExistentes);
            this.Controls.Add(this.lblExistente);
            this.Name = "Form2";
            this.Text = "Control productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListaPedidos;
        private System.Windows.Forms.ListBox lstPedidos;
        private System.Windows.Forms.Label lblListaExistentes;
        private System.Windows.Forms.ListBox lstExistentes;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblExistente;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblComprar;
        private System.Windows.Forms.ListBox lstComprar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblSumaCompras;
        private System.Windows.Forms.Label lblSumaPedidos;
        private System.Windows.Forms.Label lblSumaProductos;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblProm;
        private System.Windows.Forms.Label lblPromCompras;
        private System.Windows.Forms.Label lblPromPedidos;
        private System.Windows.Forms.Label lblPromProductos;
        public System.Windows.Forms.TextBox txtExistentes;
        public System.Windows.Forms.TextBox txtPedidos;
    }
}