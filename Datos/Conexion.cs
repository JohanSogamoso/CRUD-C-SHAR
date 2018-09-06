using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
    public class Conexion
    {
        static MySqlConnection conexion = new MySqlConnection();
        private string myConnectionString = "server=localhost;database=parcial;uid=root;pwd=; SslMode = none";
        private string sentenciaSql = "";
        static MySqlCommand comando = new MySqlCommand();
        static MySqlDataReader lecturaDatos;
        static DataTable tablaDatos = new DataTable();
        public void conectar()
        {
            if (conexion.State != ConnectionState.Open)
            {
                desconectar();
            }

            try
            {
                conexion.ConnectionString = myConnectionString;
                conexion.Open();
                Console.WriteLine("Connection Open ! ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! ");
                throw (ex);
            }            
        }

        public void setSentenciaSql(String consulta)
        {
            this.sentenciaSql = consulta;
        }

        public void desconectar()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void insertarDatos()
        {
            try
            {
                comando = new MySqlCommand(sentenciaSql, conexion);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public DataTable consultarDatos()
        {
            try
            {
                comando = new MySqlCommand(sentenciaSql, conexion);
                lecturaDatos = comando.ExecuteReader();
                tablaDatos.Clear();                
                tablaDatos.Load(lecturaDatos);
                lecturaDatos.Close();

                return tablaDatos;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void actualizaDatos()
        {
            try
            {
                comando = new MySqlCommand(sentenciaSql, conexion);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }


    }
}
