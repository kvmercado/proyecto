using Logica;
using Entidades;
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
    public partial class ListadoDeSalidas : Form
    {
        public LogicaEntradasSalidas logicaES = new LogicaEntradasSalidas();
        public LogicaInscripciones logicaI = new LogicaInscripciones();


        public ListadoDeSalidas()
        {
            InitializeComponent();
        }
        public void llenarcomboalumnos()
        {
            comboniño.Items.Add("Todos");
            foreach (Inscripcion i in logicaI.Lista())
            {
                comboniño.Items.Add(i.niño.id);
            }
        }

        private void ListadoDeSalidas_Load(object sender, EventArgs e)
        {
            llenarcomboalumnos();
            grilla.DataSource = logicaES.cargarTablaPorTipos("Salida");

        }

        private void comboniño_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboniño.Text == "Todos")
            {
                grilla.DataSource = logicaES.cargarTablaPorTipos("Salida");
            }
            else
            {
                grilla.DataSource = logicaES.cargarTablaPorEstudiante(comboniño.Text, "Salida");
            }
        }
    }
}
