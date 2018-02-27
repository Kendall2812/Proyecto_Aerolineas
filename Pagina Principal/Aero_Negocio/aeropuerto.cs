using System;
using Data_Base;
using Npgsql;

namespace Aero_Negocio
{
    
    public class aeropuerto
    {
        DB_Aeropuertos aero = new DB_Aeropuertos();
        static NpgsqlConnection connection;
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();
        public void insertarAero(Int32 codigo, string nombre, string locali, string iata)
        {
            aero.agregarAeropuerto(codigo, nombre,locali,iata);
        }
        public void EliminarAro(string sql)
        {
            connection = conexion1.Conexion();        
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
