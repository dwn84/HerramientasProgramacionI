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
            this.SuspendLayout();
            // 
            // lblListaPedidos
            // 
            this.lblListaPedidos.AutoSize = true;
            this.lblListaPedidos.Location = new System.Drawing.Point(455, 98);
            this.lblListaPedidos.Name = "lblListaPedidos";
            this.lblListaPedidos.Size = new System.Drawing.Size(89, 13);
            this.lblListaPedidos.TabIndex = 16;
            this.lblListaPedidos.Text = "Cantidad pedidas";
            // 
            // lstPedidos
            // 
            this.lstPedidos.FormattingEnabled = true;
            this.lstPedidos.Location = new System.Drawing.Point(458, 124);
            this.lstPedidos.Name = "lstPedidos";
            this.lstPedidos.Size = new System.Drawing.Size(120, 186);
            this.lstPedidos.TabIndex = 15;
            // 
            // lblListaExistentes
            // 
            this.lblListaExistentes.AutoSize = true;
            this.lblListaExistentes.Location = new System.Drawing.Point(310, 98);
            this.lblListaExistentes.Name = "lblListaExistentes";
            this.lblListaExistentes.Size = new System.Drawing.Size(55, 13);
            this.lblListaExistentes.TabIndex = 14;
            this.lblListaExistentes.Text = "Productos";
            // 
            // lstExistentes
            // 
            this.lstExistentes.FormattingEnabled = true;
            this.lstExistentes.Location = new System.Drawing.Point(313, 124);
            this.lstExistentes.Name = "lstExistentes";
            this.lstExistentes.Size = new System.Drawing.Size(120, 186);
            this.lstExistentes.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(25, 194);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(187, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtExistentes
            // 
            this.txtExistentes.Location = new System.Drawing.Point(187, 94);
            this.txtExistentes.Name = "txtExistentes";
            this.txtExistentes.Size = new System.Drawing.Size(100, 20);
            this.txtExistentes.TabIndex = 11;
            // 
            // lblExistente
            // 
            this.lblExistente.AutoSize = true;
            this.lblExistente.Location = new System.Drawing.Point(22, 97);
            this.lblExistente.Name = "lblExistente";
            this.lblExistente.Size = new System.Drawing.Size(159, 13);
            this.lblExistente.TabIndex = 10;
            this.lblExistente.Text = "Cantidad existente de productos";
            // 
            // txtPedidos
            // 
            this.txtPedidos.Location = new System.Drawing.Point(187, 147);
            this.txtPedidos.Name = "txtPedidos";
            this.txtPedidos.Size = new System.Drawing.Size(100, 20);
            this.txtPedidos.TabIndex = 18;
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Location = new System.Drawing.Point(22, 147);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(154, 13);
            this.lblPedidos.TabIndex = 17;
            this.lblPedidos.Text = "Cantidad de productos pedidos";
            // 
            // lblComprar
            // 
            this.lblComprar.AutoSize = true;
            this.lblComprar.Location = new System.Drawing.Point(595, 98);
            this.lblComprar.Name = "lblComprar";
            this.lblComprar.Size = new System.Drawing.Size(108, 13);
            this.lblComprar.TabIndex = 20;
            this.lblComprar.Text = "Cantidad por comprar";
            // 
            // lstComprar
            // 
            this.lstComprar.FormattingEnabled = true;
            this.lstComprar.Location = new System.Drawing.Point(598, 124);
            this.lstComprar.Name = "lstComprar";
            this.lstComprar.Size = new System.Drawing.Size(120, 186);
            this.lstComprar.TabIndex = 19;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 401);
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
        private System.Windows.Forms.TextBox txtExistentes;
        private System.Windows.Forms.Label lblExistente;
        private System.Windows.Forms.TextBox txtPedidos;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblComprar;
        private System.Windows.Forms.ListBox lstComprar;
    }
}