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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotechDataSet8.Municipios_Estado' Puede moverla o quitarla según sea necesario.
            this.municipios_EstadoTableAdapter.Fill(this.bibliotechDataSet8.Municipios_Estado);
            
            // TODO: esta línea de código carga datos en la tabla 'bibliotechDataSet6.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.bibliotechDataSet6.Cliente);
            clienteBindingSource.DataSource = bibliotechDataSet6.Cliente;

            tbMun.Text = comboBox1.SelectedValue.ToString();
        }
        private void bNewuser_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Enabled = true;

                tbCorreo.Text = "";
                tbName.Text = "";
                tbCalle.Text = "";
                tbCol.Text = "";
                tbEdo.Text = "19";
                tbMun.Text = "1";

                bibliotechDataSet6.Cliente.AddClienteRow(tbName.Text, tbCalle.Text, tbCalle.Text, tbCol.Text, 19, 1);

                clienteBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clienteBindingSource.ResetBindings(false);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usuariosTableAdapter.FillBy(this.bibliotechDataSet5.Usuarios);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usuariosTableAdapter.FillBy1(this.bibliotechDataSet5.Usuarios);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usuariosTableAdapter.FillBy2(this.bibliotechDataSet5.Usuarios);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bSaveuser_Click(object sender, EventArgs e)
        {
                try
                {

                    clienteBindingSource.EndEdit();
                    clienteTableAdapter.Update(this.bibliotechDataSet6.Cliente);
                    groupBox1.Enabled = false;
                MessageBox.Show("¡Guardado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clienteBindingSource.ResetBindings(false);
                }
            
        }

        private void bCanceluser_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            clienteBindingSource.ResetBindings(false);
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
                    clienteBindingSource.RemoveCurrent();
                    clienteTableAdapter.Update(this.bibliotechDataSet6.Cliente);
                }
                //else
                this.clienteTableAdapter.Fill(this.bibliotechDataSet6.Cliente);
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

        private void Clientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Impedir que el formulario se cierre pulsando X o Alt + F4
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    this.Hide();
                    break;
            }
        }
    }
}
