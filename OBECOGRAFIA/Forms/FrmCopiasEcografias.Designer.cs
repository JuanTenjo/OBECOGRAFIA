
namespace OBECOGRAFIA.Forms
{
    partial class FrmCopiasEcografias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCopiasEcografias));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DateFinal = new System.Windows.Forms.DateTimePicker();
            this.DateInicial = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GridAmbitoHC = new System.Windows.Forms.DataGridView();
            this.AMBITOsel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoInforme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblNivelPermitido = new System.Windows.Forms.Label();
            this.LblNombreUsar = new System.Windows.Forms.Label();
            this.LblCodigoUsaF = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.PicLogoEmpresa = new System.Windows.Forms.PictureBox();
            this.CboServiHC5 = new System.Windows.Forms.ComboBox();
            this.LblServicio = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAmbitoHC)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogoEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.DateFinal);
            this.groupBox1.Controls.Add(this.DateInicial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(317, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // DateFinal
            // 
            this.DateFinal.CustomFormat = "dddd ";
            this.DateFinal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFinal.Location = new System.Drawing.Point(101, 55);
            this.DateFinal.Name = "DateFinal";
            this.DateFinal.Size = new System.Drawing.Size(113, 22);
            this.DateFinal.TabIndex = 4;
            // 
            // DateInicial
            // 
            this.DateInicial.CustomFormat = "dddd ";
            this.DateInicial.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateInicial.Location = new System.Drawing.Point(101, 34);
            this.DateInicial.Name = "DateInicial";
            this.DateInicial.Size = new System.Drawing.Size(113, 22);
            this.DateInicial.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha final:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha inicial:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rango De Fechas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GridAmbitoHC
            // 
            this.GridAmbitoHC.AllowUserToAddRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkCyan;
            this.GridAmbitoHC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridAmbitoHC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridAmbitoHC.BackgroundColor = System.Drawing.Color.White;
            this.GridAmbitoHC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAmbitoHC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AMBITOsel,
            this.TipoInforme});
            this.GridAmbitoHC.Location = new System.Drawing.Point(8, 10);
            this.GridAmbitoHC.MultiSelect = false;
            this.GridAmbitoHC.Name = "GridAmbitoHC";
            this.GridAmbitoHC.ReadOnly = true;
            this.GridAmbitoHC.RowHeadersVisible = false;
            this.GridAmbitoHC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridAmbitoHC.Size = new System.Drawing.Size(303, 164);
            this.GridAmbitoHC.TabIndex = 119;
            this.GridAmbitoHC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridAmbitoHC_CellContentClick);
            // 
            // AMBITOsel
            // 
            this.AMBITOsel.HeaderText = "AMBITOsel";
            this.AMBITOsel.Name = "AMBITOsel";
            this.AMBITOsel.ReadOnly = true;
            this.AMBITOsel.Visible = false;
            // 
            // TipoInforme
            // 
            this.TipoInforme.HeaderText = "TipoI De Informe";
            this.TipoInforme.Name = "TipoInforme";
            this.TipoInforme.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 120;
            this.label4.Text = "Mostrar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.BackColor = System.Drawing.Color.White;
            this.BtnMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMostrar.FlatAppearance.BorderSize = 0;
            this.BtnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrar.Image = global::OBECOGRAFIA.Properties.Resources.mostrar;
            this.BtnMostrar.Location = new System.Drawing.Point(22, 29);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(64, 51);
            this.BtnMostrar.TabIndex = 121;
            this.BtnMostrar.UseVisualStyleBackColor = false;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(92, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 23);
            this.label10.TabIndex = 123;
            this.label10.Text = "Salir";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Image = global::OBECOGRAFIA.Properties.Resources.cerrar40px;
            this.BtnSalir.Location = new System.Drawing.Point(92, 29);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(64, 53);
            this.BtnSalir.TabIndex = 122;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.BtnMostrar);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BtnSalir);
            this.groupBox2.Location = new System.Drawing.Point(8, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 88);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.LblNivelPermitido);
            this.groupBox3.Controls.Add(this.LblNombreUsar);
            this.groupBox3.Controls.Add(this.LblCodigoUsaF);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(323, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 58);
            this.groupBox3.TabIndex = 124;
            this.groupBox3.TabStop = false;
            // 
            // LblNivelPermitido
            // 
            this.LblNivelPermitido.BackColor = System.Drawing.Color.White;
            this.LblNivelPermitido.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNivelPermitido.ForeColor = System.Drawing.Color.Black;
            this.LblNivelPermitido.Location = new System.Drawing.Point(4, 33);
            this.LblNivelPermitido.Name = "LblNivelPermitido";
            this.LblNivelPermitido.Size = new System.Drawing.Size(38, 20);
            this.LblNivelPermitido.TabIndex = 127;
            this.LblNivelPermitido.Text = "NivelPermitido";
            this.LblNivelPermitido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblNivelPermitido.Visible = false;
            // 
            // LblNombreUsar
            // 
            this.LblNombreUsar.BackColor = System.Drawing.Color.White;
            this.LblNombreUsar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreUsar.ForeColor = System.Drawing.Color.Black;
            this.LblNombreUsar.Location = new System.Drawing.Point(7, 30);
            this.LblNombreUsar.Name = "LblNombreUsar";
            this.LblNombreUsar.Size = new System.Drawing.Size(212, 23);
            this.LblNombreUsar.TabIndex = 126;
            this.LblNombreUsar.Text = "NombreUsa";
            this.LblNombreUsar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCodigoUsaF
            // 
            this.LblCodigoUsaF.BackColor = System.Drawing.Color.White;
            this.LblCodigoUsaF.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoUsaF.ForeColor = System.Drawing.Color.Black;
            this.LblCodigoUsaF.Location = new System.Drawing.Point(153, 7);
            this.LblCodigoUsaF.Name = "LblCodigoUsaF";
            this.LblCodigoUsaF.Size = new System.Drawing.Size(63, 23);
            this.LblCodigoUsaF.TabIndex = 125;
            this.LblCodigoUsaF.Text = "codigo";
            this.LblCodigoUsaF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(-3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 23);
            this.label5.TabIndex = 124;
            this.label5.Text = "Codigo ID SIIGHOS No.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Location = new System.Drawing.Point(317, 154);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(219, 33);
            this.groupBox4.TabIndex = 127;
            this.groupBox4.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(114, 10);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Cerradas";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(37, 10);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Activas";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // PicLogoEmpresa
            // 
            this.PicLogoEmpresa.BackColor = System.Drawing.Color.White;
            this.PicLogoEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicLogoEmpresa.Location = new System.Drawing.Point(189, 180);
            this.PicLogoEmpresa.Name = "PicLogoEmpresa";
            this.PicLogoEmpresa.Size = new System.Drawing.Size(125, 88);
            this.PicLogoEmpresa.TabIndex = 128;
            this.PicLogoEmpresa.TabStop = false;
            // 
            // CboServiHC5
            // 
            this.CboServiHC5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CboServiHC5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboServiHC5.FormattingEnabled = true;
            this.CboServiHC5.Location = new System.Drawing.Point(317, 129);
            this.CboServiHC5.Name = "CboServiHC5";
            this.CboServiHC5.Size = new System.Drawing.Size(219, 21);
            this.CboServiHC5.TabIndex = 129;
            // 
            // LblServicio
            // 
            this.LblServicio.BackColor = System.Drawing.Color.LightSeaGreen;
            this.LblServicio.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServicio.ForeColor = System.Drawing.Color.White;
            this.LblServicio.Location = new System.Drawing.Point(317, 108);
            this.LblServicio.Name = "LblServicio";
            this.LblServicio.Size = new System.Drawing.Size(219, 21);
            this.LblServicio.TabIndex = 5;
            this.LblServicio.Text = "Servicio";
            this.LblServicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCopiasEcografias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(542, 280);
            this.ControlBox = false;
            this.Controls.Add(this.LblServicio);
            this.Controls.Add(this.CboServiHC5);
            this.Controls.Add(this.PicLogoEmpresa);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GridAmbitoHC);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCopiasEcografias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTES DE ATENCIONES REALIZADAS";
            this.Load += new System.EventHandler(this.FrmCopiasEcografias_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridAmbitoHC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogoEmpresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DateFinal;
        private System.Windows.Forms.DateTimePicker DateInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridAmbitoHC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblNombreUsar;
        private System.Windows.Forms.Label LblCodigoUsaF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox PicLogoEmpresa;
        private System.Windows.Forms.Label LblNivelPermitido;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMBITOsel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoInforme;
        private System.Windows.Forms.ComboBox CboServiHC5;
        private System.Windows.Forms.Label LblServicio;
    }
}