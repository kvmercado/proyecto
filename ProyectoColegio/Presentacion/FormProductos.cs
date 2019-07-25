using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODERN_GUI_2
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }
        private void FormProductos_Load(object sender, EventArgs e)
        {
            InsertarFilas();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormMantProducto frm = new FormMantProducto();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                frm.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtcategoria.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.txtdescrip.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.txtprecio.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.txtstock.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("debe seleccionar fila");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormMantProducto frm = new FormMantProducto();
            frm.ShowDialog();
        }

        private void InsertarFilas()
        {
            dataGridView1.Rows.Insert(0, "1", "golosina", "kataboom", "0.2", "45");
            dataGridView1.Rows.Insert(1, "2", "golosina", "kataboom", "0.2", "45");
            dataGridView1.Rows.Insert(2, "3", "golosina", "kataboom", "0.2", "45");
            dataGridView1.Rows.Insert(3, "4", "golosina", "kataboom", "0.2", "45");
            dataGridView1.Rows.Insert(4, "5", "golosina", "kataboom", "0.2", "45");
            dataGridView1.Rows.Insert(5, "6", "golosina", "kataboom", "0.2", "45");
            dataGridView1.Rows.Insert(6, "7", "golosina", "kataboom", "0.2", "45");
            dataGridView1.Rows.Insert(7, "8", "golosina", "kataboom", "0.2", "45");
            dataGridView1.Rows.Insert(8, "9", "golosina", "kataboom", "0.2", "45");
            dataGridView1.Rows.Insert(9, "10", "golosina", "kataboom", "0.2", "45");
            dataGridView1.Rows.Insert(10, "11", "golosina", "kataboom", "0.2", "45");
         
          
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            formventa frm = Owner as formventa;
            frm.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtcategoria.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtdescrip.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtprecio.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.txtstock.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            this.Close();
        }

       
           }
}
