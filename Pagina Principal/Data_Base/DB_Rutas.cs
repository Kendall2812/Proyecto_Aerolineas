using Npgsql;
using System;
using System.Windows.Forms;

namespace Data_Base
{
    public class DB_Rutas
    {
        static NpgsqlConnection connection;
        static NpgsqlCommand comandos;
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();
        //List<object> paises2 = new List<object>();
        //List<object> infomacion = new List<object>();

        public void agregarRuta(int codigo, string rutaOrigen, string rutaDestino, string duracion)
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("INSERT INTO rutas (codigo, pais_origen, pais_destino, duracion) VALUES ('" + codigo + "', '" + rutaOrigen + "', '" + rutaDestino + "' ,'" + duracion + "')", connection);
                comandos.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se registro con exito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {

            }
        }

        public void editarRuta()
        {

        }

        public void eliminarRuta()
        {

        }
    }
}
