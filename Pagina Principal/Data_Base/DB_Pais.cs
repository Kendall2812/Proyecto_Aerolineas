using Npgsql;
using System;
using System.Windows.Forms;

namespace Data_Base
{
    public class DB_Pais
    {
        static NpgsqlConnection connection;
        static NpgsqlCommand comandos;
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();

        public void guardarPais(int codigo, string nombre, string direccionImagen)
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("INSERT INTO paises (codigo,nombre,bandera) VALUES ('" + codigo + "', '" + nombre + "', '" + direccionImagen + "')", connection);
                comandos.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se registro con exito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception e)
            {
                MessageBox.Show("No se puedo conectar a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
