namespace WindowsFormsApp1
{
    partial class frmConversorDistancia
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
            this.lblMetros = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtMillas = new System.Windows.Forms.TextBox();
            this.lblMillas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(56, 118);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(83, 13);
            this.lblMensaje.TabIndex = 13;
            this.lblMensaje.Text = "Valor en metros:";
            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Location = new System.Drawing.Point(150, 118);
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(13, 13);
            this.lblMetros.TabIndex = 12;
            this.lblMetros.Text = "0";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(98, 78);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Convertir";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtMillas
            // 
            this.txtMillas.Location = new System.Drawing.Point(98, 35);
            this.txtMillas.Name = "txtMillas";
            this.txtMillas.Size = new System.Drawing.Size(100, 20);
            this.txtMillas.TabIndex = 8;
            // 
            // lblMillas
            // 
            this.lblMillas.AutoSize = true;
            this.lblMillas.Location = new System.Drawing.Point(56, 38);
            this.lblMillas.Name = "lblMillas";
            this.lblMillas.Size = new System.Drawing.Size(33, 13);
            this.lblMillas.TabIndex = 7;
            this.lblMillas.Text = "Millas";
            // 
            // frmConversorDistancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 158);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblMetros);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMillas);
            this.Controls.Add(this.lblMillas);
            this.Name = "frmConversorDistancia";
            this.Text = "Convertir millas a metros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblMetros;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtMillas;
        private System.Windows.Forms.Label lblMillas;
    }
}