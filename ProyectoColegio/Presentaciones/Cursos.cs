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
    public partial class Cursos : Form
    {
        LogicaCurso logicaC = new LogicaCurso();
        public Cursos()
        {
            InitializeComponent();
        }

        public void cargarprofesores()
        {
            LogicaProfesor logicaP = new LogicaProfesor();
            foreach (Profesor p in logicaP.Lista())
            {
                comboprofesor.Items.Add(p.nombre);
            }
        }
        public void vaciarCampos()
        {
            txtid.Text = "";
            labelid.Visible=false;
            txtnom.Text = "";
            txtdesc.Text = "";
            txtfecfin.Refresh();
            txtfecini.Refresh();
            txtvalor.Text = "";
            comboprofesor.Text = "Seleccione...";
        }
        public void mostrartablagrilla()
        {
            grilla.DataSource = logicaC.cargarTabla();
        }
        private void comboprofesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LogicaProfesor logicaP = new LogicaProfesor();
            labelid.Visible = true;
            labelid.Text = "N° de documento del profesor : " + logicaP.buscarPorNombre(comboprofesor.Text).cedula;
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            cargarprofesores();
            mostrartablagrilla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtnom.Text.Length != 0)
            {
                Curso c = logicaC.buscarPorNombre(txtnom.Text);
                if (c != null)
                {
                    txtid.Text = c.id;
                    txtnom.Text = c.nombre;
                    txtdesc.Text = c.descripcion;
                    txtfecfin.Value = c.fecha_inicio_clases;
                    txtfecini.Value = c.fecha_fin_clases;
                    txtvalor.Text = c.valor_mensualidad.ToString();
                    comboprofesor.Text =c.profesor.nombre;
                    labelid.Text = "Id del curso seleccionado " + c.id;

                }
                else
                {
                    MessageBox.Show("Este curso no esta registrado");
                }
            }
            else
            {
                MessageBox.Show("Error. Debe llenar el cambo nombre perteneciente al curso para realizar esta operacion");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Curso c = new Curso();
            c.nombre = txtnom.Text;
            c.descripcion = txtdesc.Text;

            c.fecha_inicio_clases = txtfecini.Value.Date;
            c.fecha_fin_clases = txtfecfin.Value.Date;
            c.valor_mensualidad = Decimal.Parse(txtvalor.Text);
            LogicaProfesor ln = new LogicaProfesor();
            c.profesor = ln.buscarPorNombre(comboprofesor.Text);
            if (logicaC.buscar(txtid.Text)==null)
            {
                //si es null significa que no existe entonces lo q quiere hacer es guardarlo
                string respuesta = logicaC.guardar(c);
                MessageBox.Show(respuesta);
            }
            else
            {
                //sino quiere guardarlo quiere actualizar o editar sus datos
                c.id = txtid.Text;
                string respuesta = logicaC.editar(c);
                MessageBox.Show(respuesta);
            }

            mostrartablagrilla();
           // vaciarCampos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Length != 0)
            {
                Curso c = logicaC.buscar(txtid.Text);
                if (c != null)
                {
                    logicaC.eliminar(txtid.Text);
                    MessageBox.Show("Eliminado correctamente");
                    mostrartablagrilla();
                    vaciarCampos();

                }
                else
                {
                    MessageBox.Show("Este curso no esta registrado");
                }
            }
            else
            {
                MessageBox.Show("Error. Debe llenar el cambo nombre perteneciente al curso para realizar esta operacion");
            }
        }
    }
}
