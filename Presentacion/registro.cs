using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Presentacion
{
    public partial class registro : Form
    {
        Usuario objUsuario = new Usuario();
        public registro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Focus();
                MessageBox.Show("Este campo esta vacio");
            }
            else if (txtApellido.Text == "")
            {
                txtApellido.Focus();
                MessageBox.Show("Este campo esta vacio");
            }
            else if (txtDireccion.Text == "")
            {
               txtDireccion.Focus();
                MessageBox.Show("Este campo esta vacio");
            }
            else if (txtIdentificacion.Text == "")
            {
                txtIdentificacion.Focus();
                MessageBox.Show("Este campo esta vacio");
            }
            else if (txtCelular.Text == "")
            {
                txtCelular.Focus();
                MessageBox.Show("Este campo esta vacio");
            }
            else if (txtCorreo.Text == "")
            {
                txtCorreo.Focus();
                MessageBox.Show("Este campo esta vacio");
            }
            else if (txtRol.Text == "")
            {
                txtRol.Focus();
                MessageBox.Show("Este campo esta vacio");
            }
            else
            {
                objUsuario.setNombre(txtNombre.Text);
                objUsuario.setApellido(txtApellido.Text);
                objUsuario.setDireccion(txtDireccion.Text);
                objUsuario.setIdentificacion(txtIdentificacion.Text);
                objUsuario.setCelular(txtCelular.Text);
                objUsuario.setCorreo(txtCorreo.Text);
                objUsuario.setRolUsuario(txtRol.Text);

                objUsuario.registrarUsuario();
                MessageBox.Show("Usuario Registrado");
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu formulario = new Menu();
            formulario.Show();
        }
    }
}
