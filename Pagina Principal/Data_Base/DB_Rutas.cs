using Npgsql;
using System;
using System.Windows.Forms;
using System.Data;

namespace Data_Base
{
    public class DB_Rutas
    {
        static NpgsqlConnection connection;
        static NpgsqlCommand comandos;
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();
        NpgsqlDataAdapter comando2 = new NpgsqlDataAdapter();
        DataSet rellenar = new DataSet();
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
                MessageBox.Show("Error no se pudo conectar a la base de datos. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void editarRuta(int codigo, string rutaOrigen, string rutaDestino, string duracion)
        {
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("UPDATE rutas SET codigo = '" + codigo + "', pais_origen = '" + rutaOrigen + "', pais_destino = '" + rutaDestino + "', duracion = '" + duracion + "' WHERE codigo = '" + codigo + "'", connection);
                comandos.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se modifico con exito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarRuta(int codigo)
        {
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("DELETE FROM rutas WHERE codigo = '" + codigo + "'", connection);
                comandos.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se elimino con exito.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataSet CargarDataGried()
        {
            rellenar.Clear();
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comando2 = new NpgsqlDataAdapter("SELECT codigo, pais_origen, pais_destino, duracion FROM rutas", connection);
                comando2.Fill(rellenar);
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rellenar;
        }
    }
}
