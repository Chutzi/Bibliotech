using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Bibliotech
{
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();
        }

        Conexion conexion = new Conexion();
        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=CHUY ; database=Bibliotech ; integrated security = true");
                List<string> Op = new List<string>();
                conexion.Open();
                SqlDataReader myReader = null;
                string sql = "select * from Usuarios left join rol on rol.Id_Rol = Usuarios.Id_Rol left join Rol_Operacion on Rol_Operacion.Id_Rol = Rol.Id_Rol where Correo = '" + textBoxUser.Text + "' AND Usuarios.Contrasena='" + textBoxPass.Text + "' and rol.Nombre != 'Cliente'";
                SqlCommand myCommand = new SqlCommand(sql, conexion);

                //Ejecutar el comando SQL
                myReader = myCommand.ExecuteReader();
                
                if (myReader.Read() && email_bien_escrito(textBoxUser.Text))
                {
                    Form1 form;
                    if (myReader["Id_Rol"].ToString().Equals("1"))
                    {
                        form = new Form1(myReader[1].ToString(), myReader[10].ToString(), myReader[3].ToString(), myReader[2].ToString());
                    }
                    else
                    {
                        form = new Form1(myReader[1].ToString(), myReader[10].ToString(), myReader[3].ToString(), myReader[2].ToString());
                    }
                    
                    form.Show();
                    Hide();
                }
                else
                {
                    if (string.IsNullOrEmpty(textBoxUser.Text) || string.IsNullOrEmpty(textBoxPass.Text))
                        MessageBox.Show("Ingrese completamente los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Usuario o contraseña invalida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Acceso_Load(object sender, EventArgs e)
        {

        }
    }
}
