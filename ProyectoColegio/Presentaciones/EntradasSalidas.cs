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
    public partial class EntradasSalidas : Form
    {
        public LogicaInscripciones logicaI = new LogicaInscripciones();
        public LogicaEntradasSalidas logicaES = new LogicaEntradasSalidas();

        public EntradasSalidas()
        {
            InitializeComponent();
        }
        public void llenarcomboalumnos()
        {
            foreach (Inscripcion i in logicaI.Lista())
            {
                comboniño.Items.Add(i.niño.id);
            }
        }

        private void EntradasSalidas_Load(object sender, EventArgs e)
        {
            llenarcomboalumnos();
        }

        private void comboniño_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelinfo.Text = "INFORMACION DEL NIÑO \n";
            foreach (Inscripcion i in logicaI.Lista())
            {
                Niño n = i.niño;
                Curso c = i.curso;
                if (n.id == comboniño.Text)
                {
                  
                    labelinfo.Text += "Nombre del alumno: " + n.nombre + "\n" +
                        "N° documento del acudiente: " + n.id_acudiente + "\n" +
                        "Acudiente: " + n.nombre_acudiente + "\n" +
                        "Curso Perteneciente: " + c.nombre + "\n" +
                        "Profesor del grupo: " + c.profesor.nombre + "\n" +
                        "Fecha de inscripcion del estudiante: " + i.fecha
                        ;
                }
            }
        }

        private void combomovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnregistrar.Text = "Registrar " + combomovimiento.Text;
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            LogicaNiño logicaN = new LogicaNiño();
            Entrada_Salida es = new Entrada_Salida();
            es.tipo = combomovimiento.Text;
            es.niño = logicaN.buscar(comboniño.Text);
            string respuesta = logicaES.registrarEntradaSalida(es);
            MessageBox.Show(respuesta);
        }
    }
}
