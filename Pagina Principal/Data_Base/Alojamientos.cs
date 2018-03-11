using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Data_Base;
using Npgsql;
using System.Data;
using System.Drawing;

namespace Data_Base
{
    public class Alojamientos
    {
      
        NpgsqlConnection conexion;
        static NpgsqlConnection connection;
        static NpgsqlCommand comandos;
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();
        String [] infomacion= new String[] { };


        public void cargarDatos(string dato, DataGridView dataGridView1)
        {
            try
            {
                dataGridView1.Rows.Clear();
                //Image img;
                connection = conexion1.Conexion();
                connection.Open();
                comandos = new NpgsqlCommand("SELECT ho.codigo, ho.nombre, ho.lugar, pa.nombre, ta.precio "  
                  +" FROM hoteles AS ho JOIN lugares AS lu ON ho.lugar = lu.nombre JOIN paises AS pa ON pa.codigo = lu.codigo_pais JOIN tarifas_hoteles AS ta ON ta.codigo = ho.codigotarifahotel ", connection);
                NpgsqlDataReader dr = comandos.ExecuteReader();
              
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (dato.Equals(dr.GetString(1))) //verifica por nombre del hotel
                        {
                            //THEN AD ROW DATA 
                            Object[] row = new Object[] { dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4) }; ///, dr.GetString(5)
                            dataGridView1.Rows.Add(row);
                            break;
                        }
                        else if (dato.Equals(dr.GetString(2)))//verifica por nombre del lugar 
                        {
                            //THEN AD ROW DATA 
                            Object[] row = new Object[] { dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4) }; ///, dr.GetString(5)
                            dataGridView1.Rows.Add(row);
                            break;
                        }           
                    }
                    if (dr.Read() == false)
                    {
                        //Busqueda por pais
                        connection.Close();
                        connection.Open();

                        comandos = new NpgsqlCommand("SELECT ho.codigo, ho.nombre, ho.lugar, pa.nombre, ta.precio  "
                             + " FROM hoteles AS ho JOIN lugares AS lu ON ho.lugar = lu.nombre JOIN paises AS pa ON pa.codigo = lu.codigo_pais JOIN tarifas_hoteles AS ta ON ta.codigo = ho.codigotarifahotel \n"
                             + " WHERE pa.nombre = '" + dato + "'", connection);
                        NpgsqlDataReader rd = comandos.ExecuteReader();
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                //THEN AD ROW DATA           
                                Object[] row = new Object[] { rd.GetInt32(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4) };
                                dataGridView1.Rows.Add(row);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encotraron resultados de la busqueda. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }

}
    


