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
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Solicitud soli = new Solicitud(int.Parse(tbIdPresta.Text));
            soli.Show();

        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotechDataSet7.Prestamos' Puede moverla o quitarla según sea necesario.
            this.prestamosTableAdapter.Fill(this.bibliotechDataSet7.Prestamos);
            // TODO: esta línea de código carga datos en la tabla 'dataSetPresta.Prestamos' Puede moverla o quitarla según sea necesario.

            prestamosBindingSource1.DataSource = bibliotechDataSet7.Prestamos;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox2.Enabled = true;
                tbIdCliente.Text = "";
                tbIdPresta.Text = "";
                bibliotechDataSet7.Prestamos.AddPrestamosRow(1);
                prestamosBindingSource1.MoveLast();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                prestamosBindingSource1.ResetBindings(false);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                prestamosBindingSource1.EndEdit();
                prestamosTableAdapter.Update(bibliotechDataSet7.Prestamos);
                groupBox2.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                prestamosBindingSource1.ResetBindings(false);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            prestamosBindingSource1.ResetBindings(false);
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                prestamosBindingSource1.RemoveCurrent();
                prestamosTableAdapter.Update(this.bibliotechDataSet7.Prestamos);
            }
            //else
            this.prestamosTableAdapter.Fill(this.bibliotechDataSet7.Prestamos);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
