using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace Data_Base
{
    public class DB_Lugar
    {
        static NpgsqlConnection connection;
        static NpgsqlCommand comandos;
        List<object> places = new List<object>();
        List<object> datosPlaces = new List<object>();
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();

        public void agregarLugar(Int32 codigo, string lugar)
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("INSERT INTO lugares (codigo, nombre) VALUES ('" + codigo + "', '" + lugar + "')", connection);
                comandos.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se registro con exito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception e)
            {
                MessageBox.Show("No se puedo conectar a la base de datos." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<object> cargarLugares()
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("SELECT codigo,nombre FROM lugares ORDER BY nombre ASC", connection);
                NpgsqlDataReader dr = comandos.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        places.Add(dr.GetInt32(0));
                        places.Add(dr.GetString(1));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se puedo conectar a la base de datos."+ e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return places;
        }

        public List<object> cargarDatos(int codigolugar)
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("SELECT codigo, nombre FROM lugares WHERE codigo = '" + codigolugar + "'", connection);
                NpgsqlDataReader dr = comandos.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        datosPlaces.Add(dr.GetString(0));
                        datosPlaces.Add(dr.GetString(1));
                    }
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se puedo conectar a la base de datos." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datosPlaces;
        }

        public void infoModificada(int codigo2, string lugar)
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("UPDATE lugares SET nombre = '" + lugar + "' WHERE codigo = '" + codigo2 + "'" , connection);
                comandos.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se modifico con exito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception e)
            {
                MessageBox.Show("No se puedo conectar a la base de datos." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarPlace(Int32 codigo3)
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("DELETE FROM lugares WHERE codigo = '" + codigo3 + "'", connection);
                comandos.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se elimino con exito.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception e )
            {
                MessageBox.Show("No se puedo conectar a la base de datos." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
