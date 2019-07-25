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
    public partial class PagoMensualidad : Form
    {
        public LogicaNiño logicaN = new LogicaNiño();
        public LogicaCurso logicaC = new LogicaCurso();

        public LogicaInscripciones logicaI = new LogicaInscripciones();
        public LogicaMensualidades logicaM = new LogicaMensualidades();


        public string id_inscripcion;
        public PagoMensualidad()
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

        private void label1_Click(object sender, EventArgs e)
        {

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
                    radiocom.Enabled = true;
                    radioabo.Enabled = true;
                    labelinfo.Text += "Nombre del alumno: " + n.nombre + "\n" +
                        "N° documento del acudiente: " + n.id_acudiente + "\n" +
                        "Acudiente: " + n.nombre_acudiente + "\n" +
                        "Curso Perteneciente: "+c.nombre+"\n" +
                        "Profesor del grupo: "+c.profesor.nombre+"\n" +
                        "Fecha de inscripcion del estudiante: "+i.fecha
                        ;
                    this.id_inscripcion = i.id;
                }
            }
           

        }

        private void PagoMensualidad_Load(object sender, EventArgs e)
        {
            llenarcomboalumnos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (logicaN.buscar(comboniño.Text)!=null)
            {
          
                Mensualidad m = new Mensualidad();
                m.inscrpcion = logicaI.buscar(this.id_inscripcion);
                if(Decimal.Parse(txtvalor.Text) < logicaI.buscar(this.id_inscripcion).curso.valor_mensualidad)
                {
                    m.estado = "Pago un abono";
                }
                else
                {
                    m.estado = "Pago completo";
                }
                m.valor_pagado = Decimal.Parse(txtvalor.Text);
                if (m.valor_pagado <= logicaI.buscar(this.id_inscripcion).curso.valor_mensualidad)
                {
                    string respuesta = logicaM.registrarmensualidad(m);
                    MessageBox.Show(respuesta);
                }
                else
                {
                    MessageBox.Show("El valor a pagar no puede sobrepasar el valor del curso o mensualidad");
                }
               
            }
            else
            {
                MessageBox.Show("El niño que intenta buscar no existe");
            }
        }

        private void radiocom_CheckedChanged(object sender, EventArgs e)
        {

            if (radiocom.Checked)
            {
                txtvalor.Enabled = false;
                radioabo.Checked = false;
                Inscripcion i = logicaI.buscar(this.id_inscripcion);
                txtvalor.Text = i.curso.valor_mensualidad.ToString();
            }
        }

        private void radioabo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioabo.Checked)
            {
                radiocom.Checked = false;
                txtvalor.Enabled = true;
            }
        }
    }
}
