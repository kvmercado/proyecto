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
    public partial class formventa : Form
    {
        public formventa()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormProductos frm = new FormProductos();
            AddOwnedForm(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
