using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Bibliotech
{
    public class Conexion
    {
        private string con;
        public Conexion()
        {
            this.con = "server=CHUY; database=Bibliotech; Integrated Security=True";
        }
        public SqlDataReader ReaderQuery(string sql)
        {
            SqlConnection conexion = new SqlConnection(con);

            conexion.Open();
            SqlDataReader myReader = null;

            SqlCommand myCommand = new SqlCommand(sql, conexion);

            //Ejecutar el comando SQL
            myReader = myCommand.ExecuteReader();

            return myReader;
        }

        public DataSet ReaderQueryT(string sql, string vista)
        {
            SqlConnection conexion = new SqlConnection(con);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql, con);

            conexion.Open();
            DataSet ds = new DataSet();

            sqlData.Fill(ds, vista);

            return ds;
        }


    }
}
