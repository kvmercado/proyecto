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
    public partial class ListadoMensualidadades : Form
    {

        public LogicaMensualidades logicaM = new LogicaMensualidades();
        public LogicaInscripciones logicaI = new LogicaInscripciones();

        public ListadoMensualidadades()
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

        private void ListadoMensualidadades_Load(object sender, EventArgs e)
        {
            grilla.DataSource = logicaM.cargarTabla();
            llenarcomboalumnos();
        }

        private void comboniño_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboniño.Text=="Todos")
            {
                grilla.DataSource = logicaM.cargarTabla();
            }
            else
            {
                grilla.DataSource = logicaM.cargarTablaPorEstudiante(comboniño.Text);
            }
        }
    }
}
