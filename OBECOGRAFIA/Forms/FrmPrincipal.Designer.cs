
namespace OBECOGRAFIA.Forms
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atenciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecografiasObtetricasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesEcografiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteEcografíasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCodUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNomUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblNombreEmpresa = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.atenciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // atenciónToolStripMenuItem
            // 
            this.atenciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ecografiasObtetricasToolStripMenuItem,
            this.informesEcografiasToolStripMenuItem,
            this.reporteEcografíasToolStripMenuItem});
            this.atenciónToolStripMenuItem.Name = "atenciónToolStripMenuItem";
            this.atenciónToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.atenciónToolStripMenuItem.Text = "&Ecografías";
            // 
            // ecografiasObtetricasToolStripMenuItem
            // 
            this.ecografiasObtetricasToolStripMenuItem.Name = "ecografiasObtetricasToolStripMenuItem";
            this.ecografiasObtetricasToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ecografiasObtetricasToolStripMenuItem.Text = "Registro De Ecografías";
            this.ecografiasObtetricasToolStripMenuItem.Click += new System.EventHandler(this.ecografiasObtetricasToolStripMenuItem_Click);
            // 
            // informesEcografiasToolStripMenuItem
            // 
            this.informesEcografiasToolStripMenuItem.Name = "informesEcografiasToolStripMenuItem";
            this.informesEcografiasToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.informesEcografiasToolStripMenuItem.Text = "Copias Ecografias";
            this.informesEcografiasToolStripMenuItem.Click += new System.EventHandler(this.informesEcografiasToolStripMenuItem_Click);
            // 
            // reporteEcografíasToolStripMenuItem
            // 
            this.reporteEcografíasToolStripMenuItem.Name = "reporteEcografíasToolStripMenuItem";
            this.reporteEcografíasToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.reporteEcografíasToolStripMenuItem.Text = "Reporte Ecografías";
            this.reporteEcografíasToolStripMenuItem.Click += new System.EventHandler(this.reporteEcografíasToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFecha,
            this.lblCodUsuario,
            this.lblNomUsuario});
            this.toolStrip1.Location = new System.Drawing.Point(0, 425);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.Color.White;
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(118, 20);
            this.lblFecha.Text = "toolStripStatusLabel1";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCodUsuario
            // 
            this.lblCodUsuario.BackColor = System.Drawing.Color.White;
            this.lblCodUsuario.Name = "lblCodUsuario";
            this.lblCodUsuario.Size = new System.Drawing.Size(118, 20);
            this.lblCodUsuario.Text = "toolStripStatusLabel1";
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.BackColor = System.Drawing.Color.White;
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(118, 20);
            this.lblNomUsuario.Text = "toolStripStatusLabel2";
            // 
            // LblNombreEmpresa
            // 
            this.LblNombreEmpresa.AutoSize = true;
            this.LblNombreEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreEmpresa.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblNombreEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblNombreEmpresa.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreEmpresa.ForeColor = System.Drawing.Color.White;
            this.LblNombreEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblNombreEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblNombreEmpresa.Location = new System.Drawing.Point(705, 24);
            this.LblNombreEmpresa.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.LblNombreEmpresa.Name = "LblNombreEmpresa";
            this.LblNombreEmpresa.Padding = new System.Windows.Forms.Padding(0, 30, 40, 0);
            this.LblNombreEmpresa.Size = new System.Drawing.Size(95, 48);
            this.LblNombreEmpresa.TabIndex = 5;
            this.LblNombreEmpresa.Text = "label1";
            this.LblNombreEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OBECOGRAFIA.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblNombreEmpresa);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OBECOGRAFIAS 1.0.3 (10/12/2021) *** SIIGHOS PLUS ***";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
        private System.Windows.Forms.ToolStripStatusLabel lblCodUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblNomUsuario;
        private System.Windows.Forms.ToolStripMenuItem atenciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecografiasObtetricasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesEcografiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteEcografíasToolStripMenuItem;
        private System.Windows.Forms.Label LblNombreEmpresa;
    }
}