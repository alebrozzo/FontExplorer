
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
      this.tlpTags = new System.Windows.Forms.TableLayoutPanel();
      this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
      this.btnRemoveTag = new System.Windows.Forms.Button();
      this.tlpTags.SuspendLayout();
      this.tlpButtons.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblSelectedFont
      // 
      this.lblSelectedFont.Dock = System.Windows.Forms.DockStyle.Top;
      this.lblSelectedFont.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblSelectedFont.Location = new System.Drawing.Point(0, 0);
      this.lblSelectedFont.Name = "lblSelectedFont";
      this.lblSelectedFont.Size = new System.Drawing.Size(904, 50);
      this.lblSelectedFont.TabIndex = 0;
      this.lblSelectedFont.Text = "lblSelectedFont";
      this.lblSelectedFont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // clstCurrentTags
      // 
      this.clstCurrentTags.Dock = System.Windows.Forms.DockStyle.Fill;
      this.clstCurrentTags.FormattingEnabled = true;
      this.clstCurrentTags.Location = new System.Drawing.Point(499, 18);
      this.clstCurrentTags.Name = "clstCurrentTags";
      this.clstCurrentTags.Size = new System.Drawing.Size(402, 381);
      this.clstCurrentTags.TabIndex = 1;
      // 
      // lblCurrentTags
      // 
      this.lblCurrentTags.Location = new System.Drawing.Point(499, 0);
      this.lblCurrentTags.Name = "lblCurrentTags";
      this.lblCurrentTags.Size = new System.Drawing.Size(178, 15);
      this.lblCurrentTags.TabIndex = 2;
      this.lblCurrentTags.Text = "Current Tags";
      // 
      // lblExistingTags
      // 
      this.lblExistingTags.Location = new System.Drawing.Point(3, 0);
      this.lblExistingTags.Name = "lblExistingTags";
      this.lblExistingTags.Size = new System.Drawing.Size(178, 15);
      this.lblExistingTags.TabIndex = 4;
      this.lblExistingTags.Text = "Existing Tags";
      // 
      // clstExistingTags
      // 
      this.clstExistingTags.Dock = System.Windows.Forms.DockStyle.Fill;
      this.clstExistingTags.FormattingEnabled = true;
      this.clstExistingTags.Location = new System.Drawing.Point(3, 18);
      this.clstExistingTags.Name = "clstExistingTags";
      this.clstExistingTags.Size = new System.Drawing.Size(400, 381);
      this.clstExistingTags.TabIndex = 3;
      // 
      // btnAddTag
      // 
      this.btnAddTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAddTag.Location = new System.Drawing.Point(3, 101);
      this.btnAddTag.Name = "btnAddTag";
      this.btnAddTag.Size = new System.Drawing.Size(78, 37);
      this.btnAddTag.TabIndex = 5;
      this.btnAddTag.Text = "&Add >";
      this.btnAddTag.UseVisualStyleBackColor = true;
      // 
      // tlpTags
      // 
      this.tlpTags.ColumnCount = 3;
      this.tlpTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
      this.tlpTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.tlpTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
      this.tlpTags.Controls.Add(this.lblExistingTags, 0, 0);
      this.tlpTags.Controls.Add(this.clstExistingTags, 0, 1);
      this.tlpTags.Controls.Add(this.clstCurrentTags, 2, 1);
      this.tlpTags.Controls.Add(this.tlpButtons, 1, 1);
      this.tlpTags.Controls.Add(this.lblCurrentTags, 2, 0);
      this.tlpTags.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpTags.Location = new System.Drawing.Point(0, 50);
      this.tlpTags.Name = "tlpTags";
      this.tlpTags.RowCount = 3;
      this.tlpTags.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tlpTags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlpTags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tlpTags.Size = new System.Drawing.Size(904, 452);
      this.tlpTags.TabIndex = 7;
      // 
      // tlpButtons
      // 
      this.tlpButtons.ColumnCount = 1;
      this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlpButtons.Controls.Add(this.btnAddTag, 0, 1);
      this.tlpButtons.Controls.Add(this.btnRemoveTag, 0, 2);
      this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpButtons.Location = new System.Drawing.Point(409, 18);
      this.tlpButtons.Name = "tlpButtons";
      this.tlpButtons.RowCount = 4;
      this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tlpButtons.Size = new System.Drawing.Size(84, 381);
      this.tlpButtons.TabIndex = 8;
      // 
      // btnRemoveTag
      // 
      this.btnRemoveTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.btnRemoveTag.Location = new System.Drawing.Point(3, 241);
      this.btnRemoveTag.Name = "btnRemoveTag";
      this.btnRemoveTag.Size = new System.Drawing.Size(78, 37);
      this.btnRemoveTag.TabIndex = 7;
      this.btnRemoveTag.Text = "< &Remove";
      this.btnRemoveTag.UseVisualStyleBackColor = true;
      // 
      // frmFontManager
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(904, 502);
      this.Controls.Add(this.tlpTags);
      this.Controls.Add(this.lblSelectedFont);
      this.MinimumSize = new System.Drawing.Size(720, 450);
      this.Name = "frmFontManager";
      this.Text = "frmFontManager";
      this.tlpTags.ResumeLayout(false);
      this.tlpButtons.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblSelectedFont;
    private System.Windows.Forms.CheckedListBox clstCurrentTags;
    private System.Windows.Forms.Label lblCurrentTags;
    private System.Windows.Forms.Label lblExistingTags;
    private System.Windows.Forms.CheckedListBox clstExistingTags;
    private System.Windows.Forms.Button btnAddTag;
    private System.Windows.Forms.TableLayoutPanel tlpTags;
    private System.Windows.Forms.Button btnRemoveTag;
    private System.Windows.Forms.TableLayoutPanel tlpButtons;
  }
}