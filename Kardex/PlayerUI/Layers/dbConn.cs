using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Kardex.Layers;


namespace Kardex.Layers
{
    
    class dbConn
    {
        SqlConnection conn;
         
        //DAL d = new DAL();

        public dbConn()
        {
            //Se le asigna al objeto de SqlConnection la direccion de la instancia de la BD
            conn = new SqlConnection("server=DESKTOP-2BBG8OF; database=Kardex ; integrated security =true");

        }

        public DataTable ExcQryDt(string query)
        {
            //Creamos objeto DataTable y SqlCommand
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();

            //Le agregamos a la instncia cmd su query, tiempo de ejecucion y donde se va a ejecutar
            cmd.CommandText = query;
            cmd.CommandTimeout = 0;
            cmd.Connection = conn;

            //Abrimos la coneccion, cargamos iformacion al DataTable y cerramos coneccion.
            conn.Open();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            return dt;

        }

        public void ExcQry(string query)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandTimeout = 0;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
  
    }
}
