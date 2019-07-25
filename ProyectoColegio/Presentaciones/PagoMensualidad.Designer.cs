namespace Presentaciones
{
    partial class PagoMensualidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagoMensualidad));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboniño = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelinfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radiocom = new System.Windows.Forms.RadioButton();
            this.radioabo = new System.Windows.Forms.RadioButton();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(27, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 348);
            this.panel1.TabIndex = 0;
            // 
            // comboniño
            // 
            this.comboniño.FormattingEnabled = true;
            this.comboniño.Location = new System.Drawing.Point(364, 90);
            this.comboniño.Name = "comboniño";
            this.comboniño.Size = new System.Drawing.Size(200, 21);
            this.comboniño.TabIndex = 85;
            this.comboniño.Text = "Seleccione...";
            this.comboniño.SelectedIndexChanged += new System.EventHandler(this.comboniño_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 19);
            this.label8.TabIndex = 84;
            this.label8.Text = "N° de documento del alumno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 26);
            this.label1.TabIndex = 83;
            this.label1.Text = "PROCESO DE PAGO DE MENSUALIDAD ACADEMICA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(570, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 43);
            this.button1.TabIndex = 86;
            this.button1.Text = "Registrar pago";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelinfo
            // 
            this.labelinfo.AutoSize = true;
            this.labelinfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinfo.Location = new System.Drawing.Point(360, 184);
            this.labelinfo.Name = "labelinfo";
            this.labelinfo.Size = new System.Drawing.Size(232, 19);
            this.labelinfo.TabIndex = 87;
            this.labelinfo.Text = "Informacion del estudiante y su curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 88;
            this.label2.Text = "Formas de pago";
            // 
            // radiocom
            // 
            this.radiocom.AutoSize = true;
            this.radiocom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radiocom.Enabled = false;
            this.radiocom.Location = new System.Drawing.Point(364, 152);
            this.radiocom.Name = "radiocom";
            this.radiocom.Size = new System.Drawing.Size(69, 17);
            this.radiocom.TabIndex = 89;
            this.radiocom.TabStop = true;
            this.radiocom.Text = "Completo";
            this.radiocom.UseVisualStyleBackColor = true;
            this.radiocom.CheckedChanged += new System.EventHandler(this.radiocom_CheckedChanged);
            // 
            // radioabo
            // 
            this.radioabo.AutoSize = true;
            this.radioabo.Enabled = false;
            this.radioabo.Location = new System.Drawing.Point(477, 152);
            this.radioabo.Name = "radioabo";
            this.radioabo.Size = new System.Drawing.Size(56, 17);
            this.radioabo.TabIndex = 90;
            this.radioabo.TabStop = true;
            this.radioabo.Text = "Abono";
            this.radioabo.UseVisualStyleBackColor = true;
            this.radioabo.CheckedChanged += new System.EventHandler(this.radioabo_CheckedChanged);
            // 
            // txtvalor
            // 
            this.txtvalor.Enabled = false;
            this.txtvalor.Location = new System.Drawing.Point(637, 152);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(151, 20);
            this.txtvalor.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(703, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 92;
            this.label3.Text = "Valor a pagar";
            // 
            // PagoMensualidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 392);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.radioabo);
            this.Controls.Add(this.radiocom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelinfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboniño);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Name = "PagoMensualidad";
            this.Text = "PagoMensualidad";
            this.Load += new System.EventHandler(this.PagoMensualidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboniño;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelinfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radiocom;
        private System.Windows.Forms.RadioButton radioabo;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label3;
    }
}