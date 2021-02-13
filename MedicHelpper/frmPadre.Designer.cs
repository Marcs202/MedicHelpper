namespace MedicHelpper
{
    partial class frmPadre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPadre));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddCita = new System.Windows.Forms.TabPage();
            this.txtCita = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpCita = new System.Windows.Forms.DateTimePicker();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.btnAddCita = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.AddCita.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(509, 12);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(37, 31);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.AddCita);
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 44);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(543, 321);
            this.tabControl1.TabIndex = 6;
            // 
            // AddCita
            // 
            this.AddCita.BackColor = System.Drawing.Color.Silver;
            this.AddCita.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AddCita.Controls.Add(this.txtCita);
            this.AddCita.Controls.Add(this.label8);
            this.AddCita.Controls.Add(this.lblEstado);
            this.AddCita.Controls.Add(this.label6);
            this.AddCita.Controls.Add(this.label5);
            this.AddCita.Controls.Add(this.label7);
            this.AddCita.Controls.Add(this.dtpCita);
            this.AddCita.Controls.Add(this.txtTarjeta);
            this.AddCita.Controls.Add(this.btnAddCita);
            this.AddCita.Location = new System.Drawing.Point(4, 25);
            this.AddCita.Name = "AddCita";
            this.AddCita.Padding = new System.Windows.Forms.Padding(3);
            this.AddCita.Size = new System.Drawing.Size(535, 292);
            this.AddCita.TabIndex = 1;
            this.AddCita.Text = "Agregar Cita";
            // 
            // txtCita
            // 
            this.txtCita.Location = new System.Drawing.Point(185, 157);
            this.txtCita.Name = "txtCita";
            this.txtCita.Size = new System.Drawing.Size(100, 20);
            this.txtCita.TabIndex = 26;
            this.txtCita.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "N° De Cita";
            this.label8.Visible = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(128, 222);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(14, 15);
            this.lblEstado.TabIndex = 24;
            this.lblEstado.Text = ".";
            this.lblEstado.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Estado:";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nº de tarjeta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Fecha de cita:";
            // 
            // dtpCita
            // 
            this.dtpCita.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCita.Location = new System.Drawing.Point(185, 38);
            this.dtpCita.Name = "dtpCita";
            this.dtpCita.Size = new System.Drawing.Size(172, 20);
            this.dtpCita.TabIndex = 19;
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(185, 102);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(100, 20);
            this.txtTarjeta.TabIndex = 15;
            // 
            // btnAddCita
            // 
            this.btnAddCita.BackColor = System.Drawing.Color.Wheat;
            this.btnAddCita.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCita.Image = global::MedicHelpper.Properties.Resources.calendario;
            this.btnAddCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCita.Location = new System.Drawing.Point(360, 157);
            this.btnAddCita.Name = "btnAddCita";
            this.btnAddCita.Size = new System.Drawing.Size(128, 35);
            this.btnAddCita.TabIndex = 17;
            this.btnAddCita.Text = "Agendar Cita";
            this.btnAddCita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCita.UseVisualStyleBackColor = false;
            // 
            // frmPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(567, 392);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPadre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPadre";
            this.tabControl1.ResumeLayout(false);
            this.AddCita.ResumeLayout(false);
            this.AddCita.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.TabControl tabControl1;
        protected System.Windows.Forms.DateTimePicker dtpCita;
        protected System.Windows.Forms.TextBox txtTarjeta;
        protected System.Windows.Forms.Button btnAddCita;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label lblEstado;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.TabPage AddCita;
        protected System.Windows.Forms.Button btnCerrar;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.TextBox txtCita;
    }
}