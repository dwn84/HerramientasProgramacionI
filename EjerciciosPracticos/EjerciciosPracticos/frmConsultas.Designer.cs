namespace EjerciciosPracticos
{
    partial class frmConsultas
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
            this.lstStrings = new System.Windows.Forms.ListBox();
            this.txtString = new System.Windows.Forms.TextBox();
            this.lblDato = new System.Windows.Forms.Label();
            this.lstQueries = new System.Windows.Forms.ListBox();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarPalabra = new System.Windows.Forms.Button();
            this.btnAgregarConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstStrings
            // 
            this.lstStrings.FormattingEnabled = true;
            this.lstStrings.Location = new System.Drawing.Point(25, 97);
            this.lstStrings.Name = "lstStrings";
            this.lstStrings.Size = new System.Drawing.Size(204, 186);
            this.lstStrings.TabIndex = 6;
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(129, 12);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(100, 20);
            this.txtString.TabIndex = 5;
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.Location = new System.Drawing.Point(22, 15);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(101, 13);
            this.lblDato.TabIndex = 4;
            this.lblDato.Text = "Ingrese una palabra";
            // 
            // lstQueries
            // 
            this.lstQueries.FormattingEnabled = true;
            this.lstQueries.Location = new System.Drawing.Point(253, 122);
            this.lstQueries.Name = "lstQueries";
            this.lstQueries.Size = new System.Drawing.Size(204, 160);
            this.lstQueries.TabIndex = 9;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(253, 44);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(100, 20);
            this.txtQuery.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingrese una palabrapara buscar";
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(480, 123);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(204, 160);
            this.lstResults.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cantidad de coincidencias";
            // 
            // btnAgregarPalabra
            // 
            this.btnAgregarPalabra.Location = new System.Drawing.Point(25, 44);
            this.btnAgregarPalabra.Name = "btnAgregarPalabra";
            this.btnAgregarPalabra.Size = new System.Drawing.Size(204, 23);
            this.btnAgregarPalabra.TabIndex = 12;
            this.btnAgregarPalabra.Text = "Agregar palabra";
            this.btnAgregarPalabra.UseVisualStyleBackColor = true;
            this.btnAgregarPalabra.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregarConsulta
            // 
            this.btnAgregarConsulta.Location = new System.Drawing.Point(253, 83);
            this.btnAgregarConsulta.Name = "btnAgregarConsulta";
            this.btnAgregarConsulta.Size = new System.Drawing.Size(204, 23);
            this.btnAgregarConsulta.TabIndex = 13;
            this.btnAgregarConsulta.Text = "Agregar consulta";
            this.btnAgregarConsulta.UseVisualStyleBackColor = true;
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 305);
            this.Controls.Add(this.btnAgregarConsulta);
            this.Controls.Add(this.btnAgregarPalabra);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstQueries);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstStrings);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.lblDato);
            this.Name = "frmConsultas";
            this.Text = "Resultados de búsquedas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStrings;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Label lblDato;
        private System.Windows.Forms.ListBox lstQueries;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarPalabra;
        private System.Windows.Forms.Button btnAgregarConsulta;
    }
}