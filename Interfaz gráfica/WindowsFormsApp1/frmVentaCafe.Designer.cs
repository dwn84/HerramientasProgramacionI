namespace WindowsFormsApp1
{
    partial class frmVentaCafe
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtValorMercado = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtKilos = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.txtValorDolar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(55, 182);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(111, 13);
            this.lblMensaje.TabIndex = 13;
            this.lblMensaje.Text = "El precio en pesos es:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(172, 182);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "0";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(170, 143);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular precio";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtValorMercado
            // 
            this.txtValorMercado.Location = new System.Drawing.Point(170, 68);
            this.txtValorMercado.Name = "txtValorMercado";
            this.txtValorMercado.Size = new System.Drawing.Size(100, 20);
            this.txtValorMercado.TabIndex = 10;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(22, 71);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(146, 13);
            this.lblAltura.TabIndex = 9;
            this.lblAltura.Text = "Valor de la carga en mercado";
            // 
            // txtKilos
            // 
            this.txtKilos.Location = new System.Drawing.Point(170, 27);
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.Size = new System.Drawing.Size(100, 20);
            this.txtKilos.TabIndex = 8;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(22, 30);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(68, 13);
            this.lblBase.TabIndex = 7;
            this.lblBase.Text = "Kilos de café";
            // 
            // txtValorDolar
            // 
            this.txtValorDolar.Location = new System.Drawing.Point(170, 101);
            this.txtValorDolar.Name = "txtValorDolar";
            this.txtValorDolar.Size = new System.Drawing.Size(100, 20);
            this.txtValorDolar.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Valor del dolar";
            // 
            // frmVentaCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 233);
            this.Controls.Add(this.txtValorDolar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorMercado);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtKilos);
            this.Controls.Add(this.lblBase);
            this.Name = "frmVentaCafe";
            this.Text = "frmVentaCafe";
            this.Load += new System.EventHandler(this.frmVentaCafe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtValorMercado;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtKilos;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox txtValorDolar;
        private System.Windows.Forms.Label label1;
    }
}