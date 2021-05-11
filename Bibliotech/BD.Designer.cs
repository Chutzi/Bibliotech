
namespace Bibliotech
{
    partial class BD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BD));
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paginasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAutorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEditorialDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetLibros = new Bibliotech.DataSetLibros();
            this.Libros = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelEdicion = new System.Windows.Forms.Label();
            this.tbEdicion = new System.Windows.Forms.TextBox();
            this.labelFechaC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPag = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_idEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_idAutor = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apPaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apMaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotechDataSet4 = new Bibliotech.BibliotechDataSet4();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.generoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotechDataSet13 = new Bibliotech.BibliotechDataSet13();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.editorialBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotechDataSet12 = new Bibliotech.BibliotechDataSet12();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.autoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotechDataSet11 = new Bibliotech.BibliotechDataSet11();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.tbAM = new System.Windows.Forms.TextBox();
            this.tbNacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAP = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.tbNombreA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idEditorialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEditorial = new Bibliotech.DataSetEditorial();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbNombreEd = new System.Windows.Forms.TextBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.editorialTableAdapter = new Bibliotech.DataSetEditorialTableAdapters.EditorialTableAdapter();
            this.textBoxSearchEd = new System.Windows.Forms.TextBox();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonDeleteAutor = new System.Windows.Forms.Button();
            this.buttonSaveAutor = new System.Windows.Forms.Button();
            this.buttonNewAutor = new System.Windows.Forms.Button();
            this.buttoncancelAutor = new System.Windows.Forms.Button();
            this.buttonEditAutor = new System.Windows.Forms.Button();
            this.autoresTableAdapter = new Bibliotech.BibliotechDataSet4TableAdapters.AutoresTableAdapter();
            this.bDeleteBook = new System.Windows.Forms.Button();
            this.bSaveBook = new System.Windows.Forms.Button();
            this.bNewBook = new System.Windows.Forms.Button();
            this.bCancelBook = new System.Windows.Forms.Button();
            this.bEditBook = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.cveAlmacenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.almacenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotechDataSet9 = new Bibliotech.BibliotechDataSet9();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.claveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cveAlmacenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.almacenLibrosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotechDataSet10 = new Bibliotech.BibliotechDataSet10();
            this.almacenLibrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAL = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.almacenLibrosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.almacenLibrosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.almacen_LibrosTableAdapter = new Bibliotech.BibliotechDataSet10TableAdapters.Almacen_LibrosTableAdapter();
            this.almacenTableAdapter = new Bibliotech.BibliotechDataSet9TableAdapters.AlmacenTableAdapter();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.librosTableAdapter = new Bibliotech.DataSetLibrosTableAdapters.LibrosTableAdapter();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.idgeneroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSgen = new Bibliotech.DSgen();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.generoTableAdapter = new Bibliotech.DSgenTableAdapters.GeneroTableAdapter();
            this.autoresTableAdapter1 = new Bibliotech.BibliotechDataSet11TableAdapters.AutoresTableAdapter();
            this.editorialTableAdapter1 = new Bibliotech.BibliotechDataSet12TableAdapters.EditorialTableAdapter();
            this.generoTableAdapter1 = new Bibliotech.BibliotechDataSet13TableAdapters.GeneroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotechDataSet4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotechDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotechDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotechDataSet11)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditorial)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotechDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenLibrosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotechDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenLibrosBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.almacenLibrosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenLibrosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSgen)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.AllowUserToAddRows = false;
            this.dataGridViewBook.AutoGenerateColumns = false;
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBNDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.edicionDataGridViewTextBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn,
            this.paginasDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.idAutorDataGridViewTextBoxColumn1,
            this.idEditorialDataGridViewTextBoxColumn1,
            this.Id_genero});
            this.dataGridViewBook.DataSource = this.librosBindingSource;
            this.dataGridViewBook.Location = new System.Drawing.Point(186, 118);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.Size = new System.Drawing.Size(514, 244);
            this.dataGridViewBook.TabIndex = 1;
            this.dataGridViewBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBook_CellContentClick);
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            // 
            // edicionDataGridViewTextBoxColumn
            // 
            this.edicionDataGridViewTextBoxColumn.DataPropertyName = "Edicion";
            this.edicionDataGridViewTextBoxColumn.HeaderText = "Edicion";
            this.edicionDataGridViewTextBoxColumn.Name = "edicionDataGridViewTextBoxColumn";
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Creacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "Fecha_Creacion";
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            // 
            // paginasDataGridViewTextBoxColumn
            // 
            this.paginasDataGridViewTextBoxColumn.DataPropertyName = "Paginas";
            this.paginasDataGridViewTextBoxColumn.HeaderText = "Paginas";
            this.paginasDataGridViewTextBoxColumn.Name = "paginasDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // idAutorDataGridViewTextBoxColumn1
            // 
            this.idAutorDataGridViewTextBoxColumn1.DataPropertyName = "Id_Autor";
            this.idAutorDataGridViewTextBoxColumn1.HeaderText = "Id_Autor";
            this.idAutorDataGridViewTextBoxColumn1.Name = "idAutorDataGridViewTextBoxColumn1";
            // 
            // idEditorialDataGridViewTextBoxColumn1
            // 
            this.idEditorialDataGridViewTextBoxColumn1.DataPropertyName = "Id_Editorial";
            this.idEditorialDataGridViewTextBoxColumn1.HeaderText = "Id_Editorial";
            this.idEditorialDataGridViewTextBoxColumn1.Name = "idEditorialDataGridViewTextBoxColumn1";
            // 
            // Id_genero
            // 
            this.Id_genero.DataPropertyName = "Id_genero";
            this.Id_genero.HeaderText = "Id_genero";
            this.Id_genero.Name = "Id_genero";
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "Libros";
            this.librosBindingSource.DataSource = this.dataSetLibros;
            // 
            // dataSetLibros
            // 
            this.dataSetLibros.DataSetName = "DataSetLibros";
            this.dataSetLibros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Libros
            // 
            this.Libros.AutoSize = true;
            this.Libros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Libros.ForeColor = System.Drawing.Color.White;
            this.Libros.Location = new System.Drawing.Point(15, 10);
            this.Libros.Name = "Libros";
            this.Libros.Size = new System.Drawing.Size(67, 24);
            this.Libros.TabIndex = 2;
            this.Libros.Text = "Libros";
            // 
            // tbTitulo
            // 
            this.tbTitulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Titulo", true));
            this.tbTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitulo.Location = new System.Drawing.Point(146, 57);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(137, 21);
            this.tbTitulo.TabIndex = 3;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelTitulo.Location = new System.Drawing.Point(19, 59);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(43, 14);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Titulo:";
            // 
            // labelEdicion
            // 
            this.labelEdicion.AutoSize = true;
            this.labelEdicion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelEdicion.Location = new System.Drawing.Point(19, 85);
            this.labelEdicion.Name = "labelEdicion";
            this.labelEdicion.Size = new System.Drawing.Size(54, 14);
            this.labelEdicion.TabIndex = 6;
            this.labelEdicion.Text = "Edición:";
            // 
            // tbEdicion
            // 
            this.tbEdicion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Edicion", true));
            this.tbEdicion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEdicion.Location = new System.Drawing.Point(146, 83);
            this.tbEdicion.Name = "tbEdicion";
            this.tbEdicion.Size = new System.Drawing.Size(137, 21);
            this.tbEdicion.TabIndex = 5;
            // 
            // labelFechaC
            // 
            this.labelFechaC.AutoSize = true;
            this.labelFechaC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelFechaC.Location = new System.Drawing.Point(19, 114);
            this.labelFechaC.Name = "labelFechaC";
            this.labelFechaC.Size = new System.Drawing.Size(101, 14);
            this.labelFechaC.TabIndex = 8;
            this.labelFechaC.Text = "Fecha Creación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(19, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Paginas:";
            // 
            // tbPag
            // 
            this.tbPag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Paginas", true));
            this.tbPag.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPag.Location = new System.Drawing.Point(146, 135);
            this.tbPag.Name = "tbPag";
            this.tbPag.Size = new System.Drawing.Size(137, 21);
            this.tbPag.TabIndex = 9;
            // 
            // date
            // 
            this.date.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Fecha_Creacion", true));
            this.date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(146, 109);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(137, 21);
            this.date.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(19, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descripción:";
            // 
            // tbDesc
            // 
            this.tbDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Descripcion", true));
            this.tbDesc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDesc.Location = new System.Drawing.Point(146, 161);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(137, 21);
            this.tbDesc.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(19, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 15;
            this.label2.Text = "Id_Editorial:";
            // 
            // tb_idEdit
            // 
            this.tb_idEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Id_Editorial", true));
            this.tb_idEdit.Enabled = false;
            this.tb_idEdit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_idEdit.Location = new System.Drawing.Point(100, 214);
            this.tb_idEdit.Name = "tb_idEdit";
            this.tb_idEdit.Size = new System.Drawing.Size(35, 21);
            this.tb_idEdit.TabIndex = 14;
            this.tb_idEdit.TextChanged += new System.EventHandler(this.tb_idEdit_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(19, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "Id_Autor:";
            // 
            // tb_idAutor
            // 
            this.tb_idAutor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Id_Autor", true));
            this.tb_idAutor.Enabled = false;
            this.tb_idAutor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_idAutor.Location = new System.Drawing.Point(100, 187);
            this.tb_idAutor.Name = "tb_idAutor";
            this.tb_idAutor.Size = new System.Drawing.Size(35, 21);
            this.tb_idAutor.TabIndex = 16;
            this.tb_idAutor.TextChanged += new System.EventHandler(this.tb_idAutor_TextChanged);
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelISBN.Location = new System.Drawing.Point(19, 33);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(41, 14);
            this.labelISBN.TabIndex = 19;
            this.labelISBN.Text = "ISBN:";
            // 
            // tbISBN
            // 
            this.tbISBN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "ISBN", true));
            this.tbISBN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbISBN.Location = new System.Drawing.Point(146, 31);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(137, 21);
            this.tbISBN.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Autores";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAutorDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn1,
            this.apPaternoDataGridViewTextBoxColumn,
            this.apMaternoDataGridViewTextBoxColumn,
            this.nacionalidadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.autoresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(185, 535);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(514, 194);
            this.dataGridView1.TabIndex = 20;
            // 
            // idAutorDataGridViewTextBoxColumn
            // 
            this.idAutorDataGridViewTextBoxColumn.DataPropertyName = "Id_Autor";
            this.idAutorDataGridViewTextBoxColumn.HeaderText = "Id_Autor";
            this.idAutorDataGridViewTextBoxColumn.Name = "idAutorDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            // 
            // apPaternoDataGridViewTextBoxColumn
            // 
            this.apPaternoDataGridViewTextBoxColumn.DataPropertyName = "Ap_Paterno";
            this.apPaternoDataGridViewTextBoxColumn.HeaderText = "Ap_Paterno";
            this.apPaternoDataGridViewTextBoxColumn.Name = "apPaternoDataGridViewTextBoxColumn";
            // 
            // apMaternoDataGridViewTextBoxColumn
            // 
            this.apMaternoDataGridViewTextBoxColumn.DataPropertyName = "Ap_Materno";
            this.apMaternoDataGridViewTextBoxColumn.HeaderText = "Ap_Materno";
            this.apMaternoDataGridViewTextBoxColumn.Name = "apMaternoDataGridViewTextBoxColumn";
            // 
            // nacionalidadDataGridViewTextBoxColumn
            // 
            this.nacionalidadDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidad";
            this.nacionalidadDataGridViewTextBoxColumn.HeaderText = "Nacionalidad";
            this.nacionalidadDataGridViewTextBoxColumn.Name = "nacionalidadDataGridViewTextBoxColumn";
            // 
            // autoresBindingSource
            // 
            this.autoresBindingSource.DataMember = "Autores";
            this.autoresBindingSource.DataSource = this.bibliotechDataSet4;
            // 
            // bibliotechDataSet4
            // 
            this.bibliotechDataSet4.DataSetName = "BibliotechDataSet4";
            this.bibliotechDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.tbISBN);
            this.groupBox1.Controls.Add(this.labelISBN);
            this.groupBox1.Controls.Add(this.tbPag);
            this.groupBox1.Controls.Add(this.labelFechaC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelEdicion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.tbEdicion);
            this.groupBox1.Controls.Add(this.tb_idAutor);
            this.groupBox1.Controls.Add(this.tbDesc);
            this.groupBox1.Controls.Add(this.labelTitulo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTitulo);
            this.groupBox1.Controls.Add(this.tb_idEdit);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(729, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 285);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Libro";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.generoBindingSource1;
            this.comboBox3.DisplayMember = "Genero";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(145, 240);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(140, 23);
            this.comboBox3.TabIndex = 59;
            this.comboBox3.ValueMember = "Id_genero";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // generoBindingSource1
            // 
            this.generoBindingSource1.DataMember = "Genero";
            this.generoBindingSource1.DataSource = this.bibliotechDataSet13;
            // 
            // bibliotechDataSet13
            // 
            this.bibliotechDataSet13.DataSetName = "BibliotechDataSet13";
            this.bibliotechDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.editorialBindingSource1;
            this.comboBox2.DisplayMember = "Nombre";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(145, 212);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(138, 23);
            this.comboBox2.TabIndex = 59;
            this.comboBox2.ValueMember = "Id_Editorial";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // editorialBindingSource1
            // 
            this.editorialBindingSource1.DataMember = "Editorial";
            this.editorialBindingSource1.DataSource = this.bibliotechDataSet12;
            // 
            // bibliotechDataSet12
            // 
            this.bibliotechDataSet12.DataSetName = "BibliotechDataSet12";
            this.bibliotechDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.autoresBindingSource1;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 186);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 23);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.ValueMember = "Id_Autor";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // autoresBindingSource1
            // 
            this.autoresBindingSource1.DataMember = "Autores";
            this.autoresBindingSource1.DataSource = this.bibliotechDataSet11;
            // 
            // bibliotechDataSet11
            // 
            this.bibliotechDataSet11.DataSetName = "BibliotechDataSet11";
            this.bibliotechDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(18, 242);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 14);
            this.label17.TabIndex = 21;
            this.label17.Text = "Id_Genero:";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Id_genero", true));
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(100, 239);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(36, 21);
            this.textBox4.TabIndex = 20;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPais);
            this.groupBox2.Controls.Add(this.tbAM);
            this.groupBox2.Controls.Add(this.tbNacion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbAP);
            this.groupBox2.Controls.Add(this.labelNombre);
            this.groupBox2.Controls.Add(this.tbNombreA);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(728, 535);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 224);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuevo Autor";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbPais
            // 
            this.cbPais.Enabled = false;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Items.AddRange(new object[] {
            "argentina\t",
            "español",
            "australiana\t",
            "inglés",
            "belga",
            "francés",
            "boliviana",
            "brasileña",
            "camboyana\t",
            "canadiense",
            "china\t",
            "colombiana",
            "coreana",
            "costarricense",
            "cubana\t",
            "danesa",
            "ecuatoriana",
            "egipcia",
            "salvadoreña",
            "escocesa",
            "española",
            "estadounidense",
            "estonia",
            "etiope",
            "filipina",
            "finlandés",
            "griega",
            "guatemalteca",
            "hondureña",
            "mexicana"});
            this.cbPais.Location = new System.Drawing.Point(147, 164);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(136, 23);
            this.cbPais.TabIndex = 22;
            this.cbPais.Visible = false;
            // 
            // tbAM
            // 
            this.tbAM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "Ap_Materno", true));
            this.tbAM.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAM.Location = new System.Drawing.Point(146, 110);
            this.tbAM.Name = "tbAM";
            this.tbAM.Size = new System.Drawing.Size(137, 21);
            this.tbAM.TabIndex = 21;
            // 
            // tbNacion
            // 
            this.tbNacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "Nacionalidad", true));
            this.tbNacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNacion.Location = new System.Drawing.Point(146, 137);
            this.tbNacion.Name = "tbNacion";
            this.tbNacion.Size = new System.Drawing.Size(137, 21);
            this.tbNacion.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(19, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = "Apeliido Materno:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(19, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 14);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nacionalidad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(19, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 14);
            this.label9.TabIndex = 6;
            this.label9.Text = "Apeliido Paterno:";
            // 
            // tbAP
            // 
            this.tbAP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "Ap_Paterno", true));
            this.tbAP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAP.Location = new System.Drawing.Point(146, 83);
            this.tbAP.Name = "tbAP";
            this.tbAP.Size = new System.Drawing.Size(137, 21);
            this.tbAP.TabIndex = 5;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelNombre.Location = new System.Drawing.Point(19, 59);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 14);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Nombre:";
            // 
            // tbNombreA
            // 
            this.tbNombreA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "Nombre", true));
            this.tbNombreA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreA.Location = new System.Drawing.Point(146, 57);
            this.tbNombreA.Name = "tbNombreA";
            this.tbNombreA.Size = new System.Drawing.Size(137, 21);
            this.tbNombreA.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(14, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 24);
            this.label10.TabIndex = 25;
            this.label10.Text = "Editoriales";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEditorialDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.editorialBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(184, 908);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(514, 194);
            this.dataGridView2.TabIndex = 24;
            // 
            // idEditorialDataGridViewTextBoxColumn
            // 
            this.idEditorialDataGridViewTextBoxColumn.DataPropertyName = "Id_Editorial";
            this.idEditorialDataGridViewTextBoxColumn.HeaderText = "Id_Editorial";
            this.idEditorialDataGridViewTextBoxColumn.Name = "idEditorialDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // editorialBindingSource
            // 
            this.editorialBindingSource.DataMember = "Editorial";
            this.editorialBindingSource.DataSource = this.dataSetEditorial;
            // 
            // dataSetEditorial
            // 
            this.dataSetEditorial.DataSetName = "DataSetEditorial";
            this.dataSetEditorial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbCorreo);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.tbTel);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.tbNombreEd);
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(731, 908);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 227);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nueva Editorial";
            // 
            // tbCorreo
            // 
            this.tbCorreo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editorialBindingSource, "Correo", true));
            this.tbCorreo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreo.Location = new System.Drawing.Point(146, 110);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(137, 21);
            this.tbCorreo.TabIndex = 21;
            this.tbCorreo.Text = "--";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(19, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 14);
            this.label12.TabIndex = 8;
            this.label12.Text = "Correo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(19, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 14);
            this.label14.TabIndex = 6;
            this.label14.Text = "Telefono:";
            // 
            // tbTel
            // 
            this.tbTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editorialBindingSource, "Telefono", true));
            this.tbTel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTel.Location = new System.Drawing.Point(146, 83);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(137, 21);
            this.tbTel.TabIndex = 5;
            this.tbTel.Text = "--";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(19, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 14);
            this.label15.TabIndex = 4;
            this.label15.Text = "Nombre:";
            // 
            // tbNombreEd
            // 
            this.tbNombreEd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editorialBindingSource, "Nombre", true));
            this.tbNombreEd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreEd.Location = new System.Drawing.Point(146, 57);
            this.tbNombreEd.Name = "tbNombreEd";
            this.tbNombreEd.Size = new System.Drawing.Size(137, 21);
            this.tbNombreEd.TabIndex = 3;
            this.tbNombreEd.Text = "--";
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.Blue;
            this.buttonNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNew.Image = ((System.Drawing.Image)(resources.GetObject("buttonNew.Image")));
            this.buttonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNew.Location = new System.Drawing.Point(620, 1108);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(78, 23);
            this.buttonNew.TabIndex = 20;
            this.buttonNew.Text = "Nuevo";
            this.buttonNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEdit.Location = new System.Drawing.Point(360, 1108);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 22;
            this.buttonEdit.Text = "Editar";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancel.Location = new System.Drawing.Point(441, 1108);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.Location = new System.Drawing.Point(522, 1108);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 24;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // editorialTableAdapter
            // 
            this.editorialTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxSearchEd
            // 
            this.textBoxSearchEd.Location = new System.Drawing.Point(503, 1937);
            this.textBoxSearchEd.Name = "textBoxSearchEd";
            this.textBoxSearchEd.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchEd.TabIndex = 26;
            this.textBoxSearchEd.Visible = false;
            this.textBoxSearchEd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchEd_KeyPress);
            // 
            // buttondelete
            // 
            this.buttondelete.BackColor = System.Drawing.Color.Red;
            this.buttondelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondelete.ForeColor = System.Drawing.Color.White;
            this.buttondelete.Image = ((System.Drawing.Image)(resources.GetObject("buttondelete.Image")));
            this.buttondelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttondelete.Location = new System.Drawing.Point(279, 1108);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(75, 23);
            this.buttondelete.TabIndex = 27;
            this.buttondelete.Text = "Eliminar";
            this.buttondelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttondelete.UseVisualStyleBackColor = false;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonDeleteAutor
            // 
            this.buttonDeleteAutor.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteAutor.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteAutor.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteAutor.Image")));
            this.buttonDeleteAutor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteAutor.Location = new System.Drawing.Point(279, 747);
            this.buttonDeleteAutor.Name = "buttonDeleteAutor";
            this.buttonDeleteAutor.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAutor.TabIndex = 32;
            this.buttonDeleteAutor.Text = "Eliminar";
            this.buttonDeleteAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteAutor.UseVisualStyleBackColor = false;
            this.buttonDeleteAutor.Click += new System.EventHandler(this.buttonDeleteAutor_Click);
            // 
            // buttonSaveAutor
            // 
            this.buttonSaveAutor.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonSaveAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveAutor.ForeColor = System.Drawing.Color.White;
            this.buttonSaveAutor.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveAutor.Image")));
            this.buttonSaveAutor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSaveAutor.Location = new System.Drawing.Point(522, 747);
            this.buttonSaveAutor.Name = "buttonSaveAutor";
            this.buttonSaveAutor.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveAutor.TabIndex = 31;
            this.buttonSaveAutor.Text = "Guardar";
            this.buttonSaveAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveAutor.UseVisualStyleBackColor = false;
            this.buttonSaveAutor.Click += new System.EventHandler(this.buttonSaveAutor_Click);
            // 
            // buttonNewAutor
            // 
            this.buttonNewAutor.BackColor = System.Drawing.Color.Blue;
            this.buttonNewAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewAutor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNewAutor.Image = ((System.Drawing.Image)(resources.GetObject("buttonNewAutor.Image")));
            this.buttonNewAutor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNewAutor.Location = new System.Drawing.Point(620, 747);
            this.buttonNewAutor.Name = "buttonNewAutor";
            this.buttonNewAutor.Size = new System.Drawing.Size(78, 23);
            this.buttonNewAutor.TabIndex = 28;
            this.buttonNewAutor.Text = "Nuevo";
            this.buttonNewAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNewAutor.UseVisualStyleBackColor = false;
            this.buttonNewAutor.Click += new System.EventHandler(this.buttonNewAutor_Click);
            // 
            // buttoncancelAutor
            // 
            this.buttoncancelAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttoncancelAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncancelAutor.ForeColor = System.Drawing.Color.White;
            this.buttoncancelAutor.Image = ((System.Drawing.Image)(resources.GetObject("buttoncancelAutor.Image")));
            this.buttoncancelAutor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttoncancelAutor.Location = new System.Drawing.Point(441, 747);
            this.buttoncancelAutor.Name = "buttoncancelAutor";
            this.buttoncancelAutor.Size = new System.Drawing.Size(75, 23);
            this.buttoncancelAutor.TabIndex = 30;
            this.buttoncancelAutor.Text = "Cancelar";
            this.buttoncancelAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoncancelAutor.UseVisualStyleBackColor = false;
            this.buttoncancelAutor.Click += new System.EventHandler(this.buttoncancelAutor_Click);
            // 
            // buttonEditAutor
            // 
            this.buttonEditAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonEditAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditAutor.ForeColor = System.Drawing.Color.White;
            this.buttonEditAutor.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditAutor.Image")));
            this.buttonEditAutor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEditAutor.Location = new System.Drawing.Point(360, 747);
            this.buttonEditAutor.Name = "buttonEditAutor";
            this.buttonEditAutor.Size = new System.Drawing.Size(75, 23);
            this.buttonEditAutor.TabIndex = 29;
            this.buttonEditAutor.Text = "Editar";
            this.buttonEditAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditAutor.UseVisualStyleBackColor = false;
            this.buttonEditAutor.Click += new System.EventHandler(this.buttonEditAutor_Click);
            // 
            // autoresTableAdapter
            // 
            this.autoresTableAdapter.ClearBeforeFill = true;
            // 
            // bDeleteBook
            // 
            this.bDeleteBook.BackColor = System.Drawing.Color.Red;
            this.bDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDeleteBook.ForeColor = System.Drawing.Color.White;
            this.bDeleteBook.Image = ((System.Drawing.Image)(resources.GetObject("bDeleteBook.Image")));
            this.bDeleteBook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bDeleteBook.Location = new System.Drawing.Point(280, 378);
            this.bDeleteBook.Name = "bDeleteBook";
            this.bDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.bDeleteBook.TabIndex = 37;
            this.bDeleteBook.Text = "Eliminar";
            this.bDeleteBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDeleteBook.UseVisualStyleBackColor = false;
            this.bDeleteBook.Click += new System.EventHandler(this.bDeleteBook_Click);
            // 
            // bSaveBook
            // 
            this.bSaveBook.BackColor = System.Drawing.Color.SeaGreen;
            this.bSaveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSaveBook.ForeColor = System.Drawing.Color.White;
            this.bSaveBook.Image = ((System.Drawing.Image)(resources.GetObject("bSaveBook.Image")));
            this.bSaveBook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSaveBook.Location = new System.Drawing.Point(523, 378);
            this.bSaveBook.Name = "bSaveBook";
            this.bSaveBook.Size = new System.Drawing.Size(75, 23);
            this.bSaveBook.TabIndex = 36;
            this.bSaveBook.Text = "Guardar";
            this.bSaveBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSaveBook.UseVisualStyleBackColor = false;
            this.bSaveBook.Click += new System.EventHandler(this.bSaveBook_Click);
            // 
            // bNewBook
            // 
            this.bNewBook.BackColor = System.Drawing.Color.Blue;
            this.bNewBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNewBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bNewBook.Image = ((System.Drawing.Image)(resources.GetObject("bNewBook.Image")));
            this.bNewBook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bNewBook.Location = new System.Drawing.Point(621, 378);
            this.bNewBook.Name = "bNewBook";
            this.bNewBook.Size = new System.Drawing.Size(78, 23);
            this.bNewBook.TabIndex = 33;
            this.bNewBook.Text = "Nuevo";
            this.bNewBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNewBook.UseVisualStyleBackColor = false;
            this.bNewBook.Click += new System.EventHandler(this.bNewBook_Click);
            // 
            // bCancelBook
            // 
            this.bCancelBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bCancelBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelBook.ForeColor = System.Drawing.Color.White;
            this.bCancelBook.Image = ((System.Drawing.Image)(resources.GetObject("bCancelBook.Image")));
            this.bCancelBook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCancelBook.Location = new System.Drawing.Point(442, 378);
            this.bCancelBook.Name = "bCancelBook";
            this.bCancelBook.Size = new System.Drawing.Size(75, 23);
            this.bCancelBook.TabIndex = 35;
            this.bCancelBook.Text = "Cancelar";
            this.bCancelBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCancelBook.UseVisualStyleBackColor = false;
            this.bCancelBook.Click += new System.EventHandler(this.bCancelBook_Click);
            // 
            // bEditBook
            // 
            this.bEditBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bEditBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditBook.ForeColor = System.Drawing.Color.White;
            this.bEditBook.Image = ((System.Drawing.Image)(resources.GetObject("bEditBook.Image")));
            this.bEditBook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bEditBook.Location = new System.Drawing.Point(361, 378);
            this.bEditBook.Name = "bEditBook";
            this.bEditBook.Size = new System.Drawing.Size(75, 23);
            this.bEditBook.TabIndex = 34;
            this.bEditBook.Text = "Editar";
            this.bEditBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEditBook.UseVisualStyleBackColor = false;
            this.bEditBook.Click += new System.EventHandler(this.bEditBook_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.Libros);
            this.panel1.Location = new System.Drawing.Point(186, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 44);
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(185, 462);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 41);
            this.panel2.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(184, 851);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(855, 41);
            this.panel3.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 462);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(20, 851);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(140, 153);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkViolet;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(182, 1186);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(855, 41);
            this.panel4.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Almacenes";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cveAlmacenDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.almacenBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(184, 1253);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(265, 194);
            this.dataGridView3.TabIndex = 41;
            // 
            // cveAlmacenDataGridViewTextBoxColumn
            // 
            this.cveAlmacenDataGridViewTextBoxColumn.DataPropertyName = "Cve_Almacen";
            this.cveAlmacenDataGridViewTextBoxColumn.HeaderText = "Cve_Almacen";
            this.cveAlmacenDataGridViewTextBoxColumn.Name = "cveAlmacenDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn1
            // 
            this.descripcionDataGridViewTextBoxColumn1.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.Name = "descripcionDataGridViewTextBoxColumn1";
            // 
            // almacenBindingSource
            // 
            this.almacenBindingSource.DataMember = "Almacen";
            this.almacenBindingSource.DataSource = this.bibliotechDataSet9;
            // 
            // bibliotechDataSet9
            // 
            this.bibliotechDataSet9.DataSetName = "BibliotechDataSet9";
            this.bibliotechDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.claveDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn1,
            this.cveAlmacenDataGridViewTextBoxColumn1,
            this.cantidadDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.almacenLibrosBindingSource3;
            this.dataGridView4.Location = new System.Drawing.Point(561, 1253);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(466, 194);
            this.dataGridView4.TabIndex = 43;
            // 
            // claveDataGridViewTextBoxColumn
            // 
            this.claveDataGridViewTextBoxColumn.DataPropertyName = "Clave";
            this.claveDataGridViewTextBoxColumn.HeaderText = "Clave";
            this.claveDataGridViewTextBoxColumn.Name = "claveDataGridViewTextBoxColumn";
            // 
            // iSBNDataGridViewTextBoxColumn1
            // 
            this.iSBNDataGridViewTextBoxColumn1.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn1.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn1.Name = "iSBNDataGridViewTextBoxColumn1";
            // 
            // cveAlmacenDataGridViewTextBoxColumn1
            // 
            this.cveAlmacenDataGridViewTextBoxColumn1.DataPropertyName = "Cve_Almacen";
            this.cveAlmacenDataGridViewTextBoxColumn1.HeaderText = "Cve_Almacen";
            this.cveAlmacenDataGridViewTextBoxColumn1.Name = "cveAlmacenDataGridViewTextBoxColumn1";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // almacenLibrosBindingSource3
            // 
            this.almacenLibrosBindingSource3.DataMember = "Almacen_Libros";
            this.almacenLibrosBindingSource3.DataSource = this.bibliotechDataSet10;
            // 
            // bibliotechDataSet10
            // 
            this.bibliotechDataSet10.DataSetName = "BibliotechDataSet10";
            this.bibliotechDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // almacenLibrosBindingSource
            // 
            this.almacenLibrosBindingSource.DataMember = "Almacen_Libros";
            this.almacenLibrosBindingSource.DataSource = this.bibliotechDataSet10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Enabled = false;
            this.groupBox4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox4.Location = new System.Drawing.Point(561, 1465);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(308, 148);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nuevo almacen";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.almacenLibrosBindingSource3, "Cantidad", true));
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(146, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 21);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "--";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(19, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 14);
            this.label11.TabIndex = 8;
            this.label11.Text = "Cantidad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(19, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 14);
            this.label13.TabIndex = 6;
            this.label13.Text = "Cve_almacen";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.almacenLibrosBindingSource3, "Cve_Almacen", true));
            this.textBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(146, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 21);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "--";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(19, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 14);
            this.label16.TabIndex = 4;
            this.label16.Text = "ISBN";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.almacenLibrosBindingSource3, "ISBN", true));
            this.textBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(146, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 21);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "--";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(889, 1583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Eliminar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(889, 1494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "Guardar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAL
            // 
            this.buttonAL.BackColor = System.Drawing.Color.Blue;
            this.buttonAL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAL.Image = ((System.Drawing.Image)(resources.GetObject("buttonAL.Image")));
            this.buttonAL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAL.Location = new System.Drawing.Point(889, 1465);
            this.buttonAL.Name = "buttonAL";
            this.buttonAL.Size = new System.Drawing.Size(78, 23);
            this.buttonAL.TabIndex = 44;
            this.buttonAL.Text = "Nuevo";
            this.buttonAL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAL.UseVisualStyleBackColor = false;
            this.buttonAL.Click += new System.EventHandler(this.buttonAL_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(889, 1554);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 46;
            this.button4.Text = "Cancelar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(889, 1525);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 45;
            this.button5.Text = "Editar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // almacenLibrosBindingSource2
            // 
            this.almacenLibrosBindingSource2.DataMember = "Almacen_Libros";
            this.almacenLibrosBindingSource2.DataSource = this.bibliotechDataSet10;
            // 
            // almacenLibrosBindingSource1
            // 
            this.almacenLibrosBindingSource1.DataMember = "Almacen_Libros";
            this.almacenLibrosBindingSource1.DataSource = this.bibliotechDataSet10;
            // 
            // almacen_LibrosTableAdapter
            // 
            this.almacen_LibrosTableAdapter.ClearBeforeFill = true;
            // 
            // almacenTableAdapter
            // 
            this.almacenTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(20, 1186);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(140, 140);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(22, 1663);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(140, 140);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 51;
            this.pictureBox5.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel5.Controls.Add(this.label18);
            this.panel5.Location = new System.Drawing.Point(184, 1663);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(855, 41);
            this.panel5.TabIndex = 50;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(14, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 24);
            this.label18.TabIndex = 25;
            this.label18.Text = "Genero";
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idgeneroDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.generoBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(184, 1733);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(265, 194);
            this.dataGridView5.TabIndex = 52;
            // 
            // idgeneroDataGridViewTextBoxColumn
            // 
            this.idgeneroDataGridViewTextBoxColumn.DataPropertyName = "Id_genero";
            this.idgeneroDataGridViewTextBoxColumn.HeaderText = "Id_genero";
            this.idgeneroDataGridViewTextBoxColumn.Name = "idgeneroDataGridViewTextBoxColumn";
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "Genero";
            this.generoBindingSource.DataSource = this.dSgen;
            // 
            // dSgen
            // 
            this.dSgen.DataSetName = "DSgen";
            this.dSgen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(811, 1851);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 58;
            this.button3.Text = "Eliminar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SeaGreen;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(811, 1762);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 57;
            this.button6.Text = "Guardar";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Blue;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.Location = new System.Drawing.Point(811, 1733);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(78, 23);
            this.button7.TabIndex = 54;
            this.button7.Text = "Nuevo";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.Location = new System.Drawing.Point(811, 1822);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 56;
            this.button8.Text = "Cancelar";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.Location = new System.Drawing.Point(811, 1793);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 55;
            this.button9.Text = "Editar";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.textBox7);
            this.groupBox5.Enabled = false;
            this.groupBox5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox5.Location = new System.Drawing.Point(483, 1733);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(308, 148);
            this.groupBox5.TabIndex = 53;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nuevo Genero";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(19, 85);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 14);
            this.label20.TabIndex = 6;
            this.label20.Text = "Genero";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.generoBindingSource, "Genero", true));
            this.textBox6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(146, 83);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(137, 21);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "--";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label21.Location = new System.Drawing.Point(19, 59);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 14);
            this.label21.TabIndex = 4;
            this.label21.Text = "Id_genero";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.generoBindingSource, "Id_genero", true));
            this.textBox7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(146, 57);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(137, 21);
            this.textBox7.TabIndex = 3;
            this.textBox7.Text = "--";
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
            // 
            // autoresTableAdapter1
            // 
            this.autoresTableAdapter1.ClearBeforeFill = true;
            // 
            // editorialTableAdapter1
            // 
            this.editorialTableAdapter1.ClearBeforeFill = true;
            // 
            // generoTableAdapter1
            // 
            this.generoTableAdapter1.ClearBeforeFill = true;
            // 
            // BD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 691);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAL);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxSearchEd);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bDeleteBook);
            this.Controls.Add(this.bSaveBook);
            this.Controls.Add(this.bNewBook);
            this.Controls.Add(this.bCancelBook);
            this.Controls.Add(this.bEditBook);
            this.Controls.Add(this.buttonDeleteAutor);
            this.Controls.Add(this.buttonSaveAutor);
            this.Controls.Add(this.buttonNewAutor);
            this.Controls.Add(this.buttoncancelAutor);
            this.Controls.Add(this.buttonEditAutor);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridViewBook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BD";
            this.Text = "Catálogos";
            this.Load += new System.EventHandler(this.BD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotechDataSet4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotechDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotechDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotechDataSet11)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditorial)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotechDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenLibrosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotechDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenLibrosBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.almacenLibrosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenLibrosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSgen)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewBook;
        private System.Windows.Forms.Label Libros;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelEdicion;
        private System.Windows.Forms.TextBox tbEdicion;
        private System.Windows.Forms.Label labelFechaC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPag;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_idEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_idAutor;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbAM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbAP;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox tbNombreA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbNombreEd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonSave;
        private DataSetEditorial dataSetEditorial;
        private System.Windows.Forms.BindingSource editorialBindingSource;
        private DataSetEditorialTableAdapters.EditorialTableAdapter editorialTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEditorialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxSearchEd;
        private System.Windows.Forms.Button buttondelete;
        private BibliotechDataSet4 bibliotechDataSet4;
        private System.Windows.Forms.BindingSource autoresBindingSource;
        private BibliotechDataSet4TableAdapters.AutoresTableAdapter autoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apPaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apMaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacionalidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonDeleteAutor;
        private System.Windows.Forms.Button buttonSaveAutor;
        private System.Windows.Forms.Button buttonNewAutor;
        private System.Windows.Forms.Button buttoncancelAutor;
        private System.Windows.Forms.Button buttonEditAutor;
        private DataSetLibros dataSetLibros;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DataSetLibrosTableAdapters.LibrosTableAdapter librosTableAdapter;
        private System.Windows.Forms.Button bDeleteBook;
        private System.Windows.Forms.Button bSaveBook;
        private System.Windows.Forms.Button bNewBook;
        private System.Windows.Forms.Button bCancelBook;
        private System.Windows.Forms.Button bEditBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView3;
        private BibliotechDataSet9 bibliotechDataSet9;
        private System.Windows.Forms.BindingSource almacenBindingSource;
        private BibliotechDataSet9TableAdapters.AlmacenTableAdapter almacenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cveAlmacenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private BibliotechDataSet10 bibliotechDataSet10;
        private System.Windows.Forms.BindingSource almacenLibrosBindingSource;
        private BibliotechDataSet10TableAdapters.Almacen_LibrosTableAdapter almacen_LibrosTableAdapter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource almacenLibrosBindingSource3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource almacenLibrosBindingSource2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.BindingSource almacenLibrosBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAL;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cveAlmacenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paginasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAutorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEditorialDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_genero;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridView5;
        private DSgen dSgen;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private DSgenTableAdapters.GeneroTableAdapter generoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgeneroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboBox1;
        private BibliotechDataSet11 bibliotechDataSet11;
        private System.Windows.Forms.BindingSource autoresBindingSource1;
        private BibliotechDataSet11TableAdapters.AutoresTableAdapter autoresTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox2;
        private BibliotechDataSet12 bibliotechDataSet12;
        private System.Windows.Forms.BindingSource editorialBindingSource1;
        private BibliotechDataSet12TableAdapters.EditorialTableAdapter editorialTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox3;
        private BibliotechDataSet13 bibliotechDataSet13;
        private System.Windows.Forms.BindingSource generoBindingSource1;
        private BibliotechDataSet13TableAdapters.GeneroTableAdapter generoTableAdapter1;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.TextBox tbNacion;
    }
}