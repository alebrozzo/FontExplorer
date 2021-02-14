
namespace FontExplorer
{
  partial class frmExplorer
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExplorer));
      this.txtUserText = new System.Windows.Forms.TextBox();
      this.flowLabelContainer = new System.Windows.Forms.FlowLayoutPanel();
      this.lblSample = new System.Windows.Forms.Label();
      this.ttFontName = new System.Windows.Forms.ToolTip(this.components);
      this.flowLabelContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtUserText
      // 
      this.txtUserText.AcceptsReturn = true;
      this.txtUserText.AllowDrop = true;
      resources.ApplyResources(this.txtUserText, "txtUserText");
      this.txtUserText.Name = "txtUserText";
      this.txtUserText.TextChanged += new System.EventHandler(this.txtUserText_TextChanged);
      // 
      // flowLabelContainer
      // 
      resources.ApplyResources(this.flowLabelContainer, "flowLabelContainer");
      this.flowLabelContainer.Controls.Add(this.lblSample);
      this.flowLabelContainer.Name = "flowLabelContainer";
      // 
      // lblSample
      // 
      this.lblSample.AutoEllipsis = true;
      resources.ApplyResources(this.lblSample, "lblSample");
      this.lblSample.Name = "lblSample";
      this.ttFontName.SetToolTip(this.lblSample, resources.GetString("lblSample.ToolTip"));
      this.lblSample.UseMnemonic = false;
      // 
      // frmExplorer
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.flowLabelContainer);
      this.Controls.Add(this.txtUserText);
      this.Name = "frmExplorer";
      this.Tag = "";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmExplorer_Load);
      this.flowLabelContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtUserText;
    private System.Windows.Forms.FlowLayoutPanel flowLabelContainer;
    private System.Windows.Forms.Label lblSample;
    private System.Windows.Forms.ToolTip ttFontName;
  }
}

