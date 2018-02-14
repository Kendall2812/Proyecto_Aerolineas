using Npgsql;
using System;
using System.Windows.Forms;

namespace Data_Base
{
    public class Base_datos
    {
        static NpgsqlConnection conexion;
        static NpgsqlCommand comandos;
        bool valor;

        static void Main(string[] args)
        {
        }

        public void Conexion()
        {
            string servidor = "localhost";
            int puerto = 5432;
            string usuario = "postgres";
            string clave = "postgresql";
            string baseDatos = "Aeropuertos";//nombre de la base en la que voy a trabajar

            string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + clave + ";" + "Database=" + baseDatos;
            conexion = new NpgsqlConnection(cadenaConexion);
        }

        public bool cosultarUsuario(string usuario, string clave)
        {
            Conexion();
            try
            {
                conexion.Open();
                comandos = new NpgsqlCommand("SELECT tipo_acceso FROM admin_user where name = '" + usuario + "' and password = '" + clave +"'", conexion);
                NpgsqlDataReader dr = comandos.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        valor = dr.GetBoolean(0);
                    }
                }
                else
                {
                    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se puedo conectar a la base de datos." + e , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return valor;
        }
    }
}
