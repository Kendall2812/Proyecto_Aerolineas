using Npgsql;
using System;
using System.Windows.Forms;

namespace Data_Base
{
    public class UserAdmin
    {
        static NpgsqlConnection connection;
        static NpgsqlCommand comandos;
        string valor;
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();

        static void Main(string[] args)
        {
        }

        public string cosultarUsuario(string usuario, string clave)
        {

            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("SELECT tipo FROM admin_user where cedula = '" + usuario + "' and password = '" + clave +"'", connection);
                NpgsqlDataReader dr = comandos.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        valor = dr.GetString(0);
                    }
                    connection.Close();
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
