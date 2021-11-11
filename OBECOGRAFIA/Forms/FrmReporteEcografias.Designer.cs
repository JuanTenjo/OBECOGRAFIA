
namespace OBECOGRAFIA.Forms
{
    partial class FrmReporteEcografias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteEcografias));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DateFinal = new System.Windows.Forms.DateTimePicker();
            this.DateInicial = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RbTodos = new System.Windows.Forms.RadioButton();
            this.RbAnulados = new System.Windows.Forms.RadioButton();
            this.RbValidos = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RbTOdosEC = new System.Windows.Forms.RadioButton();
            this.s = new System.Windows.Forms.RadioButton();
            this.RbAbierto = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LblTolTriage = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.GridTriageSelecionados = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnCopias = new System.Windows.Forms.Button();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTriageSelecionados)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // DateFinal
            // 
            this.DateFinal.CustomFormat = "dddd ";
            this.DateFinal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFinal.Location = new System.Drawing.Point(119, 60);
            this.DateFinal.Name = "DateFinal";
            this.DateFinal.Size = new System.Drawing.Size(107, 22);
            this.DateFinal.TabIndex = 4;
            // 
            // DateInicial
            // 
            this.DateInicial.CustomFormat = "dddd ";
            this.DateInicial.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateInicial.Location = new System.Drawing.Point(119, 38);
            this.DateInicial.Name = "DateInicial";
            this.DateInicial.Size = new System.Drawing.Size(107, 22);
            this.DateInicial.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 60);
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
            this.label2.Location = new System.Drawing.Point(22, 37);
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
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Periodo a reportar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.RbTodos);
            this.groupBox3.Controls.Add(this.RbAnulados);
            this.groupBox3.Controls.Add(this.RbValidos);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(269, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 108);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // RbTodos
            // 
            this.RbTodos.AutoSize = true;
            this.RbTodos.Location = new System.Drawing.Point(16, 72);
            this.RbTodos.Name = "RbTodos";
            this.RbTodos.Size = new System.Drawing.Size(55, 17);
            this.RbTodos.TabIndex = 8;
            this.RbTodos.TabStop = true;
            this.RbTodos.Text = "&Todos";
            this.RbTodos.UseVisualStyleBackColor = true;
            this.RbTodos.CheckedChanged += new System.EventHandler(this.RbTodos_CheckedChanged);
            // 
            // RbAnulados
            // 
            this.RbAnulados.AutoSize = true;
            this.RbAnulados.Location = new System.Drawing.Point(16, 49);
            this.RbAnulados.Name = "RbAnulados";
            this.RbAnulados.Size = new System.Drawing.Size(69, 17);
            this.RbAnulados.TabIndex = 7;
            this.RbAnulados.TabStop = true;
            this.RbAnulados.Text = "An&ulados";
            this.RbAnulados.UseVisualStyleBackColor = true;
            this.RbAnulados.CheckedChanged += new System.EventHandler(this.RbAnulados_CheckedChanged);
            // 
            // RbValidos
            // 
            this.RbValidos.AutoSize = true;
            this.RbValidos.Location = new System.Drawing.Point(16, 26);
            this.RbValidos.Name = "RbValidos";
            this.RbValidos.Size = new System.Drawing.Size(59, 17);
            this.RbValidos.TabIndex = 6;
            this.RbValidos.TabStop = true;
            this.RbValidos.Text = "&Válidos";
            this.RbValidos.UseVisualStyleBackColor = true;
            this.RbValidos.CheckedChanged += new System.EventHandler(this.RbValidos_CheckedChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Estado de válidez";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.RbTOdosEC);
            this.groupBox4.Controls.Add(this.s);
            this.groupBox4.Controls.Add(this.RbAbierto);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(453, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(205, 108);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // RbTOdosEC
            // 
            this.RbTOdosEC.AutoSize = true;
            this.RbTOdosEC.Location = new System.Drawing.Point(16, 72);
            this.RbTOdosEC.Name = "RbTOdosEC";
            this.RbTOdosEC.Size = new System.Drawing.Size(55, 17);
            this.RbTOdosEC.TabIndex = 8;
            this.RbTOdosEC.TabStop = true;
            this.RbTOdosEC.Text = "T&odos";
            this.RbTOdosEC.UseVisualStyleBackColor = true;
            this.RbTOdosEC.CheckedChanged += new System.EventHandler(this.RbTOdosEC_CheckedChanged);
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(16, 49);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(67, 17);
            this.s.TabIndex = 7;
            this.s.TabStop = true;
            this.s.Text = "&Cerrados";
            this.s.UseVisualStyleBackColor = true;
            this.s.CheckedChanged += new System.EventHandler(this.s_CheckedChanged);
            // 
            // RbAbierto
            // 
            this.RbAbierto.AutoSize = true;
            this.RbAbierto.Location = new System.Drawing.Point(16, 26);
            this.RbAbierto.Name = "RbAbierto";
            this.RbAbierto.Size = new System.Drawing.Size(58, 17);
            this.RbAbierto.TabIndex = 6;
            this.RbAbierto.TabStop = true;
            this.RbAbierto.Text = "&Abierto";
            this.RbAbierto.UseVisualStyleBackColor = true;
            this.RbAbierto.CheckedChanged += new System.EventHandler(this.RbAbierto_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Estado de las ecografías";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.LblTolTriage);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(456, 126);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(201, 82);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            // 
            // LblTolTriage
            // 
            this.LblTolTriage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LblTolTriage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTolTriage.ForeColor = System.Drawing.Color.Black;
            this.LblTolTriage.Location = new System.Drawing.Point(51, 34);
            this.LblTolTriage.Name = "LblTolTriage";
            this.LblTolTriage.Size = new System.Drawing.Size(96, 23);
            this.LblTolTriage.TabIndex = 3;
            this.LblTolTriage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Seleccionados";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 437);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(646, 23);
            this.progressBar1.TabIndex = 117;
            // 
            // GridTriageSelecionados
            // 
            this.GridTriageSelecionados.AllowUserToAddRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkCyan;
            this.GridTriageSelecionados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridTriageSelecionados.BackgroundColor = System.Drawing.Color.White;
            this.GridTriageSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTriageSelecionados.Location = new System.Drawing.Point(12, 224);
            this.GridTriageSelecionados.MultiSelect = false;
            this.GridTriageSelecionados.Name = "GridTriageSelecionados";
            this.GridTriageSelecionados.ReadOnly = true;
            this.GridTriageSelecionados.RowHeadersVisible = false;
            this.GridTriageSelecionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridTriageSelecionados.Size = new System.Drawing.Size(646, 202);
            this.GridTriageSelecionados.TabIndex = 118;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(80, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mostrar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(150, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 119;
            this.label5.Text = "Exportar";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(223, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 120;
            this.label6.Text = "Copias";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(293, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 23);
            this.label10.TabIndex = 121;
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
            this.BtnSalir.Location = new System.Drawing.Point(293, 155);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(64, 53);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnCopias
            // 
            this.BtnCopias.BackColor = System.Drawing.Color.White;
            this.BtnCopias.FlatAppearance.BorderSize = 0;
            this.BtnCopias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnCopias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCopias.Image = global::OBECOGRAFIA.Properties.Resources.copias;
            this.BtnCopias.Location = new System.Drawing.Point(223, 155);
            this.BtnCopias.Name = "BtnCopias";
            this.BtnCopias.Size = new System.Drawing.Size(64, 53);
            this.BtnCopias.TabIndex = 8;
            this.BtnCopias.UseVisualStyleBackColor = false;
            this.BtnCopias.Click += new System.EventHandler(this.BtnCopias_Click);
            // 
            // BtnExportar
            // 
            this.BtnExportar.BackColor = System.Drawing.Color.White;
            this.BtnExportar.FlatAppearance.BorderSize = 0;
            this.BtnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportar.Image = global::OBECOGRAFIA.Properties.Resources.exportar;
            this.BtnExportar.Location = new System.Drawing.Point(150, 155);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(67, 53);
            this.BtnExportar.TabIndex = 7;
            this.BtnExportar.UseVisualStyleBackColor = false;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.BackColor = System.Drawing.Color.White;
            this.BtnMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMostrar.FlatAppearance.BorderSize = 0;
            this.BtnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrar.Image = global::OBECOGRAFIA.Properties.Resources.mostrar;
            this.BtnMostrar.Location = new System.Drawing.Point(80, 155);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(64, 53);
            this.BtnMostrar.TabIndex = 6;
            this.BtnMostrar.UseVisualStyleBackColor = false;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // FrmReporteEcografias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 472);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GridTriageSelecionados);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnCopias);
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteEcografias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE GENERALES DE LAS ECOGRAFIAS";
            this.Load += new System.EventHandler(this.FrmReporteEcografias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridTriageSelecionados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateFinal;
        private System.Windows.Forms.DateTimePicker DateInicial;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RbTodos;
        private System.Windows.Forms.RadioButton RbAnulados;
        private System.Windows.Forms.RadioButton RbValidos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnExportar;
        private System.Windows.Forms.Button BtnCopias;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton RbTOdosEC;
        private System.Windows.Forms.RadioButton s;
        private System.Windows.Forms.RadioButton RbAbierto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView GridTriageSelecionados;
        private System.Windows.Forms.Label LblTolTriage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
    }
}