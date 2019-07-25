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
    public partial class ListadoDeEntradas : Form
    {
        public LogicaEntradasSalidas logicaES = new LogicaEntradasSalidas();
        public LogicaInscripciones logicaI = new LogicaInscripciones();


        public ListadoDeEntradas()
        {
            InitializeComponent();
        }

        private void ListadoDeEntradas_Load(object sender, EventArgs e)
        {
            grilla.DataSource = logicaES.cargarTablaPorTipos("Entrada");
            llenarcomboalumnos();
        }

        public void llenarcomboalumnos()
        {
            comboniño.Items.Add("Todos");
            foreach (Inscripcion i in logicaI.Lista())
            {
                comboniño.Items.Add(i.niño.id);
            }
        }

        private void comboniño_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboniño.Text == "Todos")
            {
                grilla.DataSource = logicaES.cargarTablaPorTipos("Entrada");
            }
            else
            {
                grilla.DataSource = logicaES.cargarTablaPorEstudiante(comboniño.Text,"Entrada");
            }
        }
    }
}
