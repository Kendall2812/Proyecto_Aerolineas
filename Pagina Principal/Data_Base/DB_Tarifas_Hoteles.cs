using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace Data_Base
{
    public class DB_Tarifas_Hoteles
    {
        DataSet datosTarifas = new DataSet();
        static NpgsqlConnection connection;
        static NpgsqlCommand comandos;
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();
        NpgsqlDataAdapter comando2 = new NpgsqlDataAdapter();
        List<object> informacioTarifas = new List<object>();

        public void insertarTarifa(int codigoTarifa1, int precioTarifa1)
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("INSERT INTO tarifas_hoteles (codigo,precio) VALUES ('" + codigoTarifa1 + "', '" + precioTarifa1+ "')", connection);
                comandos.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se guardo con exito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void editarTarifa(int codigoTarifa2, int precioTarifa2)
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("UPDATE tarifas_hoteles SET codigo = '" + codigoTarifa2 + "', precio = '" + precioTarifa2 + "' WHERE codigo = '" + codigoTarifa2 + "'", connection);
                comandos.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("El cambio se realizo con exito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarTarifa(int codigoTarifa)
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("DELETE FROM tarifas_hoteles WHERE codigo = '" + codigoTarifa + "'", connection);
                comandos.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se elimino con exito.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataSet cargarTarifas_GriedView()
        {
            datosTarifas.Clear();
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comando2 = new NpgsqlDataAdapter("SELECT codigo, precio FROM tarifas_hoteles", connection);
                comando2.Fill(datosTarifas);
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datosTarifas;
        }

        public List<object> infoTarifas()
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("SELECT codigo, precio FROM tarifas_hoteles", connection);
                NpgsqlDataReader dr = comandos.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        informacioTarifas.Add(dr.GetInt32(0));
                        informacioTarifas.Add(dr.GetInt32(1));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return informacioTarifas;
        }
    }
}
