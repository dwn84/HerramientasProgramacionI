namespace WindowsFormsApp1
{
    partial class frmImagen
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
            this.gpbPosiciones = new System.Windows.Forms.GroupBox();
            this.rdbAbajo = new System.Windows.Forms.RadioButton();
            this.rdbCentro = new System.Windows.Forms.RadioButton();
            this.rdbArriba = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbPosiciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbPosiciones
            // 
            this.gpbPosiciones.Controls.Add(this.rdbAbajo);
            this.gpbPosiciones.Controls.Add(this.rdbCentro);
            this.gpbPosiciones.Controls.Add(this.rdbArriba);
            this.gpbPosiciones.Location = new System.Drawing.Point(32, 51);
            this.gpbPosiciones.Name = "gpbPosiciones";
            this.gpbPosiciones.Size = new System.Drawing.Size(200, 112);
            this.gpbPosiciones.TabIndex = 1;
            this.gpbPosiciones.TabStop = false;
            this.gpbPosiciones.Text = "Seleccione una posición";
            // 
            // rdbAbajo
            // 
            this.rdbAbajo.AutoSize = true;
            this.rdbAbajo.Location = new System.Drawing.Point(44, 79);
            this.rdbAbajo.Name = "rdbAbajo";
            this.rdbAbajo.Size = new System.Drawing.Size(52, 17);
            this.rdbAbajo.TabIndex = 2;
            this.rdbAbajo.TabStop = true;
            this.rdbAbajo.Text = "Abajo";
            this.rdbAbajo.UseVisualStyleBackColor = true;
            this.rdbAbajo.CheckedChanged += new System.EventHandler(this.rdbAbajo_CheckedChanged);
            // 
            // rdbCentro
            // 
            this.rdbCentro.AutoSize = true;
            this.rdbCentro.Location = new System.Drawing.Point(44, 56);
            this.rdbCentro.Name = "rdbCentro";
            this.rdbCentro.Size = new System.Drawing.Size(55, 17);
            this.rdbCentro.TabIndex = 1;
            this.rdbCentro.TabStop = true;
            this.rdbCentro.Text = "centro";
            this.rdbCentro.UseVisualStyleBackColor = true;
            this.rdbCentro.CheckedChanged += new System.EventHandler(this.rdbCentro_CheckedChanged);
            // 
            // rdbArriba
            // 
            this.rdbArriba.AutoSize = true;
            this.rdbArriba.Location = new System.Drawing.Point(44, 33);
            this.rdbArriba.Name = "rdbArriba";
            this.rdbArriba.Size = new System.Drawing.Size(52, 17);
            this.rdbArriba.TabIndex = 0;
            this.rdbArriba.TabStop = true;
            this.rdbArriba.Text = "Arriba";
            this.rdbArriba.UseVisualStyleBackColor = true;
            this.rdbArriba.CheckedChanged += new System.EventHandler(this.rdbArriba_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.hf;
            this.pictureBox1.Location = new System.Drawing.Point(259, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 226);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpbPosiciones);
            this.Name = "frmImagen";
            this.Text = "Modificacion de posicion de imagen";
            this.gpbPosiciones.ResumeLayout(false);
            this.gpbPosiciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPosiciones;
        private System.Windows.Forms.RadioButton rdbAbajo;
        private System.Windows.Forms.RadioButton rdbCentro;
        private System.Windows.Forms.RadioButton rdbArriba;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}