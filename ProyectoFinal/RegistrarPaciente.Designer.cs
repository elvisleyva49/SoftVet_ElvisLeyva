namespace ProyectoFinal
{
    partial class RegistrarPaciente
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.datePickPaciente = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAgregarProp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDocumentoBuscar = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDocumentoCliente = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodDueño = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombreDueño = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDocumentoDueño = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefonoDueño = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictpaciente = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictpaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(440, 551);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(462, 466);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(68, 27);
            this.btnLimpiar.TabIndex = 38;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbGenero);
            this.groupBox2.Controls.Add(this.datePickPaciente);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNombreMascota);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pictpaciente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtRaza);
            this.groupBox2.Controls.Add(this.cmbEspecie);
            this.groupBox2.Location = new System.Drawing.Point(215, 80);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(530, 215);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paciente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 14);
            this.label6.TabIndex = 22;
            this.label6.Text = "Genero: ";
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Macho",
            "Hembra"});
            this.cmbGenero.Location = new System.Drawing.Point(80, 147);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(92, 21);
            this.cmbGenero.TabIndex = 21;
            // 
            // datePickPaciente
            // 
            this.datePickPaciente.Location = new System.Drawing.Point(152, 175);
            this.datePickPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.datePickPaciente.Name = "datePickPaciente";
            this.datePickPaciente.Size = new System.Drawing.Size(192, 20);
            this.datePickPaciente.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de la mascota: ";
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Location = new System.Drawing.Point(155, 43);
            this.txtNombreMascota.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(94, 20);
            this.txtNombreMascota.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Especie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha de Nacimiento: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Raza: ";
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(81, 109);
            this.txtRaza.Margin = new System.Windows.Forms.Padding(2);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(94, 20);
            this.txtRaza.TabIndex = 7;
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Items.AddRange(new object[] {
            "Perro",
            "Gato",
            "Otros"});
            this.cmbEspecie.Location = new System.Drawing.Point(83, 78);
            this.cmbEspecie.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(92, 21);
            this.cmbEspecie.TabIndex = 8;
            this.cmbEspecie.SelectedIndexChanged += new System.EventHandler(this.cmbEspecie_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCodCliente);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnAgregarProp);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtDocumentoBuscar);
            this.groupBox3.Controls.Add(this.txtNombreCliente);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtDocumentoCliente);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtTelefonoCliente);
            this.groupBox3.Location = new System.Drawing.Point(215, 301);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(530, 160);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Propietario";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Enabled = false;
            this.txtCodCliente.Location = new System.Drawing.Point(85, 51);
            this.txtCodCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(129, 20);
            this.txtCodCliente.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 51);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 14);
            this.label12.TabIndex = 30;
            this.label12.Text = "Codigo:";
            // 
            // btnAgregarProp
            // 
            this.btnAgregarProp.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProp.Location = new System.Drawing.Point(353, 20);
            this.btnAgregarProp.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarProp.Name = "btnAgregarProp";
            this.btnAgregarProp.Size = new System.Drawing.Size(79, 26);
            this.btnAgregarProp.TabIndex = 28;
            this.btnAgregarProp.Text = "Agregar";
            this.btnAgregarProp.UseVisualStyleBackColor = true;
            this.btnAgregarProp.Click += new System.EventHandler(this.btnAgregarProp_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(242, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 26);
            this.button2.TabIndex = 27;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 24);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 14);
            this.label13.TabIndex = 26;
            this.label13.Text = "Ingrese Documento: ";
            // 
            // txtDocumentoBuscar
            // 
            this.txtDocumentoBuscar.Location = new System.Drawing.Point(127, 20);
            this.txtDocumentoBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumentoBuscar.Name = "txtDocumentoBuscar";
            this.txtDocumentoBuscar.Size = new System.Drawing.Size(104, 20);
            this.txtDocumentoBuscar.TabIndex = 25;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(84, 77);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(129, 20);
            this.txtNombreCliente.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 108);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 14);
            this.label14.TabIndex = 24;
            this.label14.Text = "Documento:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 79);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 14);
            this.label15.TabIndex = 18;
            this.label15.Text = "Nombre:";
            // 
            // txtDocumentoCliente
            // 
            this.txtDocumentoCliente.Enabled = false;
            this.txtDocumentoCliente.Location = new System.Drawing.Point(85, 105);
            this.txtDocumentoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumentoCliente.Name = "txtDocumentoCliente";
            this.txtDocumentoCliente.Size = new System.Drawing.Size(122, 20);
            this.txtDocumentoCliente.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 135);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 14);
            this.label16.TabIndex = 21;
            this.label16.Text = "Telefono: ";
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Enabled = false;
            this.txtTelefonoCliente.Location = new System.Drawing.Point(85, 131);
            this.txtTelefonoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(103, 20);
            this.txtTelefonoCliente.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodDueño);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.txtNombreDueño);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDocumentoDueño);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTelefonoDueño);
            this.groupBox1.Location = new System.Drawing.Point(275, 301);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(376, 160);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propietario";
            // 
            // txtCodDueño
            // 
            this.txtCodDueño.Location = new System.Drawing.Point(60, 49);
            this.txtCodDueño.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodDueño.Name = "txtCodDueño";
            this.txtCodDueño.Size = new System.Drawing.Size(129, 20);
            this.txtCodDueño.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 51);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 14);
            this.label11.TabIndex = 30;
            this.label11.Text = "Codigo:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(308, 20);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(56, 19);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(242, 20);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 18);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 14);
            this.label10.TabIndex = 26;
            this.label10.Text = "Ingrese Documento: ";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(127, 20);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(104, 20);
            this.txtDNI.TabIndex = 25;
            // 
            // txtNombreDueño
            // 
            this.txtNombreDueño.Location = new System.Drawing.Point(65, 76);
            this.txtNombreDueño.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreDueño.Name = "txtNombreDueño";
            this.txtNombreDueño.Size = new System.Drawing.Size(129, 20);
            this.txtNombreDueño.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 14);
            this.label9.TabIndex = 24;
            this.label9.Text = "Documento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 14);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nombre:";
            // 
            // txtDocumentoDueño
            // 
            this.txtDocumentoDueño.Location = new System.Drawing.Point(80, 108);
            this.txtDocumentoDueño.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumentoDueño.Name = "txtDocumentoDueño";
            this.txtDocumentoDueño.Size = new System.Drawing.Size(122, 20);
            this.txtDocumentoDueño.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 135);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 14);
            this.label8.TabIndex = 21;
            this.label8.Text = "Telefono: ";
            // 
            // txtTelefonoDueño
            // 
            this.txtTelefonoDueño.Location = new System.Drawing.Point(68, 133);
            this.txtTelefonoDueño.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefonoDueño.Name = "txtTelefonoDueño";
            this.txtTelefonoDueño.Size = new System.Drawing.Size(103, 20);
            this.txtTelefonoDueño.TabIndex = 22;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(386, 466);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(72, 27);
            this.btnRegistrar.TabIndex = 34;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(362, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Registrar Paciente";
            // 
            // pictpaciente
            // 
            this.pictpaciente.Image = global::ProyectoFinal.Properties.Resources.registrarmascota;
            this.pictpaciente.Location = new System.Drawing.Point(353, 32);
            this.pictpaciente.Margin = new System.Windows.Forms.Padding(2);
            this.pictpaciente.Name = "pictpaciente";
            this.pictpaciente.Size = new System.Drawing.Size(146, 136);
            this.pictpaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictpaciente.TabIndex = 5;
            this.pictpaciente.TabStop = false;
            // 
            // RegistrarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 582);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistrarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RegistrarPaciente_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictpaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.DateTimePicker datePickPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictpaciente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAgregarProp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDocumentoBuscar;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDocumentoCliente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodDueño;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombreDueño;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDocumentoDueño;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefonoDueño;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label1;
    }
}