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
    public partial class consulta : Form
    {
        DataTable tablaUsuario = new DataTable();
        Usuario objUsuario = new Usuario();
        public consulta()
        {
            InitializeComponent();
            tablaUsuario = objUsuario.consultarTodosUsuarios();
            dataGridView1.DataSource = tablaUsuario;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Point punto = dataGridView1.CurrentCellAddress;
            int n_fila = punto.Y;
            int n_columna = punto.X;
            modificarDatos(tablaUsuario, n_fila);
        }

        private void modificarDatos(DataTable tabla, int varIndex)
        {
            int index;
            index = varIndex;

            txtNombre.Text = tabla.Rows[index]["Nombre"].ToString();
            txtApellido.Text = tabla.Rows[index]["Apellido"].ToString();
            txtDireccion.Text = tabla.Rows[index]["Direccion"].ToString();
            txtIdentificacion.Text = tabla.Rows[index]["Identificacion"].ToString();
            txtCelular.Text = tabla.Rows[index]["Celular"].ToString();
            txtCorreo.Text = tabla.Rows[index]["Correo"].ToString();
            txtRol.Text = tabla.Rows[index]["Rol"].ToString();
            txtId.Text = tabla.Rows[index]["id_u"].ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
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
                objUsuario.setIdUsuario(txtId.Text);

                objUsuario.actualizarDatosUsuario();
                tablaUsuario = objUsuario.consultarTodosUsuarios();
                dataGridView1.DataSource = tablaUsuario;
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
