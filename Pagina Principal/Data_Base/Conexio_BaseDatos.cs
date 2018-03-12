using Npgsql;

namespace Data_Base
{
    public class Conexio_BaseDatos
    {
        public NpgsqlConnection Conexion()
        {
            NpgsqlConnection conexion;

            string servidor = "localhost";
            int puerto = 5432;
            string usuario = "postgres";
            string clave = "postgresql";
            string baseDatos = "Aeropuertos";//nombre de la base en la que voy a trabajar

            string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + clave + ";" + "Database=" + baseDatos;
            conexion = new NpgsqlConnection(cadenaConexion);

            return conexion;
        }
    }
}
