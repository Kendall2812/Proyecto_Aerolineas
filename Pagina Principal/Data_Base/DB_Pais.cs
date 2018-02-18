using Npgsql;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Data_Base
{
    public class DB_Pais
    {
        static NpgsqlConnection connection;
        static NpgsqlCommand comandos;
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();
        List<object> paises2 = new List<object>();
        List<object> infomacion = new List<object>();

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
            catch (Exception)
            {
                MessageBox.Show("No se puedo conectar a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<object> nombrePais()
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("SELECT nombre FROM paises", connection);
                NpgsqlDataReader dr = comandos.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        paises2.Add(dr.GetString(0));
                    }
                }
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return paises2;
        }

        public List<object> informPais(string pais)
        {
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("SELECT codigo, nombre, bandera FROM paises WHERE nombre = '" + pais + "'", connection);
                NpgsqlDataReader dr = comandos.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        infomacion.Add(dr.GetInt32(0));
                        infomacion.Add(dr.GetString(1));
                        infomacion.Add(dr.GetString(2));
                    }
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return infomacion;
        }

        public void infoModificada(int codigo, string nombre, string direccionImagen)
        {
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("UPDATE paises SET codigo = '" + codigo + "', nombre = '" + nombre + "', bandera = '" + direccionImagen + "' WHERE codigo = '" + codigo + "'" , connection);
                comandos.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se modifico con exito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarPais(int codigo)
        {
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("DELETE FROM paises WHERE codigo = '" + codigo + "'", connection);
                comandos.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se elimino con exito.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
