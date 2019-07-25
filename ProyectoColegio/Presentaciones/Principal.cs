using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaciones
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
          

        }
        
       

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void gestionAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumnos a = new Alumnos();
            a.Show();
        }

        private void gestionDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesores p = new Profesores();
            p.Show();
        }

        private void gestionCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursos c = new Cursos();
            c.Show();
        }

        private void realizarInscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inscripciones i = new Inscripciones();
            i.Show();
        }

        private void realizarPagoDeMensualidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagoMensualidad pm = new PagoMensualidad();
            pm.Show();
        }

        private void listadoDePagosDeMensualidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoMensualidadades lm = new ListadoMensualidadades();
            lm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntradasSalidas es = new EntradasSalidas();
            es.Show();
        }

        private void listadoDeEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoDeEntradas le = new ListadoDeEntradas();
            le.Show();
        }

        private void listadoDeSalidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoDeSalidas ls = new ListadoDeSalidas();
            ls.Show();
        }
    }
}
