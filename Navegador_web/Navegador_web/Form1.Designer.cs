
namespace Navegador_web
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnatras = new System.Windows.Forms.ToolStripButton();
            this.btnadelante = new System.Windows.Forms.ToolStripButton();
            this.btnrecargar = new System.Windows.Forms.ToolStripButton();
            this.btncancelar = new System.Windows.Forms.ToolStripButton();
            this.btnhome = new System.Windows.Forms.ToolStripButton();
            this.txtURL = new System.Windows.Forms.ToolStripTextBox();
            this.btnbuscar = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnatras,
            this.btnadelante,
            this.btnrecargar,
            this.btncancelar,
            this.btnhome,
            this.txtURL,
            this.btnbuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(898, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnatras
            // 
            this.btnatras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnatras.Image = ((System.Drawing.Image)(resources.GetObject("btnatras.Image")));
            this.btnatras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(23, 22);
            this.btnatras.Text = "Atrás";
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // btnadelante
            // 
            this.btnadelante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnadelante.Image = ((System.Drawing.Image)(resources.GetObject("btnadelante.Image")));
            this.btnadelante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnadelante.Name = "btnadelante";
            this.btnadelante.Size = new System.Drawing.Size(23, 22);
            this.btnadelante.Text = "Delante";
            this.btnadelante.Click += new System.EventHandler(this.btnadelante_Click);
            // 
            // btnrecargar
            // 
            this.btnrecargar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnrecargar.Image = ((System.Drawing.Image)(resources.GetObject("btnrecargar.Image")));
            this.btnrecargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnrecargar.Name = "btnrecargar";
            this.btnrecargar.Size = new System.Drawing.Size(23, 22);
            this.btnrecargar.Text = "Refrescar";
            this.btnrecargar.Click += new System.EventHandler(this.btnrecargar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(23, 22);
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnhome
            // 
            this.btnhome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
            this.btnhome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(23, 22);
            this.btnhome.Text = "Home";
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // txtURL
            // 
            this.txtURL.BackColor = System.Drawing.Color.Silver;
            this.txtURL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(650, 25);
            // 
            // btnbuscar
            // 
            this.btnbuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(23, 22);
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(898, 425);
            this.webBrowser1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "JM Browser";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnatras;
        private System.Windows.Forms.ToolStripButton btnadelante;
        private System.Windows.Forms.ToolStripButton btnrecargar;
        private System.Windows.Forms.ToolStripButton btncancelar;
        private System.Windows.Forms.ToolStripButton btnhome;
        private System.Windows.Forms.ToolStripTextBox txtURL;
        private System.Windows.Forms.ToolStripButton btnbuscar;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

