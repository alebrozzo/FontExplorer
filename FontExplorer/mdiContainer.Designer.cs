
namespace FontExplorer
{
  partial class mdiContainer
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiContainer));
      this.ssStatusBar = new System.Windows.Forms.StatusStrip();
      this.tsiFontCount = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      this.mnsMainMenu = new System.Windows.Forms.MenuStrip();
      this.mniChooseFont = new System.Windows.Forms.ToolStripMenuItem();
      this.mniManageFonts = new System.Windows.Forms.ToolStripMenuItem();
      this.ssStatusBar.SuspendLayout();
      this.mnsMainMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // ssStatusBar
      // 
      this.ssStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiFontCount});
      resources.ApplyResources(this.ssStatusBar, "ssStatusBar");
      this.ssStatusBar.Name = "ssStatusBar";
      // 
      // tsiFontCount
      // 
      this.tsiFontCount.Name = "tsiFontCount";
      resources.ApplyResources(this.tsiFontCount, "tsiFontCount");
      // 
      // mnsMainMenu
      // 
      this.mnsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniChooseFont,
            this.mniManageFonts});
      resources.ApplyResources(this.mnsMainMenu, "mnsMainMenu");
      this.mnsMainMenu.Name = "mnsMainMenu";
      this.mnsMainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnsMainMenu_ItemClicked);
      // 
      // mniChooseFont
      // 
      this.mniChooseFont.Name = "mniChooseFont";
      resources.ApplyResources(this.mniChooseFont, "mniChooseFont");
      this.mniChooseFont.Tag = "frmExplorer";
      // 
      // mniManageFonts
      // 
      this.mniManageFonts.Name = "mniManageFonts";
      resources.ApplyResources(this.mniManageFonts, "mniManageFonts");
      // 
      // mdiContainer
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.mnsMainMenu);
      this.Controls.Add(this.ssStatusBar);
      this.IsMdiContainer = true;
      this.Name = "mdiContainer";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.ssStatusBar.ResumeLayout(false);
      this.ssStatusBar.PerformLayout();
      this.mnsMainMenu.ResumeLayout(false);
      this.mnsMainMenu.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }
    #endregion
    private System.Windows.Forms.ToolStripStatusLabel tsiFontCount;
    private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.MenuStrip mnsMainMenu;
    private System.Windows.Forms.ToolStripMenuItem mniChooseFont;
    private System.Windows.Forms.ToolStripMenuItem mniManageFonts;
    internal System.Windows.Forms.StatusStrip ssStatusBar;
  }
}



