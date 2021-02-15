
namespace FontExplorer
{
  partial class frmFontManager
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
      this.lblSelectedFont = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblSelectedFont
      // 
      this.lblSelectedFont.Dock = System.Windows.Forms.DockStyle.Top;
      this.lblSelectedFont.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblSelectedFont.Location = new System.Drawing.Point(0, 0);
      this.lblSelectedFont.Name = "lblSelectedFont";
      this.lblSelectedFont.Size = new System.Drawing.Size(764, 50);
      this.lblSelectedFont.TabIndex = 0;
      this.lblSelectedFont.Text = "lblSelectedFont";
      this.lblSelectedFont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // frmFontManager
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(764, 411);
      this.Controls.Add(this.lblSelectedFont);
      this.Name = "frmFontManager";
      this.Text = "frmFontManager";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblSelectedFont;
  }
}