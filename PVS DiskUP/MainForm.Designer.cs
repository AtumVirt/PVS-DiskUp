namespace PVS_DiskUP
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1 = new System.Windows.Forms.Panel();
      this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
      this.propertyGrid2 = new System.Windows.Forms.PropertyGrid();
      this.menuStrip1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1003, 24);
      this.menuStrip1.TabIndex = 3;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
      this.openToolStripMenuItem.Text = "Open";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.panel1.Controls.Add(this.propertyGrid1);
      this.panel1.Controls.Add(this.propertyGrid2);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 24);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1003, 637);
      this.panel1.TabIndex = 5;
      // 
      // propertyGrid1
      // 
      this.propertyGrid1.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
      this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Left;
      this.propertyGrid1.LineColor = System.Drawing.SystemColors.ControlDark;
      this.propertyGrid1.Location = new System.Drawing.Point(500, 0);
      this.propertyGrid1.Margin = new System.Windows.Forms.Padding(2);
      this.propertyGrid1.MinimumSize = new System.Drawing.Size(354, 532);
      this.propertyGrid1.Name = "propertyGrid1";
      this.propertyGrid1.Size = new System.Drawing.Size(500, 637);
      this.propertyGrid1.TabIndex = 5;
      // 
      // propertyGrid2
      // 
      this.propertyGrid2.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
      this.propertyGrid2.Dock = System.Windows.Forms.DockStyle.Left;
      this.propertyGrid2.LineColor = System.Drawing.SystemColors.ControlDark;
      this.propertyGrid2.Location = new System.Drawing.Point(0, 0);
      this.propertyGrid2.Margin = new System.Windows.Forms.Padding(2);
      this.propertyGrid2.MinimumSize = new System.Drawing.Size(354, 532);
      this.propertyGrid2.Name = "propertyGrid2";
      this.propertyGrid2.Size = new System.Drawing.Size(500, 637);
      this.propertyGrid2.TabIndex = 4;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(1003, 661);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.MinimumSize = new System.Drawing.Size(732, 600);
      this.Name = "MainForm";
      this.Text = "PVS DiskUP";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.PropertyGrid propertyGrid1;
    private System.Windows.Forms.PropertyGrid propertyGrid2;
  }
}

