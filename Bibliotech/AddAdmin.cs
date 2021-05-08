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
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                Validate(); 
                moduloBindingSource.EndEdit();
                moduloTableAdapter.Update(this.bibliotechDataSet.Modulo);
                MessageBox.Show("Guardado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotechDataSet8.Municipios_Estado' Puede moverla o quitarla según sea necesario.
            this.municipios_EstadoTableAdapter.Fill(this.bibliotechDataSet8.Municipios_Estado);
            // TODO: esta línea de código carga datos en la tabla 'bibliotechDataSet5.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter1.Fill(this.bibliotechDataSet5.Usuarios);
            usuariosBindingSource.DataSource = bibliotechDataSet5.Usuarios;
            // TODO: esta línea de código carga datos en la tabla 'bibliotechDataSet3.Rol_Operacion' Puede moverla o quitarla según sea necesario.
            this.rol_OperacionTableAdapter.Fill(this.bibliotechDataSet3.Rol_Operacion);
            // TODO: esta línea de código carga datos en la tabla 'bibliotechDataSet2.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.bibliotechDataSet2.Rol);
            // TODO: esta línea de código carga datos en la tabla 'bibliotechDataSet1.Operaciones' Puede moverla o quitarla según sea necesario.
            this.operacionesTableAdapter.Fill(this.bibliotechDataSet1.Operaciones);
            // TODO: esta línea de código carga datos en la tabla 'bibliotechDataSet.Modulo' Puede moverla o quitarla según sea necesario.
            this.moduloTableAdapter.Fill(this.bibliotechDataSet.Modulo);
            tbMun.Text = comboBox1.SelectedValue.ToString();

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Estas seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    moduloBindingSource.RemoveCurrent();
                    moduloTableAdapter.Update(this.bibliotechDataSet.Modulo);
                }
                else
                    this.moduloTableAdapter.Fill(this.bibliotechDataSet.Modulo);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                operacionesBindingSource.EndEdit();
                operacionesTableAdapter.Update(this.bibliotechDataSet1.Operaciones);
                MessageBox.Show("Save", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Estas seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    operacionesBindingSource.RemoveCurrent();
                    operacionesTableAdapter.Update(this.bibliotechDataSet1.Operaciones);
                }
                else
                    this.operacionesTableAdapter.Fill(this.bibliotechDataSet1.Operaciones);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                rolOperacionBindingSource.EndEdit();
                rol_OperacionTableAdapter.Update(this.bibliotechDataSet3.Rol_Operacion);
                MessageBox.Show("Save", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                rol_OperacionBindingSource.EndEdit();
                rolTableAdapter.Update(this.bibliotechDataSet2.Rol);
                MessageBox.Show("Guardado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Estas seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rol_OperacionBindingSource.RemoveCurrent();
                    rolTableAdapter.Update(this.bibliotechDataSet2.Rol);
                }
                else
                    this.rolTableAdapter.Fill(this.bibliotechDataSet2.Rol);

            }
        }

        private void dataGridView4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Estas seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rolOperacionBindingSource.RemoveCurrent();
                    rol_OperacionTableAdapter.Update(this.bibliotechDataSet3.Rol_Operacion);
                }
                else
                    this.rol_OperacionTableAdapter.Fill(this.bibliotechDataSet3.Rol_Operacion);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                usuariosBindingSource1.EndEdit();
                usuariosTableAdapter1.Update(this.bibliotechDataSet5.Usuarios);
                MessageBox.Show("Guardado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Estas seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    usuariosBindingSource1.RemoveCurrent();
                    usuariosTableAdapter1.Update(this.bibliotechDataSet5.Usuarios);
                }
                else
                    this.usuariosTableAdapter1.Fill(this.bibliotechDataSet5.Usuarios);

            }
        }

        private void textBoxSearc_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection("server=CHUY; database=Bibliotech; Integrated Security=True");
            //string query = "select * from Usuarios where " + comboBoxCol.Text + " like '%" + textBoxSearc.Text + "%'";
            //SqlDataAdapter sqlData = new SqlDataAdapter(query, connection);
            //connection.Open();
            //DataSet data = new DataSet();
            //sqlData.Fill(data, "Usuarios");
            //dataGridView5.DataSource = data;
            //dataGridView5.DataMember = "Usuarios";
            //connection.Close();
           
        }

        private void bNewuser_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Enabled = true;

                tbCorreo.Text = "";
                tbPass.Text = "";
                tbCalle.Text = "";
                tbCol.Text = "";
                tbEdo.Text = "";
                tbRol.Text = "";
                bibliotechDataSet5.Usuarios.AddUsuariosRow(tbName.Text, tbPass.Text, 1, tbCalle.Text, tbCol.Text, 1, 19, tbCorreo.Text);

                usuariosBindingSource1.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuariosBindingSource1.ResetBindings(false);
            }
        }

        private void bSaveuser_Click(object sender, EventArgs e)
        {
            if (!tbRol.Text.Equals("4"))
            {
                try
                {

                    usuariosBindingSource1.EndEdit();
                    usuariosTableAdapter1.Update(this.bibliotechDataSet5.Usuarios);
                    groupBox1.Enabled = false;
                    MessageBox.Show("¡Guardado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usuariosBindingSource1.ResetBindings(false);
                }
            }
            else
            {
                MessageBox.Show("Si desea agregar un cliente vaya al apartado de Prestamos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void bCanceluser_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            usuariosBindingSource1.ResetBindings(false);
        }

        private void bEdituser_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void bDeleteuser_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Estas seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    usuariosBindingSource1.RemoveCurrent();
                    usuariosTableAdapter1.Update(this.bibliotechDataSet5.Usuarios);
                }
                //else
                this.usuariosTableAdapter1.Fill(this.bibliotechDataSet5.Usuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbMun.Text = comboBox1.SelectedValue.ToString();
        }

        private void tbMun_TextChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedValue = tbMun.Text;
        }
    }
}
