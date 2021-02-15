
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
      this.clstCurrentTags = new System.Windows.Forms.CheckedListBox();
      this.lblCurrentTags = new System.Windows.Forms.Label();
      this.lblExistingTags = new System.Windows.Forms.Label();
      this.clstExistingTags = new System.Windows.Forms.CheckedListBox();
      this.btnAddTag = new System.Windows.Forms.Button();
      this.btnRemoveTag = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblSelectedFont
      // 
      this.lblSelectedFont.Dock = System.Windows.Forms.DockStyle.Top;
      this.lblSelectedFont.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblSelectedFont.Location = new System.Drawing.Point(0, 0);
      this.lblSelectedFont.Name = "lblSelectedFont";
      this.lblSelectedFont.Size = new System.Drawing.Size(704, 50);
      this.lblSelectedFont.TabIndex = 0;
      this.lblSelectedFont.Text = "lblSelectedFont";
      this.lblSelectedFont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // clstCurrentTags
      // 
      this.clstCurrentTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.clstCurrentTags.FormattingEnabled = true;
      this.clstCurrentTags.Location = new System.Drawing.Point(468, 124);
      this.clstCurrentTags.Name = "clstCurrentTags";
      this.clstCurrentTags.Size = new System.Drawing.Size(178, 220);
      this.clstCurrentTags.TabIndex = 1;
      // 
      // lblCurrentTags
      // 
      this.lblCurrentTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblCurrentTags.Location = new System.Drawing.Point(469, 106);
      this.lblCurrentTags.Name = "lblCurrentTags";
      this.lblCurrentTags.Size = new System.Drawing.Size(178, 15);
      this.lblCurrentTags.TabIndex = 2;
      this.lblCurrentTags.Text = "Current Tags";
      // 
      // lblExistingTags
      // 
      this.lblExistingTags.Location = new System.Drawing.Point(53, 106);
      this.lblExistingTags.Name = "lblExistingTags";
      this.lblExistingTags.Size = new System.Drawing.Size(178, 15);
      this.lblExistingTags.TabIndex = 4;
      this.lblExistingTags.Text = "Existing Tags";
      // 
      // clstExistingTags
      // 
      this.clstExistingTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.clstExistingTags.FormattingEnabled = true;
      this.clstExistingTags.Location = new System.Drawing.Point(53, 124);
      this.clstExistingTags.Name = "clstExistingTags";
      this.clstExistingTags.Size = new System.Drawing.Size(178, 220);
      this.clstExistingTags.TabIndex = 3;
      // 
      // btnAddTag
      // 
      this.btnAddTag.Location = new System.Drawing.Point(312, 146);
      this.btnAddTag.Name = "btnAddTag";
      this.btnAddTag.Size = new System.Drawing.Size(75, 37);
      this.btnAddTag.TabIndex = 5;
      this.btnAddTag.Text = "&Add >";
      this.btnAddTag.UseVisualStyleBackColor = true;
      // 
      // btnRemoveTag
      // 
      this.btnRemoveTag.Location = new System.Drawing.Point(312, 206);
      this.btnRemoveTag.Name = "btnRemoveTag";
      this.btnRemoveTag.Size = new System.Drawing.Size(75, 37);
      this.btnRemoveTag.TabIndex = 6;
      this.btnRemoveTag.Text = "< &Remove";
      this.btnRemoveTag.UseVisualStyleBackColor = true;
      // 
      // frmFontManager
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(704, 411);
      this.Controls.Add(this.btnRemoveTag);
      this.Controls.Add(this.btnAddTag);
      this.Controls.Add(this.lblExistingTags);
      this.Controls.Add(this.clstExistingTags);
      this.Controls.Add(this.lblCurrentTags);
      this.Controls.Add(this.clstCurrentTags);
      this.Controls.Add(this.lblSelectedFont);
      this.MinimumSize = new System.Drawing.Size(720, 450);
      this.Name = "frmFontManager";
      this.Text = "frmFontManager";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblSelectedFont;
    private System.Windows.Forms.CheckedListBox clstCurrentTags;
    private System.Windows.Forms.Label lblCurrentTags;
    private System.Windows.Forms.Label lblExistingTags;
    private System.Windows.Forms.CheckedListBox clstExistingTags;
    private System.Windows.Forms.Button btnAddTag;
    private System.Windows.Forms.Button btnRemoveTag;
  }
}