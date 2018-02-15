using Npgsql;
using System;
using System.Windows.Forms;

namespace Data_Base
{
    public class UserAdmin
    {
        static NpgsqlConnection connection;
        static NpgsqlCommand comandos;
        bool valor;
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();

        static void Main(string[] args)
        {
        }

        public bool cosultarUsuario(string usuario, string clave)
        {

            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("SELECT tipo_acceso FROM admin_user where name = '" + usuario + "' and password = '" + clave +"'", connection);
                NpgsqlDataReader dr = comandos.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        valor = dr.GetBoolean(0);
                    }
                    connection.Close();
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
