using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bibliotech
{
    public class Conexion
    {
        static string conexion = "server=CHUY; database=Bibliotech; Integrated Security=True";
        SqlConnection connection;
        public Conexion()
        {
            connection = new SqlConnection(conexion);
        }
        public void Conectar()
        {
            connection.Open();
            //MessageBox.Show("Conexion exitosa");
        }

        public void Desconectar()
        {
            connection.Close();
            //MessageBox.Show("Conexion Cerrada");
        }

        public void LLenarTabla(DataGridView dataGridView)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Select * from Modulo", connection);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            System.Data.DataTable tabla = new System.Data.DataTable();
            adp.Fill(tabla);
            dataGridView.DataSource = tabla;
            Desconectar();
        }
    }
}
