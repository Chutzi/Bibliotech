using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bibliotech
{
    public partial class Form1 : Form
    {
        private string name, puesto, pass, correo;
        public Form1(string name, string puesto, string pass, string correo)
        {
            this.name = name;
            this.puesto = puesto;
            this.pass = pass;
            this.correo = correo;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> Op = new List<string>();
            try
            {
                SqlConnection conexion = new SqlConnection("server=CHUY ; database=Bibliotech ; integrated security = true");
                conexion.Open();
                SqlDataReader myReader = null;
                string sql = "select * from Usuarios left join rol on rol.Id_Rol = Usuarios.Id_Rol left join Rol_Operacion on Rol_Operacion.Id_Rol = Rol.Id_Rol where Correo = '" + correo + "' AND Usuarios.Contrasena='" + pass + "' and rol.Nombre != 'Cliente'";
                SqlCommand myCommand = new SqlCommand(sql, conexion);

                //Ejecutar el comando SQL
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Op.Add(myReader[12].ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            labelUser.Text = puesto+": "+name;

            foreach (var item in Op)
            {
                switch (item)
                {
                    case "1":
                        button1.Enabled = true;
                        break;
                    case "2":
                        button3.Enabled = true;
                        break;
                    case "3":
                        button4.Enabled = true;
                        break;
                    case "4":
                        button2.Enabled = true;
                        break;
                }
            }

            
        }

        private void AbrirFormHija(object formhija)
        {
            if (paneldeinfo.Controls.Count > 0)
                paneldeinfo.Controls.RemoveAt(0);

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            paneldeinfo.Controls.Add(fh);
            paneldeinfo.Tag = fh;
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new BD());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new AddAdmin());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Prestamos());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //6 - SI, 7 - NO
            int op = Convert.ToInt32(MessageBox.Show("Desea salir?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (op == 6)
            {
                Acceso acceso = new Acceso();
                acceso.Show();
                this.Hide();
            }
        }
    }
}
