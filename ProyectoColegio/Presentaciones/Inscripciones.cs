using Entidades;
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
    public partial class Inscripciones : Form
    {
        public LogicaNiño logicaN = new LogicaNiño();
        public LogicaCurso logicaC = new LogicaCurso();

        public LogicaInscripciones logicaI = new LogicaInscripciones();


        public Inscripciones()
        {
            InitializeComponent();
        }

        public void llenarcomboalumnos()
        {
            foreach (Niño n in logicaN.Lista())
            {
                comboniño.Items.Add(n.id);
            }
        }

        public void llenarcombocursos()
        {
            foreach (Curso c in logicaC.Lista())
            {
                combocurso.Items.Add(c.nombre);
            }
        }
        private void Inscripciones_Load(object sender, EventArgs e)
        {
            mostrartablagrilla();
            llenarcomboalumnos();
            llenarcombocursos();
        }

        private void comboniño_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelnomalum.Text ="Nombre: "+ logicaN.buscar(comboniño.Text).nombre;
        }

        public void mostrartablagrilla()
        {
            grilla.DataSource = logicaI.cargarTabla();
        }

        private void combocurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelprocur.Text = "Profesor del curso: " + logicaC.buscarPorNombre(combocurso.Text).profesor.nombre;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Inscripcion i = new Inscripcion();
            i.niño = logicaN.buscar(comboniño.Text);
            i.curso = logicaC.buscarPorNombre(combocurso.Text);
            string respuesta = logicaI.registrarInscripcion(i);
            MessageBox.Show(respuesta);
            mostrartablagrilla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (grilla.SelectedRows.Count > 0)
            {
                string id = grilla.CurrentRow.Cells[0].Value.ToString();
                string respuesta = logicaI.eliminar(id);
                MessageBox.Show(respuesta);
                mostrartablagrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }
    }
}
