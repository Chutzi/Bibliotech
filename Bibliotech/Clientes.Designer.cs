
namespace Bibliotech
{
    partial class Clientes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotechDataSet5 = new Bibliotech.BibliotechDataSet5();
            this.label10 = new System.Windows.Forms.Label();
            this.tbEdo = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelEdicion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbCol = new System.Windows.Forms.TextBox();
            this.tbCalle = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbMun = new System.Windows.Forms.TextBox();
            this.bDeleteuser = new System.Windows.Forms.Button();
            this.bSaveuser = new System.Windows.Forms.Button();
            this.bNewuser = new System.Windows.Forms.Button();
            this.bCanceluser = new System.Windows.Forms.Button();
            this.bEdituser = new System.Windows.Forms.Button();
            this.comboBoxCol = new System.Windows.Forms.ComboBox();
            this.textBoxSearc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.usuariosTableAdapter = new Bibliotech.BibliotechDataSet5TableAdapters.UsuariosTableAdapter();
            this.bibliotechDataSet6 = new Bibliotech.BibliotechDataSet6();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Bibliotech.BibliotechDataSet6TableAdapters.ClienteTableAdapter();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipioidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotechDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotechDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.bDeleteuser);
            this.panel1.Controls.Add(this.bSaveuser);
            this.panel1.Controls.Add(this.bNewuser);
            this.panel1.Controls.Add(this.bCanceluser);
            this.panel1.Controls.Add(this.bEdituser);
            this.panel1.Controls.Add(this.comboBoxCol);
            this.panel1.Controls.Add(this.textBoxSearc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 554);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbEdo);
            this.groupBox1.Controls.Add(this.tbUser);
            this.groupBox1.Controls.Add(this.labelISBN);
            this.groupBox1.Controls.Add(this.labelEdicion);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbCorreo);
            this.groupBox1.Controls.Add(this.tbCol);
            this.groupBox1.Controls.Add(this.tbCalle);
            this.groupBox1.Controls.Add(this.labelTitulo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbMun);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(40, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 187);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(313, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Dirección";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.bibliotechDataSet5;
            // 
            // bibliotechDataSet5
            // 
            this.bibliotechDataSet5.DataSetName = "BibliotechDataSet5";
            this.bibliotechDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(313, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 14);
            this.label10.TabIndex = 21;
            this.label10.Text = "Id_Municipio";
            // 
            // tbEdo
            // 
            this.tbEdo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Estado_id", true));
            this.tbEdo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEdo.Location = new System.Drawing.Point(440, 113);
            this.tbEdo.Name = "tbEdo";
            this.tbEdo.Size = new System.Drawing.Size(137, 21);
            this.tbEdo.TabIndex = 20;
            // 
            // tbUser
            // 
            this.tbUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Id_Cliente", true));
            this.tbUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.Location = new System.Drawing.Point(146, 31);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(137, 21);
            this.tbUser.TabIndex = 18;
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelISBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelISBN.Location = new System.Drawing.Point(19, 33);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(70, 14);
            this.labelISBN.TabIndex = 19;
            this.labelISBN.Text = "Id_Usuario";
            // 
            // labelEdicion
            // 
            this.labelEdicion.AutoSize = true;
            this.labelEdicion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdicion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelEdicion.Location = new System.Drawing.Point(19, 85);
            this.labelEdicion.Name = "labelEdicion";
            this.labelEdicion.Size = new System.Drawing.Size(51, 14);
            this.labelEdicion.TabIndex = 6;
            this.labelEdicion.Text = "Correo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(313, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 14);
            this.label7.TabIndex = 17;
            this.label7.Text = "Colonia:";
            // 
            // tbCorreo
            // 
            this.tbCorreo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Correo", true));
            this.tbCorreo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreo.Location = new System.Drawing.Point(146, 83);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(137, 21);
            this.tbCorreo.TabIndex = 5;
            // 
            // tbCol
            // 
            this.tbCol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Colonia", true));
            this.tbCol.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCol.Location = new System.Drawing.Point(440, 57);
            this.tbCol.Name = "tbCol";
            this.tbCol.Size = new System.Drawing.Size(137, 21);
            this.tbCol.TabIndex = 16;
            // 
            // tbCalle
            // 
            this.tbCalle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Calle", true));
            this.tbCalle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCalle.Location = new System.Drawing.Point(440, 31);
            this.tbCalle.Name = "tbCalle";
            this.tbCalle.Size = new System.Drawing.Size(137, 21);
            this.tbCalle.TabIndex = 12;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelTitulo.Location = new System.Drawing.Point(19, 59);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(58, 14);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(313, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 14);
            this.label8.TabIndex = 15;
            this.label8.Text = "Id_Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(313, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 14);
            this.label9.TabIndex = 13;
            this.label9.Text = "Calle:";
            // 
            // tbName
            // 
            this.tbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nombre", true));
            this.tbName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(146, 57);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(137, 21);
            this.tbName.TabIndex = 3;
            // 
            // tbMun
            // 
            this.tbMun.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Municipio_id", true));
            this.tbMun.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMun.Location = new System.Drawing.Point(440, 83);
            this.tbMun.Name = "tbMun";
            this.tbMun.Size = new System.Drawing.Size(137, 21);
            this.tbMun.TabIndex = 14;
            // 
            // bDeleteuser
            // 
            this.bDeleteuser.BackColor = System.Drawing.Color.Red;
            this.bDeleteuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDeleteuser.ForeColor = System.Drawing.Color.White;
            this.bDeleteuser.Location = new System.Drawing.Point(119, 463);
            this.bDeleteuser.Name = "bDeleteuser";
            this.bDeleteuser.Size = new System.Drawing.Size(75, 23);
            this.bDeleteuser.TabIndex = 52;
            this.bDeleteuser.Text = "Eliminar";
            this.bDeleteuser.UseVisualStyleBackColor = false;
            this.bDeleteuser.Click += new System.EventHandler(this.bDeleteuser_Click);
            // 
            // bSaveuser
            // 
            this.bSaveuser.BackColor = System.Drawing.Color.SeaGreen;
            this.bSaveuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSaveuser.ForeColor = System.Drawing.Color.White;
            this.bSaveuser.Location = new System.Drawing.Point(362, 463);
            this.bSaveuser.Name = "bSaveuser";
            this.bSaveuser.Size = new System.Drawing.Size(75, 23);
            this.bSaveuser.TabIndex = 51;
            this.bSaveuser.Text = "Guardar";
            this.bSaveuser.UseVisualStyleBackColor = false;
            this.bSaveuser.Click += new System.EventHandler(this.bSaveuser_Click);
            // 
            // bNewuser
            // 
            this.bNewuser.BackColor = System.Drawing.Color.Blue;
            this.bNewuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNewuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNewuser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bNewuser.Location = new System.Drawing.Point(460, 463);
            this.bNewuser.Name = "bNewuser";
            this.bNewuser.Size = new System.Drawing.Size(78, 23);
            this.bNewuser.TabIndex = 48;
            this.bNewuser.Text = "Nuevo";
            this.bNewuser.UseVisualStyleBackColor = false;
            this.bNewuser.Click += new System.EventHandler(this.bNewuser_Click);
            // 
            // bCanceluser
            // 
            this.bCanceluser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bCanceluser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCanceluser.ForeColor = System.Drawing.Color.White;
            this.bCanceluser.Location = new System.Drawing.Point(281, 463);
            this.bCanceluser.Name = "bCanceluser";
            this.bCanceluser.Size = new System.Drawing.Size(75, 23);
            this.bCanceluser.TabIndex = 50;
            this.bCanceluser.Text = "Cancelar";
            this.bCanceluser.UseVisualStyleBackColor = false;
            this.bCanceluser.Click += new System.EventHandler(this.bCanceluser_Click);
            // 
            // bEdituser
            // 
            this.bEdituser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bEdituser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEdituser.ForeColor = System.Drawing.Color.White;
            this.bEdituser.Location = new System.Drawing.Point(200, 463);
            this.bEdituser.Name = "bEdituser";
            this.bEdituser.Size = new System.Drawing.Size(75, 23);
            this.bEdituser.TabIndex = 49;
            this.bEdituser.Text = "Editar";
            this.bEdituser.UseVisualStyleBackColor = false;
            this.bEdituser.Click += new System.EventHandler(this.bEdituser_Click);
            // 
            // comboBoxCol
            // 
            this.comboBoxCol.FormattingEnabled = true;
            this.comboBoxCol.Items.AddRange(new object[] {
            "Nombre",
            "Correo"});
            this.comboBoxCol.Location = new System.Drawing.Point(347, 259);
            this.comboBoxCol.Name = "comboBoxCol";
            this.comboBoxCol.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCol.TabIndex = 47;
            this.comboBoxCol.Visible = false;
            // 
            // textBoxSearc
            // 
            this.textBoxSearc.Location = new System.Drawing.Point(241, 260);
            this.textBoxSearc.Name = "textBoxSearc";
            this.textBoxSearc.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearc.TabIndex = 46;
            this.textBoxSearc.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(239, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 24);
            this.label5.TabIndex = 45;
            this.label5.Text = "Registro de Clientes";
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.calleDataGridViewTextBoxColumn,
            this.coloniaDataGridViewTextBoxColumn,
            this.estadoidDataGridViewTextBoxColumn,
            this.municipioidDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.clienteBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(40, 295);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(606, 150);
            this.dataGridView5.TabIndex = 44;
            this.dataGridView5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellContentClick);
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // bibliotechDataSet6
            // 
            this.bibliotechDataSet6.DataSetName = "BibliotechDataSet6";
            this.bibliotechDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.bibliotechDataSet6;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "Id_Cliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "Id_Cliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // calleDataGridViewTextBoxColumn
            // 
            this.calleDataGridViewTextBoxColumn.DataPropertyName = "Calle";
            this.calleDataGridViewTextBoxColumn.HeaderText = "Calle";
            this.calleDataGridViewTextBoxColumn.Name = "calleDataGridViewTextBoxColumn";
            // 
            // coloniaDataGridViewTextBoxColumn
            // 
            this.coloniaDataGridViewTextBoxColumn.DataPropertyName = "Colonia";
            this.coloniaDataGridViewTextBoxColumn.HeaderText = "Colonia";
            this.coloniaDataGridViewTextBoxColumn.Name = "coloniaDataGridViewTextBoxColumn";
            // 
            // estadoidDataGridViewTextBoxColumn
            // 
            this.estadoidDataGridViewTextBoxColumn.DataPropertyName = "Estado_id";
            this.estadoidDataGridViewTextBoxColumn.HeaderText = "Estado_id";
            this.estadoidDataGridViewTextBoxColumn.Name = "estadoidDataGridViewTextBoxColumn";
            // 
            // municipioidDataGridViewTextBoxColumn
            // 
            this.municipioidDataGridViewTextBoxColumn.DataPropertyName = "Municipio_id";
            this.municipioidDataGridViewTextBoxColumn.HeaderText = "Municipio_id";
            this.municipioidDataGridViewTextBoxColumn.Name = "municipioidDataGridViewTextBoxColumn";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 554);
            this.Controls.Add(this.panel1);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotechDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotechDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEdo;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label labelEdicion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbCol;
        private System.Windows.Forms.TextBox tbCalle;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbMun;
        private System.Windows.Forms.Button bDeleteuser;
        private System.Windows.Forms.Button bSaveuser;
        private System.Windows.Forms.Button bNewuser;
        private System.Windows.Forms.Button bCanceluser;
        private System.Windows.Forms.Button bEdituser;
        private System.Windows.Forms.ComboBox comboBoxCol;
        private System.Windows.Forms.TextBox textBoxSearc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView5;
        private BibliotechDataSet5 bibliotechDataSet5;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private BibliotechDataSet5TableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.Label label1;
        private BibliotechDataSet6 bibliotechDataSet6;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private BibliotechDataSet6TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipioidDataGridViewTextBoxColumn;
    }
}