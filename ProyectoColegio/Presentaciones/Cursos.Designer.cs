namespace Presentaciones
{
    partial class Cursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cursos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.comboprofesor = new System.Windows.Forms.ComboBox();
            this.txtfecfin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfecini = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(383, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 374);
            this.panel1.TabIndex = 23;
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            this.grilla.AllowUserToDeleteRows = false;
            this.grilla.BackgroundColor = System.Drawing.Color.White;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(17, 371);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.Size = new System.Drawing.Size(847, 227);
            this.grilla.TabIndex = 22;
            // 
            // comboprofesor
            // 
            this.comboprofesor.FormattingEnabled = true;
            this.comboprofesor.Location = new System.Drawing.Point(177, 247);
            this.comboprofesor.Name = "comboprofesor";
            this.comboprofesor.Size = new System.Drawing.Size(200, 21);
            this.comboprofesor.TabIndex = 80;
            this.comboprofesor.Text = "Seleccione...";
            this.comboprofesor.SelectedIndexChanged += new System.EventHandler(this.comboprofesor_SelectedIndexChanged);
            // 
            // txtfecfin
            // 
            this.txtfecfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecfin.Location = new System.Drawing.Point(177, 179);
            this.txtfecfin.Name = "txtfecfin";
            this.txtfecfin.Size = new System.Drawing.Size(200, 20);
            this.txtfecfin.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 78;
            this.label2.Text = "Fecha final de clases";
            // 
            // txtfecini
            // 
            this.txtfecini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecini.Location = new System.Drawing.Point(177, 153);
            this.txtfecini.Name = "txtfecini";
            this.txtfecini.Size = new System.Drawing.Size(200, 20);
            this.txtfecini.TabIndex = 77;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(208, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 37);
            this.button2.TabIndex = 76;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(41, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 37);
            this.button1.TabIndex = 75;
            this.button1.Text = "Guardar Cambios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(283, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 23);
            this.btnBuscar.TabIndex = 74;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(177, 216);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(200, 20);
            this.txtvalor.TabIndex = 73;
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(177, 73);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(200, 75);
            this.txtdesc.TabIndex = 72;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(177, 47);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 20);
            this.txtnom.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 19);
            this.label8.TabIndex = 70;
            this.label8.Text = "Profesor encargado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 19);
            this.label7.TabIndex = 69;
            this.label7.Text = "Valor mensualidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 19);
            this.label5.TabIndex = 68;
            this.label5.Text = "Fecha de inicio de clases";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 67;
            this.label4.Text = "Descrpcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 66;
            this.label3.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 26);
            this.label1.TabIndex = 65;
            this.label1.Text = "Gestion de cursos";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.ForeColor = System.Drawing.Color.Red;
            this.labelid.Location = new System.Drawing.Point(118, 282);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(170, 19);
            this.labelid.TabIndex = 81;
            this.labelid.Text = "Id del curso seleccionado";
            this.labelid.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(332, 9);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(45, 20);
            this.txtid.TabIndex = 83;
            this.txtid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 19);
            this.label6.TabIndex = 82;
            this.label6.Text = "Id";
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 608);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.comboprofesor);
            this.Controls.Add(this.txtfecfin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfecini);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grilla);
            this.Name = "Cursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.ComboBox comboprofesor;
        private System.Windows.Forms.DateTimePicker txtfecfin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtfecini;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label6;
    }
}