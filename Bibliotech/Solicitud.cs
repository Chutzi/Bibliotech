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
            var days = dateEntrega.Value - dateInicio.Value;
            tbDias.Text = days.Days.ToString();
            groupBox2.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox2.Enabled = true;
                tbISBN.Text = "";
                tbCant.Text = "1";
                tbDias.Text = "1";
                dateInicio.Value = DateTime.Now;
                dataSetPL.Prestamos_Libros.AddPrestamos_LibrosRow(IdPresta, tbISBN.Text, 1, dateInicio.Value, DateTime.Now, "0", 0);
                prestamosLibrosBindingSource.MoveLast();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                prestamosLibrosBindingSource.ResetBindings(false);
            }
        }

        private void Solicitud_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'dataSetPL.Prestamos_Libros' Puede moverla o quitarla según sea necesario.
            this.prestamos_LibrosTableAdapter.FillByIDPresta(this.dataSetPL.Prestamos_Libros, IdPresta);
            tbId.Text = IdPresta.ToString();
            prestamosLibrosBindingSource.DataSource = dataSetPL.Prestamos_Libros;
  
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                dateEntrega.Value = DateTime.Now.AddDays(double.Parse(tbDias.Text));
                prestamosLibrosBindingSource.EndEdit();
                prestamos_LibrosTableAdapter.Update(dataSetPL.Prestamos_Libros);
                groupBox2.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                prestamosLibrosBindingSource.ResetBindings(false);
            }
        }

       

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            prestamosLibrosBindingSource.ResetBindings(false);
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                prestamosLibrosBindingSource.RemoveCurrent();
                prestamos_LibrosTableAdapter.Update(this.dataSetPL.Prestamos_Libros);
            }
            //else
            this.prestamos_LibrosTableAdapter.FillByIDPresta(this.dataSetPL.Prestamos_Libros, IdPresta);
        
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
    }
}
