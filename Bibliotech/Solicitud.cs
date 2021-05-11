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

namespace Bibliotech
{
    public partial class Solicitud : Form
    {
        private int IdPresta;
        Conexion conexion = new Conexion();
        int canti = 0;
        public Solicitud(int IdPresta)
        {
            this.IdPresta = IdPresta;
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbMonto.Enabled = true;
            }
            else
            {
                tbMonto.Enabled = false;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            canti = int.Parse(tbCant.Text);
            var days = dateEntrega.Value - dateInicio.Value;
            tbDias.Text = days.Days.ToString();
            groupBox2.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numero = random.Next(1, 100000);
            try
            {
                groupBox2.Enabled = true;
                tbISBN.Text = "9090";
                tbCant.Text = "1";
                tbDias.Text = "1";
                idr.Text = numero.ToString();
                dateInicio.Value = DateTime.Now;
                dataSetPL.Prestamos_Libros.AddPrestamos_LibrosRow(numero, IdPresta, tbISBN.Text, 1, dateInicio.Value, DateTime.Now, "0", 0);
                prestamosLibrosBindingSource.MoveLast();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prestamosLibrosBindingSource.ResetBindings(false);
            }
        }

        private void Solicitud_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'dataSetLibros.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.dataSetLibros.Libros);
            // TODO: esta línea de código carga datos en la tabla 'almacen._Almacen' Puede moverla o quitarla según sea necesario.
            this.almacenTableAdapter.Fill(this.almacen._Almacen);
            
            // TODO: esta línea de código carga datos en la tabla 'dataSetPL.Prestamos_Libros' Puede moverla o quitarla según sea necesario.
            this.prestamos_LibrosTableAdapter.FillByIDPresta(this.dataSetPL.Prestamos_Libros, IdPresta);
            tbId.Text = IdPresta.ToString();
            prestamosLibrosBindingSource.DataSource = dataSetPL.Prestamos_Libros;
           

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            SqlDataReader sqlData;
            int dif = Math.Abs(int.Parse(tbCant.Text) - canti);
            SqlDataReader ca = conexion.ReaderQuery("select *from Almacen_Libros where ISBN = " + tbISBN.Text + " and Cve_Almacen = " + comboBox1.SelectedValue.ToString());
            if (ca.Read())
            {

                if ((int.Parse(ca[3].ToString()) > 0))
                {
                    if (int.Parse(tbCant.Text)>canti)
                    {
                        sqlData = conexion.ReaderQuery("update Almacen_Libros set Cantidad = case when Cantidad > 0 then Cantidad + " + canti.ToString() + " else 0 end where ISBN = " + tbISBN.Text + " and Cve_Almacen = " + comboBox1.SelectedValue.ToString());
                        sqlData = conexion.ReaderQuery("update Almacen_Libros set Cantidad = case when Cantidad > 0 then Cantidad - " + tbCant.Text + " else 0 end where ISBN = " + tbISBN.Text + " and Cve_Almacen = " + comboBox1.SelectedValue.ToString());
                    }
                    else if(int.Parse(tbCant.Text) < canti)
                    {
                        sqlData = conexion.ReaderQuery("update Almacen_Libros set Cantidad = case when Cantidad > 0 then Cantidad + " + dif + " else 0 end where ISBN = " + tbISBN.Text + " and Cve_Almacen = " + comboBox1.SelectedValue.ToString());
                    }

                    try
                    {
                        dateEntrega.Value = DateTime.Now.AddDays(double.Parse(tbDias.Text));
                        prestamosLibrosBindingSource.EndEdit();
                        prestamos_LibrosTableAdapter.Update(dataSetPL.Prestamos_Libros);
                        groupBox2.Enabled = false;
                        MessageBox.Show("¡Guardado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        prestamosLibrosBindingSource.ResetBindings(false);
                    }

                }
                else if(int.Parse(ca[3].ToString()) == 0 && int.Parse(tbCant.Text) < canti)
                {
                    sqlData = conexion.ReaderQuery("update Almacen_Libros set Cantidad = case when Cantidad = 0 then Cantidad + " + dif.ToString() + " else 0 end where ISBN = " + tbISBN.Text + " and Cve_Almacen = " + comboBox1.SelectedValue.ToString());
                    try
                    {
                        dateEntrega.Value = DateTime.Now.AddDays(double.Parse(tbDias.Text));
                        prestamosLibrosBindingSource.EndEdit();
                        prestamos_LibrosTableAdapter.Update(dataSetPL.Prestamos_Libros);
                        groupBox2.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        prestamosLibrosBindingSource.ResetBindings(false);
                    }
                }
                else
                    MessageBox.Show("No se puede agregar registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                groupBox2.Enabled = false;
                dif = Math.Abs(int.Parse(tbCant.Text) - canti);

            }
            
            
            
        }

       

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            prestamosLibrosBindingSource.ResetBindings(false);
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Estas seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    prestamosLibrosBindingSource.RemoveCurrent();
                    prestamos_LibrosTableAdapter.Update(this.dataSetPL.Prestamos_Libros);
                }
                //else
                this.prestamos_LibrosTableAdapter.FillByIDPresta(this.dataSetPL.Prestamos_Libros, IdPresta);

            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    this.prestamos_LibrosTableAdapter.FillByIDPresta(this.dataSetPL.Prestamos_Libros, IdPresta);
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader myReader = conexion.ReaderQuery("update Prestamos_Libros set Aplica_Multa = case when GETDATE() > Fecha_Entrega then 1 else 0 end, Monto = case when GETDATE() > Fecha_Entrega then 10 else 0 end");
                this.prestamos_LibrosTableAdapter.FillByIDPresta(this.dataSetPL.Prestamos_Libros, IdPresta);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double monto = 0;
            try
            {
                SqlDataReader myReader = conexion.ReaderQuery("select *from Prestamos_Libros where Id_prestamo = "+IdPresta);
                this.prestamos_LibrosTableAdapter.FillByIDPresta(this.dataSetPL.Prestamos_Libros, IdPresta);
                while (myReader.Read())
                {
                    monto += Double.Parse(myReader[7].ToString());
                }
                labelMonto.Text = monto.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbISBN.Text = comboBoxLibro.SelectedValue.ToString();
        }

        private void tbISBN_TextChanged(object sender, EventArgs e)
        {
            comboBoxLibro.SelectedValue = tbISBN.Text;
        }

        private void comboBoxLibro_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Solicitud_FormClosing(object sender, FormClosingEventArgs e)
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
