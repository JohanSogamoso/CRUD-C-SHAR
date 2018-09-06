using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Windows.Forms;
using System.Data;

namespace Logica
{
    public class Usuario
    {
        private string idUsuario;
        private string nombre;
        private string apellido;
        private string direccion;
        private string identificacion;        
        private string celular;
        private string correo;
        private string rol;

        Datos.Conexion objConexion = new Datos.Conexion();
        public void setIdUsuario(string id)
        {
            this.idUsuario = id;
        }

        public string getIdUsuario()
        {
            return idUsuario;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public string getApellido()
        {
            return apellido;
        }

        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }

        public string getDireccion()
        {
            return direccion;
        }

        public void setIdentificacion(string identificacion)
        {
            this.identificacion = identificacion;
        }

        public string getIdentificacion()
        {
            return identificacion;
        }

        public void setCelular(string celular)
        {
            this.celular = celular;
        }

        public string getCelular()
        {
            return celular;
        }

        public void setCorreo(string correo)
        {
            this.correo = correo;
        }

        public string getCorreo()
        {
            return correo;
        }

        public void setRolUsuario(string rol)
        {
            this.rol = rol;
        }

        public string getRolUsuario()
        {
            return rol;
        }

        public void registrarUsuario()
        {

            try
            {
                objConexion.desconectar();
                objConexion.conectar();
                string sentencia;
                sentencia = "insert into usuario(Nombre, Apellido, Direccion, Identificacion, Celular, Correo, Rol) values ('"
                    + nombre + "','" + apellido + "','" + direccion + "'," + identificacion + ", " + celular + ", '" + correo + "','" + rol + "')";
                objConexion.setSentenciaSql(sentencia);
                objConexion.insertarDatos();
                objConexion.desconectar();
            }
            catch (Exception e)
            {
                objConexion.desconectar();
                throw (e);
            }

        }

        public DataTable consultarTodosUsuarios()
        {
            string sentenciaConsultarclaseUsuario = "";
            try
            {
                objConexion.desconectar();
                objConexion.conectar();
                sentenciaConsultarclaseUsuario = "select * from usuario";
                objConexion.setSentenciaSql(sentenciaConsultarclaseUsuario);
                return objConexion.consultarDatos();
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show("Error al consultar los usuarios");
                MessageBox.Show(ex.Message);
                return objConexion.consultarDatos();
            }
        }

        public void actualizarDatosUsuario()
        {
            string sentencia;
            sentencia = "Update usuario set Nombre = '" + nombre + "'," +
                " Apellido = '" + apellido + "', Direccion= '" + direccion + "',Identificacion = " + identificacion +
                ", Celular= " + celular + ", Correo= '" + correo + "', Rol = '" + rol +
                "'  where id_u= '" + idUsuario + "' ";
            objConexion.setSentenciaSql(sentencia);
            objConexion.actualizaDatos();

        }

    }
}
