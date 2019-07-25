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
    public partial class Alumnos : Form
    {
        public LogicaNiño logicaN = new LogicaNiño();

        public Alumnos()
        {
            InitializeComponent();
        }
        public void mostrartablagrilla()
        {
            grilla.DataSource = logicaN.cargarTabla();
        }

    private void Alumnos_Load(object sender, EventArgs e)
        {
            mostrartablagrilla();
        }

        public void vaciarCampos()
        {
            txtid.Text = "";
            txtnom.Text = "";
            txtedad.Text = "";
            combosex.Text = "Seleccione...";
            txtidacu.Text = "";
            txtnomacu.Text = "";
            txtdiracu.Text ="";
            txttelacu.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creamos un objeto de la clase niño para poder agregarlo a la ba
            Niño n = new Niño();
            n.id = txtid.Text;
            n.nombre = txtnom.Text;
            n.edad = txtedad.Text;
            n.sexo = combosex.Text;
            n.id_acudiente = txtidacu.Text;
            n.nombre_acudiente = txtnomacu.Text;
            n.direccion_acudiente = txtdiracu.Text;
            n.telefono_acudiente = txttelacu.Text;

            //llamamos a la funcion guardar de la logica de niño si existe
            if (logicaN.buscar(txtid.Text) == null)
            {
                //si es null significa que no existe entonces lo q quiere hacer es guardarlo
                string respuesta = logicaN.guardar(n);
                MessageBox.Show(respuesta);
            }
            else
            {
                //sino quiere guardarlo quiere actualizar o editar sus datos
                string respuesta = logicaN.editar(n);
                MessageBox.Show(respuesta);
            }
            
            mostrartablagrilla();
            vaciarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Length!=0)
            {
                Niño n = logicaN.buscar(txtid.Text);
                if (n!=null)
                {
                    txtnom.Text = n.nombre;
                    txtedad.Text= n.edad;
                    combosex.Text = n.sexo;
                    txtidacu.Text = n.id_acudiente;
                    txtnomacu.Text= n.nombre_acudiente;
                    txtdiracu.Text= n.direccion_acudiente;
                    txttelacu.Text= n.telefono_acudiente;
                }
                else
                {
                    MessageBox.Show("Este niño no esta registrado");
                }
            }
            else
            {
                MessageBox.Show("Error. Debe llenar el cambo id perteneciente al alumno para realizar esta operacion");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Length != 0)
            {
                Niño n = logicaN.buscar(txtid.Text);
                if (n != null)
                {
                    logicaN.eliminar(txtid.Text);
                    MessageBox.Show("Eliminado correctamente");
                    mostrartablagrilla();
                    vaciarCampos();
                }
                else
                {
                    MessageBox.Show("Este niño no esta registrado");
                }
            }
            else
            {
                MessageBox.Show("Error. Debe llenar el cambo id perteneciente al alumno para realizar esta operacion");
            }
        }
    }
}
