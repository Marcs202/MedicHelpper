namespace MedicHelpper
{
    partial class frmDoctor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctor));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_text = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cita = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_codPaci = new System.Windows.Forms.TextBox();
            this.txt_CODCITa = new System.Windows.Forms.TextBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_MostrarData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_guardar_diagnostico = new System.Windows.Forms.Button();
            this.txt_DescripcionDoc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_RecetDoc = new System.Windows.Forms.TextBox();
            this.txt_fecha_doc = new System.Windows.Forms.TextBox();
            this.txt_codusuario = new System.Windows.Forms.TextBox();
            this.txt_codigocita = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.pctAtras = new System.Windows.Forms.PictureBox();
            this.errorFecha = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCodigoCita = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCodigoTarjeta = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorPaciente = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFech = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCita = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCodigoCons = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCodUSuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbEspecilidadCita = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.AddCita.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigoCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigoTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigoCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodUSuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 48);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Size = new System.Drawing.Size(634, 325);
            this.tabControl1.Controls.SetChildIndex(this.tabPage2, 0);
            this.tabControl1.Controls.SetChildIndex(this.tabPage3, 0);
            this.tabControl1.Controls.SetChildIndex(this.tabPage1, 0);
            this.tabControl1.Controls.SetChildIndex(this.AddCita, 0);
            // 
            // dtpCita
            // 
            this.dtpCita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpCita.Location = new System.Drawing.Point(237, 57);
            this.dtpCita.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTarjeta.Location = new System.Drawing.Point(237, 101);
            this.txtTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.txtTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnAddCita
            // 
            this.btnAddCita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCita.Location = new System.Drawing.Point(452, 212);
            this.btnAddCita.Click += new System.EventHandler(this.btnAddCita_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.Location = new System.Drawing.Point(98, 101);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.Location = new System.Drawing.Point(99, 60);
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstado.Location = new System.Drawing.Point(174, 248);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.Location = new System.Drawing.Point(99, 248);
            // 
            // AddCita
            // 
            this.AddCita.Controls.Add(this.pictureBox2);
            this.AddCita.Controls.Add(this.cbEspecilidadCita);
            this.AddCita.Controls.Add(this.label15);
            this.AddCita.Margin = new System.Windows.Forms.Padding(2);
            this.AddCita.Padding = new System.Windows.Forms.Padding(2);
            this.AddCita.Size = new System.Drawing.Size(626, 296);
            this.AddCita.Text = "Agregar cita";
            this.AddCita.Controls.SetChildIndex(this.btnAddCita, 0);
            this.AddCita.Controls.SetChildIndex(this.txtTarjeta, 0);
            this.AddCita.Controls.SetChildIndex(this.dtpCita, 0);
            this.AddCita.Controls.SetChildIndex(this.label7, 0);
            this.AddCita.Controls.SetChildIndex(this.label5, 0);
            this.AddCita.Controls.SetChildIndex(this.label6, 0);
            this.AddCita.Controls.SetChildIndex(this.lblEstado, 0);
            this.AddCita.Controls.SetChildIndex(this.label8, 0);
            this.AddCita.Controls.SetChildIndex(this.txtCita, 0);
            this.AddCita.Controls.SetChildIndex(this.label15, 0);
            this.AddCita.Controls.SetChildIndex(this.cbEspecilidadCita, 0);
            this.AddCita.Controls.SetChildIndex(this.pictureBox2, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(611, 2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(99, 191);
            // 
            // txtCita
            // 
            this.txtCita.Location = new System.Drawing.Point(237, 191);
            this.txtCita.ReadOnly = true;
            this.txtCita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.Lbl_text);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_cita);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_codPaci);
            this.tabPage1.Controls.Add(this.txt_CODCITa);
            this.tabPage1.Controls.Add(this.txt_fecha);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(626, 296);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Busqueda de Cita";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(211, 75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_text
            // 
            this.Lbl_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_text.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_text.Location = new System.Drawing.Point(-188, 25);
            this.Lbl_text.Name = "Lbl_text";
            this.Lbl_text.Size = new System.Drawing.Size(269, 22);
            this.Lbl_text.TabIndex = 32;
            this.Lbl_text.Text = "Busqueda de citas programadas";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.BackColor = System.Drawing.Color.LightGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(215, 222);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 35);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Consultar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-143, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Estado de cita:";
            this.label4.Visible = false;
            // 
            // txt_cita
            // 
            this.txt_cita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_cita.Location = new System.Drawing.Point(30, 231);
            this.txt_cita.Name = "txt_cita";
            this.txt_cita.ReadOnly = true;
            this.txt_cita.Size = new System.Drawing.Size(9, 20);
            this.txt_cita.TabIndex = 29;
            this.txt_cita.Visible = false;
            this.txt_cita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cita_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-143, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ingrese codigo de cita:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-143, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Fecha de cita:";
            this.label3.Visible = false;
            // 
            // txt_codPaci
            // 
            this.txt_codPaci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_codPaci.Location = new System.Drawing.Point(46, 114);
            this.txt_codPaci.Name = "txt_codPaci";
            this.txt_codPaci.ReadOnly = true;
            this.txt_codPaci.Size = new System.Drawing.Size(100, 20);
            this.txt_codPaci.TabIndex = 25;
            this.txt_codPaci.Visible = false;
            this.txt_codPaci.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codPaci_KeyPress);
            // 
            // txt_CODCITa
            // 
            this.txt_CODCITa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_CODCITa.Location = new System.Drawing.Point(55, 71);
            this.txt_CODCITa.Name = "txt_CODCITa";
            this.txt_CODCITa.Size = new System.Drawing.Size(100, 20);
            this.txt_CODCITa.TabIndex = 23;
            this.txt_CODCITa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CODCITa_KeyPress);
            // 
            // txt_fecha
            // 
            this.txt_fecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_fecha.Location = new System.Drawing.Point(55, 172);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha.TabIndex = 24;
            this.txt_fecha.Visible = false;
            this.txt_fecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fecha_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-143, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Codigo de paciente:";
            this.label2.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_MostrarData);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(626, 296);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Citas pendientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_MostrarData
            // 
            this.btn_MostrarData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MostrarData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_MostrarData.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_MostrarData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MostrarData.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MostrarData.Image = ((System.Drawing.Image)(resources.GetObject("btn_MostrarData.Image")));
            this.btn_MostrarData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_MostrarData.Location = new System.Drawing.Point(472, 269);
            this.btn_MostrarData.Name = "btn_MostrarData";
            this.btn_MostrarData.Size = new System.Drawing.Size(103, 24);
            this.btn_MostrarData.TabIndex = 4;
            this.btn_MostrarData.Text = "Mostrar";
            this.btn_MostrarData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MostrarData.UseVisualStyleBackColor = false;
            this.btn_MostrarData.Click += new System.EventHandler(this.btn_MostrarData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(600, 252);
            this.dataGridView1.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(626, 296);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Diagnostico";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btn_guardar_diagnostico);
            this.groupBox1.Controls.Add(this.txt_DescripcionDoc);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_RecetDoc);
            this.groupBox1.Controls.Add(this.txt_fecha_doc);
            this.groupBox1.Controls.Add(this.txt_codusuario);
            this.groupBox1.Controls.Add(this.txt_codigocita);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 296);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Ingrese datos de diagnostico";
            // 
            // btn_guardar_diagnostico
            // 
            this.btn_guardar_diagnostico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar_diagnostico.BackColor = System.Drawing.Color.LightGreen;
            this.btn_guardar_diagnostico.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_diagnostico.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar_diagnostico.Image")));
            this.btn_guardar_diagnostico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar_diagnostico.Location = new System.Drawing.Point(511, 255);
            this.btn_guardar_diagnostico.Name = "btn_guardar_diagnostico";
            this.btn_guardar_diagnostico.Size = new System.Drawing.Size(99, 35);
            this.btn_guardar_diagnostico.TabIndex = 22;
            this.btn_guardar_diagnostico.Text = "Guardar";
            this.btn_guardar_diagnostico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar_diagnostico.UseVisualStyleBackColor = false;
            this.btn_guardar_diagnostico.Click += new System.EventHandler(this.btn_guardar_diagnostico_Click);
            // 
            // txt_DescripcionDoc
            // 
            this.txt_DescripcionDoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_DescripcionDoc.Location = new System.Drawing.Point(263, 136);
            this.txt_DescripcionDoc.Multiline = true;
            this.txt_DescripcionDoc.Name = "txt_DescripcionDoc";
            this.txt_DescripcionDoc.Size = new System.Drawing.Size(360, 113);
            this.txt_DescripcionDoc.TabIndex = 10;
            this.txt_DescripcionDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DescripcionDoc_KeyPress);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(97, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "Codigo de Receta:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Descripcion de consulta:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(402, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Fecha:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(97, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Codigo de Cita:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(97, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Codigo de Doctor:";
            // 
            // txt_RecetDoc
            // 
            this.txt_RecetDoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_RecetDoc.Location = new System.Drawing.Point(263, 101);
            this.txt_RecetDoc.Name = "txt_RecetDoc";
            this.txt_RecetDoc.Size = new System.Drawing.Size(100, 23);
            this.txt_RecetDoc.TabIndex = 1;
            this.txt_RecetDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ConsultaDoc_KeyPress);
            // 
            // txt_fecha_doc
            // 
            this.txt_fecha_doc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_fecha_doc.Location = new System.Drawing.Point(464, 61);
            this.txt_fecha_doc.Name = "txt_fecha_doc";
            this.txt_fecha_doc.Size = new System.Drawing.Size(100, 23);
            this.txt_fecha_doc.TabIndex = 4;
            this.txt_fecha_doc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fecha_doc_KeyPress);
            // 
            // txt_codusuario
            // 
            this.txt_codusuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_codusuario.Location = new System.Drawing.Point(263, 33);
            this.txt_codusuario.Name = "txt_codusuario";
            this.txt_codusuario.Size = new System.Drawing.Size(100, 23);
            this.txt_codusuario.TabIndex = 2;
            this.txt_codusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codusuario_KeyPress);
            // 
            // txt_codigocita
            // 
            this.txt_codigocita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_codigocita.Location = new System.Drawing.Point(263, 64);
            this.txt_codigocita.Name = "txt_codigocita";
            this.txt_codigocita.Size = new System.Drawing.Size(100, 23);
            this.txt_codigocita.TabIndex = 3;
            this.txt_codigocita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigocita_KeyPress);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(-197, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(372, 26);
            this.label14.TabIndex = 20;
            this.label14.Text = "Diagnóstico Médico de paciente";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(535, 3);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 28);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 12;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(570, 2);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(37, 28);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 11;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // pctAtras
            // 
            this.pctAtras.Image = ((System.Drawing.Image)(resources.GetObject("pctAtras.Image")));
            this.pctAtras.Location = new System.Drawing.Point(27, 3);
            this.pctAtras.Margin = new System.Windows.Forms.Padding(2);
            this.pctAtras.Name = "pctAtras";
            this.pctAtras.Size = new System.Drawing.Size(38, 31);
            this.pctAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctAtras.TabIndex = 16;
            this.pctAtras.TabStop = false;
            this.pctAtras.Click += new System.EventHandler(this.pctAtras_Click);
            // 
            // errorFecha
            // 
            this.errorFecha.ContainerControl = this;
            // 
            // errorCodigoCita
            // 
            this.errorCodigoCita.ContainerControl = this;
            // 
            // errorCodigoTarjeta
            // 
            this.errorCodigoTarjeta.ContainerControl = this;
            // 
            // ErrorPaciente
            // 
            this.ErrorPaciente.ContainerControl = this;
            // 
            // errorFech
            // 
            this.errorFech.ContainerControl = this;
            // 
            // errorCita
            // 
            this.errorCita.ContainerControl = this;
            // 
            // errorCodigoCons
            // 
            this.errorCodigoCons.ContainerControl = this;
            // 
            // errorCodUSuario
            // 
            this.errorCodUSuario.ContainerControl = this;
            // 
            // errorDescripcion
            // 
            this.errorDescripcion.ContainerControl = this;
            // 
            // cbEspecilidadCita
            // 
            this.cbEspecilidadCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecilidadCita.FormattingEnabled = true;
            this.cbEspecilidadCita.Items.AddRange(new object[] {
            "General",
            "Pediatría",
            "Neumología",
            "Gastroenterología"});
            this.cbEspecilidadCita.Location = new System.Drawing.Point(237, 146);
            this.cbEspecilidadCita.Name = "cbEspecilidadCita";
            this.cbEspecilidadCita.Size = new System.Drawing.Size(121, 21);
            this.cbEspecilidadCita.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(106, 146);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 16);
            this.label15.TabIndex = 39;
            this.label15.Text = "Especialidad";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MedicHelpper.Properties.Resources.medico;
            this.pictureBox2.Location = new System.Drawing.Point(456, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // frmDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(656, 384);
            this.Controls.Add(this.pctAtras);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnRestaurar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "frmDoctor";
            this.Text = "Doctores";
            this.Controls.SetChildIndex(this.btnRestaurar, 0);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.pctAtras, 0);
            this.Controls.SetChildIndex(this.btnCerrar, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.AddCita.ResumeLayout(false);
            this.AddCita.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigoCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigoTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigoCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodUSuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label Lbl_text;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_codPaci;
        private System.Windows.Forms.TextBox txt_CODCITa;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button btn_guardar_diagnostico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_DescripcionDoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_RecetDoc;
        private System.Windows.Forms.TextBox txt_fecha_doc;
        private System.Windows.Forms.TextBox txt_codusuario;
        private System.Windows.Forms.TextBox txt_codigocita;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_MostrarData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox pctAtras;
        private System.Windows.Forms.ErrorProvider errorFecha;
        private System.Windows.Forms.ErrorProvider errorCodigoCita;
        private System.Windows.Forms.ErrorProvider errorCodigoTarjeta;
        private System.Windows.Forms.ErrorProvider ErrorPaciente;
        private System.Windows.Forms.ErrorProvider errorFech;
        private System.Windows.Forms.ErrorProvider errorCita;
        private System.Windows.Forms.ErrorProvider errorCodigoCons;
        private System.Windows.Forms.ErrorProvider errorCodUSuario;
        private System.Windows.Forms.ErrorProvider errorDescripcion;
        private System.Windows.Forms.ComboBox cbEspecilidadCita;
        protected System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
