namespace Presentaciones
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosOInscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarInscripcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarPagoDeMensualidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeEntradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeSalidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.listadoDePagosDeMensualidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionAlumnosToolStripMenuItem,
            this.gestionDocentesToolStripMenuItem,
            this.gestionCursosToolStripMenuItem,
            this.pagosOInscripcionesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionAlumnosToolStripMenuItem
            // 
            this.gestionAlumnosToolStripMenuItem.Name = "gestionAlumnosToolStripMenuItem";
            this.gestionAlumnosToolStripMenuItem.Size = new System.Drawing.Size(100, 28);
            this.gestionAlumnosToolStripMenuItem.Text = "Alumnos";
            this.gestionAlumnosToolStripMenuItem.Click += new System.EventHandler(this.gestionAlumnosToolStripMenuItem_Click);
            // 
            // gestionDocentesToolStripMenuItem
            // 
            this.gestionDocentesToolStripMenuItem.Name = "gestionDocentesToolStripMenuItem";
            this.gestionDocentesToolStripMenuItem.Size = new System.Drawing.Size(104, 28);
            this.gestionDocentesToolStripMenuItem.Text = "Docentes";
            this.gestionDocentesToolStripMenuItem.Click += new System.EventHandler(this.gestionDocentesToolStripMenuItem_Click);
            // 
            // gestionCursosToolStripMenuItem
            // 
            this.gestionCursosToolStripMenuItem.Name = "gestionCursosToolStripMenuItem";
            this.gestionCursosToolStripMenuItem.Size = new System.Drawing.Size(83, 28);
            this.gestionCursosToolStripMenuItem.Text = "Cursos";
            this.gestionCursosToolStripMenuItem.Click += new System.EventHandler(this.gestionCursosToolStripMenuItem_Click);
            // 
            // pagosOInscripcionesToolStripMenuItem
            // 
            this.pagosOInscripcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarInscripcionToolStripMenuItem,
            this.realizarPagoDeMensualidadToolStripMenuItem});
            this.pagosOInscripcionesToolStripMenuItem.Name = "pagosOInscripcionesToolStripMenuItem";
            this.pagosOInscripcionesToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.pagosOInscripcionesToolStripMenuItem.Text = "Pagos o Inscripciones";
            // 
            // realizarInscripcionToolStripMenuItem
            // 
            this.realizarInscripcionToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realizarInscripcionToolStripMenuItem.Name = "realizarInscripcionToolStripMenuItem";
            this.realizarInscripcionToolStripMenuItem.Size = new System.Drawing.Size(278, 24);
            this.realizarInscripcionToolStripMenuItem.Text = "Realizar Inscripcion";
            this.realizarInscripcionToolStripMenuItem.Click += new System.EventHandler(this.realizarInscripcionToolStripMenuItem_Click);
            // 
            // realizarPagoDeMensualidadToolStripMenuItem
            // 
            this.realizarPagoDeMensualidadToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realizarPagoDeMensualidadToolStripMenuItem.Name = "realizarPagoDeMensualidadToolStripMenuItem";
            this.realizarPagoDeMensualidadToolStripMenuItem.Size = new System.Drawing.Size(278, 24);
            this.realizarPagoDeMensualidadToolStripMenuItem.Text = "Realizar pago de mensualidad";
            this.realizarPagoDeMensualidadToolStripMenuItem.Click += new System.EventHandler(this.realizarPagoDeMensualidadToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDePagosDeMensualidadToolStripMenuItem,
            this.listadoDeEntradasToolStripMenuItem,
            this.listadoDeSalidasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(102, 28);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // listadoDeEntradasToolStripMenuItem
            // 
            this.listadoDeEntradasToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadoDeEntradasToolStripMenuItem.Name = "listadoDeEntradasToolStripMenuItem";
            this.listadoDeEntradasToolStripMenuItem.Size = new System.Drawing.Size(299, 24);
            this.listadoDeEntradasToolStripMenuItem.Text = "Listado de entradas";
            this.listadoDeEntradasToolStripMenuItem.Click += new System.EventHandler(this.listadoDeEntradasToolStripMenuItem_Click);
            // 
            // listadoDeSalidasToolStripMenuItem
            // 
            this.listadoDeSalidasToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadoDeSalidasToolStripMenuItem.Name = "listadoDeSalidasToolStripMenuItem";
            this.listadoDeSalidasToolStripMenuItem.Size = new System.Drawing.Size(299, 24);
            this.listadoDeSalidasToolStripMenuItem.Text = "Listado de salidas";
            this.listadoDeSalidasToolStripMenuItem.Click += new System.EventHandler(this.listadoDeSalidasToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(128, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(595, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Registrar entrada o salida de alumnos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listadoDePagosDeMensualidadToolStripMenuItem
            // 
            this.listadoDePagosDeMensualidadToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadoDePagosDeMensualidadToolStripMenuItem.Name = "listadoDePagosDeMensualidadToolStripMenuItem";
            this.listadoDePagosDeMensualidadToolStripMenuItem.Size = new System.Drawing.Size(299, 24);
            this.listadoDePagosDeMensualidadToolStripMenuItem.Text = "Listado de pagos de mensualidad";
            this.listadoDePagosDeMensualidadToolStripMenuItem.Click += new System.EventHandler(this.listadoDePagosDeMensualidadToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(850, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosOInscripcionesToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeEntradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSalidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarInscripcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarPagoDeMensualidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDePagosDeMensualidadToolStripMenuItem;
    }
}