namespace MedicHelpper
{
    partial class Farmaceuticos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Farmaceuticos));
            this.pctAtras = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.errorFechaMedicamento = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCodigoMed = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCantidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorUbicacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabFarmaceutico = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtgv_buscaRecta = new System.Windows.Forms.DataGridView();
            this.txtIdReceta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgv_BusquedaMEd = new System.Windows.Forms.DataGridView();
            this.txtBuscaMed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addMedicamentos = new System.Windows.Forms.TabPage();
            this.dtgVAnadirMedicamento = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMostMedicamento = new System.Windows.Forms.Button();
            this.btningresarusuario = new System.Windows.Forms.Button();
            this.datmMedicamento = new System.Windows.Forms.DateTimePicker();
            this.txtUbicacionMed = new System.Windows.Forms.TextBox();
            this.txtDescripcionmed = new System.Windows.Forms.TextBox();
            this.txtCantidadMed = new System.Windows.Forms.TextBox();
            this.txtNOmbreMEdicamento = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnActualizarMed = new System.Windows.Forms.Button();
            this.txtCantMed = new System.Windows.Forms.TextBox();
            this.txtCodMedicamento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgv_Despacho = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pctAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFechaMedicamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigoMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUbicacion)).BeginInit();
            this.tabFarmaceutico.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_buscaRecta)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_BusquedaMEd)).BeginInit();
            this.addMedicamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVAnadirMedicamento)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Despacho)).BeginInit();
            this.SuspendLayout();
            // 
            // pctAtras
            // 
            this.pctAtras.Image = global::MedicHelpper.Properties.Resources.Atras;
            this.pctAtras.Location = new System.Drawing.Point(11, 11);
            this.pctAtras.Margin = new System.Windows.Forms.Padding(2);
            this.pctAtras.Name = "pctAtras";
            this.pctAtras.Size = new System.Drawing.Size(38, 31);
            this.pctAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctAtras.TabIndex = 16;
            this.pctAtras.TabStop = false;
            this.pctAtras.Click += new System.EventHandler(this.pctAtras_Click_1);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = global::MedicHelpper.Properties.Resources.minimizar2;
            this.btnMinimizar.Location = new System.Drawing.Point(548, 11);
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
            this.btnRestaurar.Image = global::MedicHelpper.Properties.Resources.redimensionar;
            this.btnRestaurar.Location = new System.Drawing.Point(592, 11);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(37, 28);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 11;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click_1);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(635, 11);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(37, 31);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // errorFechaMedicamento
            // 
            this.errorFechaMedicamento.ContainerControl = this;
            // 
            // errorCodigoMed
            // 
            this.errorCodigoMed.ContainerControl = this;
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorCantidad
            // 
            this.errorCantidad.ContainerControl = this;
            // 
            // errorDescripcion
            // 
            this.errorDescripcion.ContainerControl = this;
            // 
            // errorUbicacion
            // 
            this.errorUbicacion.ContainerControl = this;
            // 
            // tabFarmaceutico
            // 
            this.tabFarmaceutico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabFarmaceutico.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabFarmaceutico.Controls.Add(this.tabPage1);
            this.tabFarmaceutico.Controls.Add(this.tabPage2);
            this.tabFarmaceutico.Controls.Add(this.addMedicamentos);
            this.tabFarmaceutico.Controls.Add(this.tabPage3);
            this.tabFarmaceutico.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFarmaceutico.Location = new System.Drawing.Point(12, 48);
            this.tabFarmaceutico.Name = "tabFarmaceutico";
            this.tabFarmaceutico.SelectedIndex = 0;
            this.tabFarmaceutico.Size = new System.Drawing.Size(657, 412);
            this.tabFarmaceutico.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.dtgv_buscaRecta);
            this.tabPage1.Controls.Add(this.txtIdReceta);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(649, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta de Receta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.LightGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::MedicHelpper.Properties.Resources.headhunter;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(358, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 27);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtgv_buscaRecta
            // 
            this.dtgv_buscaRecta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_buscaRecta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_buscaRecta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_buscaRecta.GridColor = System.Drawing.Color.Silver;
            this.dtgv_buscaRecta.Location = new System.Drawing.Point(11, 69);
            this.dtgv_buscaRecta.MultiSelect = false;
            this.dtgv_buscaRecta.Name = "dtgv_buscaRecta";
            this.dtgv_buscaRecta.RowHeadersVisible = false;
            this.dtgv_buscaRecta.RowHeadersWidth = 51;
            this.dtgv_buscaRecta.Size = new System.Drawing.Size(627, 220);
            this.dtgv_buscaRecta.TabIndex = 3;
            // 
            // txtIdReceta
            // 
            this.txtIdReceta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdReceta.Location = new System.Drawing.Point(166, 29);
            this.txtIdReceta.Name = "txtIdReceta";
            this.txtIdReceta.Size = new System.Drawing.Size(142, 23);
            this.txtIdReceta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo Receta";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dtgv_BusquedaMEd);
            this.tabPage2.Controls.Add(this.txtBuscaMed);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(649, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Busqueda Medicamento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::MedicHelpper.Properties.Resources.headhunter;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(352, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 27);
            this.button1.TabIndex = 32;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgv_BusquedaMEd
            // 
            this.dtgv_BusquedaMEd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_BusquedaMEd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_BusquedaMEd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_BusquedaMEd.EnableHeadersVisualStyles = false;
            this.dtgv_BusquedaMEd.Location = new System.Drawing.Point(3, 73);
            this.dtgv_BusquedaMEd.Name = "dtgv_BusquedaMEd";
            this.dtgv_BusquedaMEd.ReadOnly = true;
            this.dtgv_BusquedaMEd.RowHeadersVisible = false;
            this.dtgv_BusquedaMEd.RowHeadersWidth = 51;
            this.dtgv_BusquedaMEd.Size = new System.Drawing.Size(644, 144);
            this.dtgv_BusquedaMEd.TabIndex = 3;
            // 
            // txtBuscaMed
            // 
            this.txtBuscaMed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuscaMed.Location = new System.Drawing.Point(210, 34);
            this.txtBuscaMed.Name = "txtBuscaMed";
            this.txtBuscaMed.Size = new System.Drawing.Size(100, 23);
            this.txtBuscaMed.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Medicamento";
            // 
            // addMedicamentos
            // 
            this.addMedicamentos.Controls.Add(this.dtgVAnadirMedicamento);
            this.addMedicamentos.Controls.Add(this.groupBox1);
            this.addMedicamentos.Location = new System.Drawing.Point(4, 27);
            this.addMedicamentos.Margin = new System.Windows.Forms.Padding(2);
            this.addMedicamentos.Name = "addMedicamentos";
            this.addMedicamentos.Padding = new System.Windows.Forms.Padding(2);
            this.addMedicamentos.Size = new System.Drawing.Size(649, 381);
            this.addMedicamentos.TabIndex = 2;
            this.addMedicamentos.Text = "Añadir medicamentos";
            this.addMedicamentos.UseVisualStyleBackColor = true;
            // 
            // dtgVAnadirMedicamento
            // 
            this.dtgVAnadirMedicamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVAnadirMedicamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVAnadirMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVAnadirMedicamento.EnableHeadersVisualStyles = false;
            this.dtgVAnadirMedicamento.Location = new System.Drawing.Point(5, 217);
            this.dtgVAnadirMedicamento.Name = "dtgVAnadirMedicamento";
            this.dtgVAnadirMedicamento.ReadOnly = true;
            this.dtgVAnadirMedicamento.RowHeadersVisible = false;
            this.dtgVAnadirMedicamento.RowHeadersWidth = 51;
            this.dtgVAnadirMedicamento.Size = new System.Drawing.Size(639, 144);
            this.dtgVAnadirMedicamento.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnMostMedicamento);
            this.groupBox1.Controls.Add(this.btningresarusuario);
            this.groupBox1.Controls.Add(this.datmMedicamento);
            this.groupBox1.Controls.Add(this.txtUbicacionMed);
            this.groupBox1.Controls.Add(this.txtDescripcionmed);
            this.groupBox1.Controls.Add(this.txtCantidadMed);
            this.groupBox1.Controls.Add(this.txtNOmbreMEdicamento);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(10, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnMostMedicamento
            // 
            this.btnMostMedicamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMostMedicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.btnMostMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostMedicamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.btnMostMedicamento.Location = new System.Drawing.Point(306, 164);
            this.btnMostMedicamento.Name = "btnMostMedicamento";
            this.btnMostMedicamento.Size = new System.Drawing.Size(187, 29);
            this.btnMostMedicamento.TabIndex = 16;
            this.btnMostMedicamento.Text = "Mostrar Medicamento";
            this.btnMostMedicamento.UseVisualStyleBackColor = false;
            this.btnMostMedicamento.Click += new System.EventHandler(this.btnMostMedicamento_Click);
            // 
            // btningresarusuario
            // 
            this.btningresarusuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btningresarusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.btningresarusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningresarusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.btningresarusuario.Location = new System.Drawing.Point(178, 164);
            this.btningresarusuario.Name = "btningresarusuario";
            this.btningresarusuario.Size = new System.Drawing.Size(75, 29);
            this.btningresarusuario.TabIndex = 15;
            this.btningresarusuario.Text = "Ingresar";
            this.btningresarusuario.UseVisualStyleBackColor = false;
            this.btningresarusuario.Click += new System.EventHandler(this.btningresarusuario_Click);
            // 
            // datmMedicamento
            // 
            this.datmMedicamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datmMedicamento.Location = new System.Drawing.Point(396, 124);
            this.datmMedicamento.Name = "datmMedicamento";
            this.datmMedicamento.Size = new System.Drawing.Size(200, 23);
            this.datmMedicamento.TabIndex = 14;
            // 
            // txtUbicacionMed
            // 
            this.txtUbicacionMed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUbicacionMed.Location = new System.Drawing.Point(232, 124);
            this.txtUbicacionMed.Name = "txtUbicacionMed";
            this.txtUbicacionMed.Size = new System.Drawing.Size(117, 23);
            this.txtUbicacionMed.TabIndex = 11;
            this.txtUbicacionMed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUbicacionMed_KeyPress);
            // 
            // txtDescripcionmed
            // 
            this.txtDescripcionmed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescripcionmed.Location = new System.Drawing.Point(10, 122);
            this.txtDescripcionmed.Name = "txtDescripcionmed";
            this.txtDescripcionmed.Size = new System.Drawing.Size(122, 23);
            this.txtDescripcionmed.TabIndex = 10;
            this.txtDescripcionmed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcionmed_KeyPress);
            // 
            // txtCantidadMed
            // 
            this.txtCantidadMed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCantidadMed.Location = new System.Drawing.Point(360, 58);
            this.txtCantidadMed.Name = "txtCantidadMed";
            this.txtCantidadMed.Size = new System.Drawing.Size(115, 23);
            this.txtCantidadMed.TabIndex = 9;
            this.txtCantidadMed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadMed_KeyPress);
            // 
            // txtNOmbreMEdicamento
            // 
            this.txtNOmbreMEdicamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNOmbreMEdicamento.Location = new System.Drawing.Point(178, 58);
            this.txtNOmbreMEdicamento.Name = "txtNOmbreMEdicamento";
            this.txtNOmbreMEdicamento.Size = new System.Drawing.Size(117, 23);
            this.txtNOmbreMEdicamento.TabIndex = 8;
            this.txtNOmbreMEdicamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNOmbreMEdicamento_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCodigo.Location = new System.Drawing.Point(10, 58);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(119, 23);
            this.txtCodigo.TabIndex = 7;
            this.txtCodigo.Visible = false;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(429, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Fecha de Expiracion";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(257, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ubicacion";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(393, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Codigo Medicamento";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Agregar Medicamento";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(649, 381);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Despacho Medicina";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnActualizarMed);
            this.groupBox2.Controls.Add(this.txtCantMed);
            this.groupBox2.Controls.Add(this.txtCodMedicamento);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dtgv_Despacho);
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 375);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Despacho";
            // 
            // btnActualizarMed
            // 
            this.btnActualizarMed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActualizarMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.btnActualizarMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.btnActualizarMed.Location = new System.Drawing.Point(502, 40);
            this.btnActualizarMed.Name = "btnActualizarMed";
            this.btnActualizarMed.Size = new System.Drawing.Size(105, 29);
            this.btnActualizarMed.TabIndex = 16;
            this.btnActualizarMed.Text = "Actualizar";
            this.btnActualizarMed.UseVisualStyleBackColor = false;
            this.btnActualizarMed.Click += new System.EventHandler(this.btnActualizarMed_Click);
            // 
            // txtCantMed
            // 
            this.txtCantMed.Location = new System.Drawing.Point(373, 44);
            this.txtCantMed.Name = "txtCantMed";
            this.txtCantMed.Size = new System.Drawing.Size(100, 23);
            this.txtCantMed.TabIndex = 4;
            // 
            // txtCodMedicamento
            // 
            this.txtCodMedicamento.Location = new System.Drawing.Point(155, 41);
            this.txtCodMedicamento.Name = "txtCodMedicamento";
            this.txtCodMedicamento.Size = new System.Drawing.Size(100, 23);
            this.txtCodMedicamento.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(292, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Codigo Medicamento";
            // 
            // dtgv_Despacho
            // 
            this.dtgv_Despacho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Despacho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Despacho.Location = new System.Drawing.Point(19, 96);
            this.dtgv_Despacho.Name = "dtgv_Despacho";
            this.dtgv_Despacho.ReadOnly = true;
            this.dtgv_Despacho.RowHeadersVisible = false;
            this.dtgv_Despacho.Size = new System.Drawing.Size(597, 273);
            this.dtgv_Despacho.TabIndex = 0;
            // 
            // Farmaceuticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(681, 459);
            this.Controls.Add(this.pctAtras);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.tabFarmaceutico);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Farmaceuticos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmaceuticos";
            ((System.ComponentModel.ISupportInitialize)(this.pctAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFechaMedicamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigoMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUbicacion)).EndInit();
            this.tabFarmaceutico.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_buscaRecta)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_BusquedaMEd)).EndInit();
            this.addMedicamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVAnadirMedicamento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Despacho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox pctAtras;
        private System.Windows.Forms.ErrorProvider errorFechaMedicamento;
        private System.Windows.Forms.ErrorProvider errorCodigoMed;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorCantidad;
        private System.Windows.Forms.ErrorProvider errorDescripcion;
        private System.Windows.Forms.ErrorProvider errorUbicacion;
        private System.Windows.Forms.TabControl tabFarmaceutico;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dtgv_buscaRecta;
        private System.Windows.Forms.TextBox txtIdReceta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgv_BusquedaMEd;
        private System.Windows.Forms.TextBox txtBuscaMed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage addMedicamentos;
        private System.Windows.Forms.DataGridView dtgVAnadirMedicamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btningresarusuario;
        private System.Windows.Forms.DateTimePicker datmMedicamento;
        private System.Windows.Forms.TextBox txtUbicacionMed;
        private System.Windows.Forms.TextBox txtDescripcionmed;
        private System.Windows.Forms.TextBox txtCantidadMed;
        private System.Windows.Forms.TextBox txtNOmbreMEdicamento;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnMostMedicamento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnActualizarMed;
        private System.Windows.Forms.TextBox txtCantMed;
        private System.Windows.Forms.TextBox txtCodMedicamento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgv_Despacho;
    }
}