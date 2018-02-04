using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsql
{
    class Conexion
    {
        //Conexion a la base de datos
        private string hostname=Environment.GetEnvironmentVariable("SQLSERVER_HOST")??"localhost:1433";
        private string cadena = "Data Source=localhost ;Initial Catalog=PDHN;User Id=sa;Password=Feralexis007;MultipleActiveResultSets=True";
        public SqlConnection con;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;
        public DataTable dt;

        //Metodo para la consulta a la base de datos
        public DataTable consultar(string tabla)
        {
            con = new SqlConnection(cadena);
            string sql = "SELECT * FROM "+ tabla;
            da = new SqlDataAdapter(sql, con);
            da.Fill(ds,tabla);
            dt = new DataTable();
            dt = ds.Tables[tabla];
            return dt;
        }

        //Consulta para buscar registro duplicados
        public bool consultar2(string campo1,string tabla,string campo2, string campo3)
        {
            con = new SqlConnection(cadena);
            string sql = "SELECT " + campo1+" FROM "+tabla+ " WHERE "+campo2 +"='"+campo3+"'";
            con.Open();
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool Insertar(string sql)
        {
            con = new SqlConnection(cadena);
            con.Open();
            comando = new SqlCommand(sql,con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Metodo para actualizar los registros
        public bool Actualizar(string tabla,string campo,string condicion)
        {
            con = new SqlConnection(cadena);
            con.Open();
            string sql = "UPDATE "+tabla+" SET "+campo+" WHERE "+condicion;
            comando = new SqlCommand(sql, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Eliminar(string tabla, string condicion)
        {
            con = new SqlConnection(cadena);
            con.Open();
            string sql = "DELETE FROM  " + tabla + " WHERE " + condicion ;
            comando = new SqlCommand(sql, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable consultar3(string tabla,string campo1,string campo2)
        {
            con = new SqlConnection(cadena);
            string sql = "SELECT * FROM " + tabla +" WHERE "+campo1+" LIKE '%"+campo2+"%'";
            da = new SqlDataAdapter(sql, con);
            da.Fill(ds, tabla);
            dt = new DataTable();
            dt = ds.Tables[tabla];
            return dt;
        }

    }
}
