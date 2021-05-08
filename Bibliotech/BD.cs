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
    public partial class BD : Form
    {
        public BD()
        {
            InitializeComponent();
        }
        public int count = 0;

        private void BD_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotechDataSet13.Genero' Puede moverla o quitarla según sea necesario.
            this.generoTableAdapter1.Fill(this.bibliotechDataSet13.Genero);
            // TODO: esta línea de código carga datos en la tabla 'bibliotechDataSet12.Editorial' Puede moverla o quitarla según sea necesario.
            this.editorialTableAdapter1.Fill(this.bibliotechDataSet12.Editorial);
            // TODO: esta línea de código carga datos en la tabla 'bibliotechDataSet11.Autores' Puede moverla o quitarla según sea necesario.
            this.autoresTableAdapter1.Fill(this.bibliotechDataSet11.Autores);
            // TODO: esta línea de código carga datos en la tabla 'dSgen.Genero' Puede moverla o quitarla según sea necesario.
            this.generoTableAdapter.Fill(this.dSgen.Genero);
            // TODO: esta línea de código carga datos en la tabla 'bibliotechDataSet10.Almacen_Libros' Puede moverla o quitarla según sea necesario.
            this.almacen_LibrosTableAdapter.Fill(this.bibliotechDataSet10.Almacen_Libros);
            // TODO: esta línea de código carga datos en la tabla 'bibliotechDataSet9.Almacen' Puede moverla o quitarla según sea necesario.
            this.almacenTableAdapter.Fill(this.bibliotechDataSet9.Almacen);
            // TODO: esta línea de código carga datos en la tabla 'dataSetLibros.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.dataSetLibros.Libros);
            librosBindingSource.DataSource = dataSetLibros.Libros;
            // TODO: esta línea de código carga datos en la tabla 'bibliotechDataSet4.Autores' Puede moverla o quitarla según sea necesario.
            this.autoresTableAdapter.Fill(this.bibliotechDataSet4.Autores);
            autoresBindingSource.DataSource = bibliotechDataSet4.Autores;
            // TODO: esta línea de código carga datos en la tabla 'dataSetEditorial.Editorial' Puede moverla o quitarla según sea necesario.
            this.editorialTableAdapter.Fill(this.dataSetEditorial.Editorial);
            editorialBindingSource.DataSource = dataSetEditorial.Editorial;
            tb_idAutor.Text = comboBox1.SelectedValue.ToString();
            tb_idEdit.Text = comboBox2.SelectedValue.ToString();
            textBox4.Text = comboBox3.SelectedValue.ToString();

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox3.Enabled = true;
                tbNombreEd.Text = "";
                tbTel.Text = "";
                tbCorreo.Text = "";
                dataSetEditorial.Editorial.AddEditorialRow(tbNombreEd.Text, tbTel.Text, tbCorreo.Text);
                editorialBindingSource.MoveLast();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editorialBindingSource.ResetBindings(false);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                editorialBindingSource.EndEdit();
                editorialTableAdapter.Update(this.dataSetEditorial.Editorial);
                groupBox3.Enabled = false;
                MessageBox.Show("¡Guardado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editorialBindingSource.ResetBindings(false);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = false;
            editorialBindingSource.ResetBindings(false);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
        }

        private void textBoxSearchEd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(textBoxSearchEd.Text))
                {
                    dataGridView2.DataSource = editorialBindingSource;
                }
                else
                {
                    var query = from ed in this.dataSetEditorial.Editorial
                                where ed.Id_Editorial.ToString().Contains(textBoxSearchEd.Text) ||
                                      ed.Nombre.Contains(textBoxSearchEd.Text) ||
                                      ed.Telefono.Contains(textBoxSearchEd.Text) ||
                                      ed.Correo.Contains(textBoxSearchEd.Text)
                                select ed;
                    dataGridView2.DataSource = query.ToList();
                }
            }
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Estas seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    editorialBindingSource.RemoveCurrent();
                    editorialTableAdapter.Update(this.dataSetEditorial.Editorial);
                }
                //else
                this.editorialTableAdapter.Fill(this.dataSetEditorial.Editorial);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void buttonNewAutor_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox2.Enabled = true;
                tbNombreA.Text = "";
                tbAP.Text = "";
                tbAM.Text = "";
                tbNacion.Text = "";
                bibliotechDataSet4.Autores.AddAutoresRow(tbNombreA.Text, tbAP.Text, tbAM.Text, tbNacion.Text);
                autoresBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                autoresBindingSource.ResetBindings(false);
            }
        }

        private void buttonSaveAutor_Click(object sender, EventArgs e)
        {
            try
            {
                autoresBindingSource.EndEdit();
                autoresTableAdapter.Update(bibliotechDataSet4.Autores);
                groupBox2.Enabled = false;
                MessageBox.Show("¡Guardado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                autoresBindingSource.ResetBindings(false);
            }
        }

        private void buttoncancelAutor_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            autoresBindingSource.ResetBindings(false);
        }

        private void buttonEditAutor_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void buttonDeleteAutor_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Estas seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    autoresBindingSource.RemoveCurrent();
                    autoresTableAdapter.Update(this.bibliotechDataSet4.Autores);
                }
                //else
                this.autoresTableAdapter.Fill(this.bibliotechDataSet4.Autores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bNewBook_Click(object sender, EventArgs e)
        {
            count = 1;
            try
            {
                groupBox1.Enabled = true;
                tbISBN.Text = "1";
                tbTitulo.Text = "Inserte titulo";
                tbEdicion.Text = "1";
                date.Value = DateTime.Now.AddDays(1);
                tbPag.Text = "1";
                tbDesc.Text = "Describa";
                tb_idAutor.Text = "1";
                tb_idEdit.Text = "3";
                textBox4.Text = "1";
                dataSetLibros.Libros.AddLibrosRow(tbISBN.Text, tbTitulo.Text,1,
                date.Value,0,
                tbDesc.Text,1,1,1);
                
                librosBindingSource.MoveLast();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                librosBindingSource.ResetBindings(false);
            }
        }
        
        private void bSaveBook_Click(object sender, EventArgs e)
        {
            try
            {
                librosBindingSource.EndEdit();
                librosTableAdapter.Update(dataSetLibros.Libros);
                groupBox1.Enabled = false;

                //Trigger
                if (count == 1)
                {
                    bibliotechDataSet10.Almacen_Libros.AddAlmacen_LibrosRow(tbISBN.Text, 1, 1);
                    almacenLibrosBindingSource3.MoveLast();
                    try
                    {
                        almacenLibrosBindingSource3.EndEdit();
                        almacen_LibrosTableAdapter.Update(bibliotechDataSet10.Almacen_Libros);
                        groupBox4.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        almacenLibrosBindingSource3.ResetBindings(false);
                    }
                    count = 2;
                }
                MessageBox.Show("¡Guardado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                librosBindingSource.ResetBindings(false);
            }
        }

        private void bCancelBook_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            librosBindingSource.ResetBindings(false);
        }

        private void bEditBook_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void bDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Estas seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    librosBindingSource.RemoveCurrent();
                    librosTableAdapter.Update(this.dataSetLibros.Libros);
                }
                //else
                this.librosTableAdapter.Fill(this.dataSetLibros.Libros);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        
        }

        private void buttonAL_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox4.Enabled = true;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                bibliotechDataSet10.Almacen_Libros.AddAlmacen_LibrosRow("", 1, 1);

                almacenLibrosBindingSource3.MoveLast();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                almacenLibrosBindingSource3.ResetBindings(false);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                almacenLibrosBindingSource3.EndEdit();
                almacen_LibrosTableAdapter.Update(bibliotechDataSet10.Almacen_Libros);
                groupBox4.Enabled = false;
                MessageBox.Show("¡Guardado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                almacenLibrosBindingSource3.ResetBindings(false);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox4.Enabled = false;
            almacenLibrosBindingSource3.ResetBindings(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Estas seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    almacenLibrosBindingSource3.RemoveCurrent();
                    almacen_LibrosTableAdapter.Update(this.bibliotechDataSet10.Almacen_Libros);
                }
                //else
                this.almacen_LibrosTableAdapter.Fill(this.bibliotechDataSet10.Almacen_Libros);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox5.Enabled = true;
                textBox7.Text = "";
                textBox6.Text = "";
                dSgen.Genero.AddGeneroRow(textBox6.Text);
                generoBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                generoBindingSource.ResetBindings(false);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                generoBindingSource.EndEdit();
                generoTableAdapter.Update(dSgen.Genero);
                groupBox5.Enabled = false;
                MessageBox.Show("¡Guardado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                generoBindingSource.ResetBindings(false);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox5.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox5.Enabled = false;
            generoBindingSource.ResetBindings(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Estas seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    generoBindingSource.RemoveCurrent();
                    generoTableAdapter.Update(dSgen.Genero);

                }
                //else
                this.generoTableAdapter.Fill(this.dSgen.Genero);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_idAutor.Text = comboBox1.SelectedValue.ToString();
        }

        private void tb_idAutor_TextChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedValue = tb_idAutor.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_idEdit.Text = comboBox2.SelectedValue.ToString();
        }

        private void tb_idEdit_TextChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedValue = tb_idEdit.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            comboBox3.SelectedValue = textBox4.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = comboBox3.SelectedValue.ToString();
        }
    }
}
