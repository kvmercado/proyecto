using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public class BaseDeDatos
    {
        string cadena = "Data source=localhost;Initial Catalog=colegio;Integrated Security=True";
        public SqlConnection conexion = new SqlConnection();
        public BaseDeDatos()
        {
            conexion.ConnectionString = cadena;
        }

        public Boolean conectar()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion con la base de datos establecida");
                return true;
            }
            catch (Exception)
            {      
                Console.WriteLine("Error en la conexion de la base de datos");
                return false;
                throw;       
            }
        }

        public void desconectar()
        {
            conexion.Close();
        }


        public void ejecutar(string sentencia)
        {
            try
            {
                conectar();
                SqlCommand query = new SqlCommand(sentencia,conexion);
                query.ExecuteNonQuery();
                Console.WriteLine("Se ejecuto una SQL");
                desconectar();
            }
            catch (Exception)
            {
                Console.WriteLine("No se ejecuto la consulta");
                throw;
            }

        }

        public DataTable select(string sentencia)
        {
            try
            {
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sentencia, conexion);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception e)
            {
                return null;
                throw;
            }
        }
    }
}
