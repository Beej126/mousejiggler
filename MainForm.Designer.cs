namespace ArkaneSystems.MouseJiggle
{
  partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.jiggleTimer = new System.Windows.Forms.Timer(this.components);
      this.nifMin = new System.Windows.Forms.NotifyIcon(this.components);
      this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.menuEnable = new System.Windows.Forms.ToolStripMenuItem();
      this.menuZen = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label1 = new System.Windows.Forms.Label();
      this.contextMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // jiggleTimer
      // 
      this.jiggleTimer.Enabled = true;
      this.jiggleTimer.Interval = 1000;
      this.jiggleTimer.Tick += new System.EventHandler(this.jiggleTimer_Tick);
      // 
      // nifMin
      // 
      this.nifMin.ContextMenuStrip = this.contextMenu;
      this.nifMin.Icon = ((System.Drawing.Icon)(resources.GetObject("nifMin.Icon")));
      this.nifMin.Text = "Mouse Jiggler";
      this.nifMin.Visible = true;
      this.nifMin.Click += new System.EventHandler(this.NifMin_Click);
      // 
      // contextMenu
      // 
      this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEnable,
            this.menuZen,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.contextMenu.Name = "contextMenu";
      this.contextMenu.Size = new System.Drawing.Size(110, 92);
      this.contextMenu.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.ContextMenu_Closing);
      // 
      // menuEnable
      // 
      this.menuEnable.Checked = true;
      this.menuEnable.CheckOnClick = true;
      this.menuEnable.CheckState = System.Windows.Forms.CheckState.Checked;
      this.menuEnable.Name = "menuEnable";
      this.menuEnable.Size = new System.Drawing.Size(109, 22);
      this.menuEnable.Text = "Enable";
      this.menuEnable.CheckedChanged += new System.EventHandler(this.menuEnable_CheckedChanged);
      // 
      // menuZen
      // 
      this.menuZen.Checked = true;
      this.menuZen.CheckOnClick = true;
      this.menuZen.CheckState = System.Windows.Forms.CheckState.Checked;
      this.menuZen.Name = "menuZen";
      this.menuZen.Size = new System.Drawing.Size(109, 22);
      this.menuZen.Text = "Zen";
      this.menuZen.CheckedChanged += new System.EventHandler(this.menuZen_CheckedChanged);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
      this.aboutToolStripMenuItem.Text = "About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.cmdAbout_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(207, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "nothing to see here. see the contextMenu.";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(223, 59);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainForm";
      this.Text = "MouseJiggle";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.contextMenu.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Timer jiggleTimer;
    private System.Windows.Forms.NotifyIcon nifMin;
    private System.Windows.Forms.ContextMenuStrip contextMenu;
    private System.Windows.Forms.ToolStripMenuItem menuEnable;
    private System.Windows.Forms.ToolStripMenuItem menuZen;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
  }
}

