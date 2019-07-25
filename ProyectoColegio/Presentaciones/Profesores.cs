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
    public partial class Profesores : Form
    {

        public LogicaProfesor logicaP = new LogicaProfesor();

        public Profesores()
        {
            InitializeComponent();
        }

        public void mostrartablagrilla()
        {
            grilla.DataSource = logicaP.cargarTabla();
        }


        public void vaciarCampos()
        {
            txtced.Text = "";
            txtnom.Text = "";
            txttel.Text = "";
            txtdir.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (txtced.Text.Length != 0)
            {
                Profesor p = logicaP.buscar(txtced.Text);
                if (p != null)
                {
                    txtced.Text = p.cedula;
                    txtnom.Text = p.nombre;
                    txttel.Text = p.telefono;
                    txtdir.Text = p.direccion;
                }
                else
                {
                    MessageBox.Show("Este profesor no esta registrado");
                }
            }
            else
            {
                MessageBox.Show("Error. Debe llenar el cambo cedula perteneciente al profesor para realizar esta operacion");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creamos un objeto de la clase profesor para poder agregarlo a la ba
            Profesor p = new Profesor();
            p.cedula = txtced.Text;
            p.nombre = txtnom.Text;
            p.direccion = txtdir.Text;
            p.telefono = txttel.Text;
            

            //llamamos a la funcion guardar de la logica de profesor si existe
            if (logicaP.buscar(txtced.Text) == null)
            {
                //si es null significa que no existe entonces lo q quiere hacer es guardarlo
                string respuesta = logicaP.guardar(p);
                MessageBox.Show(respuesta);
            }
            else
            {
                //sino quiere guardarlo quiere actualizar o editar sus datos
                string respuesta = logicaP.editar(p);
                MessageBox.Show(respuesta);
            }

            mostrartablagrilla();
            vaciarCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtced.Text.Length != 0)
            {
                Profesor p = logicaP.buscar(txtced.Text);
                if (p != null)
                {
                    logicaP.eliminar(txtced.Text);
                    MessageBox.Show("Eliminado correctamente");
                    mostrartablagrilla();
                    vaciarCampos();
                }
                else
                {
                    MessageBox.Show("Este profesor no esta registrado");
                }
            }
            else
            {
                MessageBox.Show("Error. Debe llenar el cambo cedula perteneciente al profesor para realizar esta operacion");
            }
        }

        private void Profesores_Load(object sender, EventArgs e)
        {
            mostrartablagrilla();
        }
    }
}
