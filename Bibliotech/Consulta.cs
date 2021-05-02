using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotech
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }
        Conexion c = new Conexion();
        private void Consulta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSViewMultas.v_Multas' Puede moverla o quitarla según sea necesario.
            this.v_MultasTableAdapter.Fill(this.dSViewMultas.v_Multas);
            // TODO: esta línea de código carga datos en la tabla 'dSViewEmpleados.v_Empleados' Puede moverla o quitarla según sea necesario.
            this.v_EmpleadosTableAdapter.Fill(this.dSViewEmpleados.v_Empleados);
            // TODO: esta línea de código carga datos en la tabla 'dSViewLibros.v_Libros' Puede moverla o quitarla según sea necesario.
            this.v_LibrosTableAdapter.Fill(this.dSViewLibros.v_Libros);
            comboBox1.Text = "isbn";
            comboBox2.Text = "id_usuario";
            comboBox3.Text = "Id_Cliente";
        }
        private void Filter(DataGridView dataGridView, string query, string tabla)
        {
            try
            {
                dataGridView.DataSource = c.ReaderQueryT(query, tabla);
                dataGridView.DataMember = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Filter(dataGridView1, "select * from v_Libros where " + comboBox1.Text + " like '%" + textBox1.Text + "%'", "v_Libros");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Filter(dataGridView2, "select * from v_Empleados where " + comboBox2.Text + " like '%" + textBox2.Text + "%'", "v_Empleados");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!comboBox3.Text.Equals("Fecha_Entrega"))
            {
                Filter(dataGridView3, "select * from v_Multas where " + comboBox3.Text + " like '%" + textBox3.Text + "%'", "v_Multas");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label6.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy") + dateTimePicker2.Value.Date.ToString("dd/MM/yyyy");
            if (comboBox3.Text.Equals("Fecha_Entrega"))
            {
                Filter(dataGridView3, "select * from v_Multas where Fecha_Entrega between '" + dateTimePicker1.Value.Date.ToString("dd/MM/yyyy") + "' and '" + dateTimePicker2.Value.Date.ToString("dd/MM/yyyy") + "'", "v_Multas");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text.Equals("Fecha_Entrega"))
            {
                textBox3.Enabled = false;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else
            {
                textBox3.Enabled = true;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
