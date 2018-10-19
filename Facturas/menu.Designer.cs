namespace Facturas
{
    partial class menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprobanteDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generadorEnMasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.generadorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // generadorToolStripMenuItem
            // 
            this.generadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprobanteDePagoToolStripMenuItem});
            this.generadorToolStripMenuItem.Name = "generadorToolStripMenuItem";
            this.generadorToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.generadorToolStripMenuItem.Text = "Generador";
            // 
            // comprobanteDePagoToolStripMenuItem
            // 
            this.comprobanteDePagoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizadorToolStripMenuItem,
            this.generadorEnMasaToolStripMenuItem});
            this.comprobanteDePagoToolStripMenuItem.Name = "comprobanteDePagoToolStripMenuItem";
            this.comprobanteDePagoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.comprobanteDePagoToolStripMenuItem.Text = "Comprobante de pago";
            // 
            // visualizadorToolStripMenuItem
            // 
            this.visualizadorToolStripMenuItem.Name = "visualizadorToolStripMenuItem";
            this.visualizadorToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.visualizadorToolStripMenuItem.Text = "Generador visualizador";
            this.visualizadorToolStripMenuItem.Click += new System.EventHandler(this.visualizadorToolStripMenuItem_Click);
            // 
            // generadorEnMasaToolStripMenuItem
            // 
            this.generadorEnMasaToolStripMenuItem.Name = "generadorEnMasaToolStripMenuItem";
            this.generadorEnMasaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.generadorEnMasaToolStripMenuItem.Text = "Generador en masa";
            this.generadorEnMasaToolStripMenuItem.Click += new System.EventHandler(this.generadorEnMasaToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 404);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprobanteDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generadorEnMasaToolStripMenuItem;
    }
}