namespace Presentaciones
{
    partial class ListadoMensualidadades
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
            this.grilla = new System.Windows.Forms.DataGridView();
            this.comboniño = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 26);
            this.label1.TabIndex = 84;
            this.label1.Text = "LISTADO DE PAGOS DE MENSUALIDAD";
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            this.grilla.AllowUserToDeleteRows = false;
            this.grilla.BackgroundColor = System.Drawing.Color.White;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(12, 124);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.Size = new System.Drawing.Size(776, 314);
            this.grilla.TabIndex = 85;
            // 
            // comboniño
            // 
            this.comboniño.FormattingEnabled = true;
            this.comboniño.Location = new System.Drawing.Point(204, 84);
            this.comboniño.Name = "comboniño";
            this.comboniño.Size = new System.Drawing.Size(200, 21);
            this.comboniño.TabIndex = 87;
            this.comboniño.Text = "Seleccione...";
            this.comboniño.SelectedIndexChanged += new System.EventHandler(this.comboniño_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 19);
            this.label8.TabIndex = 86;
            this.label8.Text = "N° de documento del alumno";
            // 
            // ListadoMensualidadades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboniño);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.label1);
            this.Name = "ListadoMensualidadades";
            this.Text = "ListadoMensualidadades";
            this.Load += new System.EventHandler(this.ListadoMensualidadades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.ComboBox comboniño;
        private System.Windows.Forms.Label label8;
    }
}