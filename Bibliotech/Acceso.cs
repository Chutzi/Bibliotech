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
                    return true;
                else
                    return false;
                
            }
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader myReader = conexion.ReaderQuery("select * from Usuarios left join rol on rol.Id_Rol = Usuarios.Id_Rol left join Rol_Operacion on Rol_Operacion.Id_Rol = Rol.Id_Rol where Correo = '" + textBoxUser.Text + "' AND Usuarios.Contrasena='" + textBoxPass.Text + "' and rol.Nombre != 'Cliente'");

                if (myReader.Read() && email_bien_escrito(textBoxUser.Text))
                {
                    Form1 form;
                    if (myReader["Id_Rol"].ToString().Equals("1"))                   
                        form = new Form1(myReader[1].ToString(), myReader[10].ToString(), myReader[3].ToString(), myReader[2].ToString());                   
                    else  
                        form = new Form1(myReader[1].ToString(), myReader[10].ToString(), myReader[3].ToString(), myReader[2].ToString());
                    
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

        private void Acceso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotechDataSet8.Municipios_Estado' Puede moverla o quitarla según sea necesario.
            this.municipios_EstadoTableAdapter.Fill(this.bibliotechDataSet8.Municipios_Estado);
            toolTip1.SetToolTip(pictureBox1, "¡Bienvenido a Bibliotech!");
            toolTip1.SetToolTip(pictureBox2, "Apagar");
            toolTip1.SetToolTip(button1, "Inicia Sesión");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                textBoxPass.PasswordChar = '●';
            }
            else
                if (textBoxPass.Text != "")
            {
                textBoxPass.PasswordChar = '\0';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El registro de un nuevo empleado se lleva a cabo en el modulo de seguridad, espere a que sea incorporado correctamente, si no ha sido registrado acuda personalmente con el administrador para darlo de alta\n¡Gracias!", 
                "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bibliotech\nUbicación: Monterrey, Nuevo León\nHorario: LUN - SAB, 8 am - 8 pm",
                              "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
