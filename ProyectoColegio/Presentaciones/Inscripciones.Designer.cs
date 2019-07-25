namespace Presentaciones
{
    partial class Inscripciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscripciones));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.comboniño = new System.Windows.Forms.ComboBox();
            this.combocurso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelnomalum = new System.Windows.Forms.Label();
            this.labelprocur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(262, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 37);
            this.button2.TabIndex = 77;
            this.button2.Text = "Cancelar inscripcion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 37);
            this.button1.TabIndex = 76;
            this.button1.Text = "Confirmar inscripcion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 67;
            this.label1.Text = "INSCRIPCIONES";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(483, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 443);
            this.panel1.TabIndex = 66;
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            this.grilla.AllowUserToDeleteRows = false;
            this.grilla.BackgroundColor = System.Drawing.Color.White;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(22, 285);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.Size = new System.Drawing.Size(455, 208);
            this.grilla.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 19);
            this.label8.TabIndex = 81;
            this.label8.Text = "N° de documento del alumno";
            // 
            // comboniño
            // 
            this.comboniño.FormattingEnabled = true;
            this.comboniño.Location = new System.Drawing.Point(43, 113);
            this.comboniño.Name = "comboniño";
            this.comboniño.Size = new System.Drawing.Size(200, 21);
            this.comboniño.TabIndex = 82;
            this.comboniño.Text = "Seleccione...";
            this.comboniño.SelectedIndexChanged += new System.EventHandler(this.comboniño_SelectedIndexChanged);
            // 
            // combocurso
            // 
            this.combocurso.FormattingEnabled = true;
            this.combocurso.Location = new System.Drawing.Point(43, 186);
            this.combocurso.Name = "combocurso";
            this.combocurso.Size = new System.Drawing.Size(200, 21);
            this.combocurso.TabIndex = 84;
            this.combocurso.Text = "Seleccione...";
            this.combocurso.SelectedIndexChanged += new System.EventHandler(this.combocurso_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 83;
            this.label2.Text = "Curso ";
            // 
            // labelnomalum
            // 
            this.labelnomalum.AutoSize = true;
            this.labelnomalum.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnomalum.Location = new System.Drawing.Point(258, 115);
            this.labelnomalum.Name = "labelnomalum";
            this.labelnomalum.Size = new System.Drawing.Size(0, 19);
            this.labelnomalum.TabIndex = 85;
            // 
            // labelprocur
            // 
            this.labelprocur.AutoSize = true;
            this.labelprocur.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprocur.Location = new System.Drawing.Point(39, 210);
            this.labelprocur.Name = "labelprocur";
            this.labelprocur.Size = new System.Drawing.Size(0, 19);
            this.labelprocur.TabIndex = 86;
            // 
            // Inscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 505);
            this.Controls.Add(this.labelprocur);
            this.Controls.Add(this.labelnomalum);
            this.Controls.Add(this.combocurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboniño);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grilla);
            this.Name = "Inscripciones";
            this.Text = "Inscripciones";
            this.Load += new System.EventHandler(this.Inscripciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboniño;
        private System.Windows.Forms.ComboBox combocurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelnomalum;
        private System.Windows.Forms.Label labelprocur;
    }
}