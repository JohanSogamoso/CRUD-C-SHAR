using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            registro formulario = new registro();
            formulario.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            consulta formulario = new consulta();
            formulario.Show();
        }
    }
}
