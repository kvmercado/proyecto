namespace Presentaciones
{
    partial class Profesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profesores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtced = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdir = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(473, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 443);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            this.grilla.AllowUserToDeleteRows = false;
            this.grilla.BackgroundColor = System.Drawing.Color.White;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(12, 231);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.Size = new System.Drawing.Size(455, 208);
            this.grilla.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(254, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 37);
            this.button2.TabIndex = 63;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(91, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 37);
            this.button1.TabIndex = 62;
            this.button1.Text = "Guardar Cambios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(326, 57);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 61;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(220, 112);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 55;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(170, 86);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(150, 20);
            this.txtnom.TabIndex = 54;
            // 
            // txtced
            // 
            this.txtced.Location = new System.Drawing.Point(170, 60);
            this.txtced.Name = "txtced";
            this.txtced.Size = new System.Drawing.Size(150, 20);
            this.txtced.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 48;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "N° Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 44;
            this.label1.Text = "INSCRIPCIONES";
            // 
            // txtdir
            // 
            this.txtdir.Location = new System.Drawing.Point(170, 143);
            this.txtdir.Name = "txtdir";
            this.txtdir.Size = new System.Drawing.Size(150, 20);
            this.txtdir.TabIndex = 64;
            // 
            // Profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(878, 456);
            this.Controls.Add(this.txtdir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtced);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grilla);
            this.Name = "Profesores";
            this.Text = "Profesores";
            this.Load += new System.EventHandler(this.Profesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtced;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdir;
    }
}