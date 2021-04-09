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


        private void BD_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetLibros.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.dataSetLibros.Libros);
            librosBindingSource.DataSource = dataSetLibros.Libros;
            // TODO: esta línea de código carga datos en la tabla 'bibliotechDataSet4.Autores' Puede moverla o quitarla según sea necesario.
            this.autoresTableAdapter.Fill(this.bibliotechDataSet4.Autores);
            autoresBindingSource.DataSource = bibliotechDataSet4.Autores;
            // TODO: esta línea de código carga datos en la tabla 'dataSetEditorial.Editorial' Puede moverla o quitarla según sea necesario.
            this.editorialTableAdapter.Fill(this.dataSetEditorial.Editorial);
            editorialBindingSource.DataSource = dataSetEditorial.Editorial;

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
            
                if (MessageBox.Show("Estas seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    editorialBindingSource.RemoveCurrent();
                    editorialTableAdapter.Update(this.dataSetEditorial.Editorial);
                }
                //else
                this.editorialTableAdapter.Fill(this.dataSetEditorial.Editorial);
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
            if (MessageBox.Show("Estas seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                autoresBindingSource.RemoveCurrent();
                autoresTableAdapter.Update(this.bibliotechDataSet4.Autores);
            }
            //else
            this.autoresTableAdapter.Fill(this.bibliotechDataSet4.Autores);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bNewBook_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Enabled = true;
                tbISBN.Text = "";
                tbTitulo.Text = "";
                tbEdicion.Text = "";
                date.Value = DateTime.Now.AddDays(1);
                tbPag.Text = "";
                tbDesc.Text = "";
                tb_idAutor.Text = "";
                tb_idEdit.Text = "";
                dataSetLibros.Libros.AddLibrosRow(tbISBN.Text, tbTitulo.Text,1,
                date.Value,0,
                tbDesc.Text,1,1);
                
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
            if (MessageBox.Show("Estas seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                librosBindingSource.RemoveCurrent();
                librosTableAdapter.Update(this.dataSetLibros.Libros);
            }
            //else
            this.librosTableAdapter.Fill(this.dataSetLibros.Libros);
        
        }
    }
}
