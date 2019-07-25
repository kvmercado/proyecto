namespace Presentaciones
{
    partial class EntradasSalidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradasSalidas));
            this.labelinfo = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboniño = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.combomovimiento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelinfo
            // 
            this.labelinfo.AutoSize = true;
            this.labelinfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinfo.Location = new System.Drawing.Point(350, 217);
            this.labelinfo.Name = "labelinfo";
            this.labelinfo.Size = new System.Drawing.Size(232, 19);
            this.labelinfo.TabIndex = 93;
            this.labelinfo.Text = "Informacion del estudiante y su curso";
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.White;
            this.btnregistrar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Location = new System.Drawing.Point(591, 139);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(223, 43);
            this.btnregistrar.TabIndex = 92;
            this.btnregistrar.Text = "Registrar Actividad";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(820, 26);
            this.label1.TabIndex = 89;
            this.label1.Text = "PROCESO DE REGISTRO DE ENTRADAS Y SALIDAS DE LOS ALUMNOS";
            // 
            // comboniño
            // 
            this.comboniño.FormattingEnabled = true;
            this.comboniño.Location = new System.Drawing.Point(354, 182);
            this.comboniño.Name = "comboniño";
            this.comboniño.Size = new System.Drawing.Size(200, 21);
            this.comboniño.TabIndex = 91;
            this.comboniño.Text = "Seleccione...";
            this.comboniño.SelectedIndexChanged += new System.EventHandler(this.comboniño_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(350, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 19);
            this.label8.TabIndex = 90;
            this.label8.Text = "N° de documento del alumno";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(17, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 299);
            this.panel1.TabIndex = 88;
            // 
            // combomovimiento
            // 
            this.combomovimiento.FormattingEnabled = true;
            this.combomovimiento.Items.AddRange(new object[] {
            "Entrada",
            "Salida"});
            this.combomovimiento.Location = new System.Drawing.Point(354, 112);
            this.combomovimiento.Name = "combomovimiento";
            this.combomovimiento.Size = new System.Drawing.Size(200, 21);
            this.combomovimiento.TabIndex = 95;
            this.combomovimiento.Text = "Seleccione...";
            this.combomovimiento.SelectedIndexChanged += new System.EventHandler(this.combomovimiento_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 94;
            this.label2.Text = "Accion o movimiento";
            // 
            // EntradasSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 380);
            this.Controls.Add(this.combomovimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelinfo);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboniño);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Name = "EntradasSalidas";
            this.Text = "EntradasSalidas";
            this.Load += new System.EventHandler(this.EntradasSalidas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelinfo;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboniño;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox combomovimiento;
        private System.Windows.Forms.Label label2;
    }
}