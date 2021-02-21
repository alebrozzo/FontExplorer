
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFontManager));
      this.lblSelectedFont = new System.Windows.Forms.Label();
      this.clstCurrentTags = new System.Windows.Forms.CheckedListBox();
      this.lblCurrentTags = new System.Windows.Forms.Label();
      this.lblExistingTags = new System.Windows.Forms.Label();
      this.clstExistingTags = new System.Windows.Forms.CheckedListBox();
      this.btnAddTag = new System.Windows.Forms.Button();
      this.tlpTags = new System.Windows.Forms.TableLayoutPanel();
      this.flpNewTag = new System.Windows.Forms.FlowLayoutPanel();
      this.lblAddNewTag = new System.Windows.Forms.Label();
      this.txtNewTag = new System.Windows.Forms.TextBox();
      this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
      this.btnRemoveTag = new System.Windows.Forms.Button();
      this.lblAllLetters = new System.Windows.Forms.Label();
      this.pnlHeader = new System.Windows.Forms.Panel();
      this.chkHide = new System.Windows.Forms.CheckBox();
      this.tlpTags.SuspendLayout();
      this.flpNewTag.SuspendLayout();
      this.tlpButtons.SuspendLayout();
      this.pnlHeader.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblSelectedFont
      // 
      this.lblSelectedFont.Dock = System.Windows.Forms.DockStyle.Top;
      this.lblSelectedFont.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblSelectedFont.Location = new System.Drawing.Point(0, 0);
      this.lblSelectedFont.Name = "lblSelectedFont";
      this.lblSelectedFont.Size = new System.Drawing.Size(904, 60);
      this.lblSelectedFont.TabIndex = 0;
      this.lblSelectedFont.Text = "lblSelectedFont";
      this.lblSelectedFont.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // clstCurrentTags
      // 
      this.clstCurrentTags.CheckOnClick = true;
      this.clstCurrentTags.Dock = System.Windows.Forms.DockStyle.Fill;
      this.clstCurrentTags.FormattingEnabled = true;
      this.clstCurrentTags.Location = new System.Drawing.Point(499, 68);
      this.clstCurrentTags.Name = "clstCurrentTags";
      this.clstCurrentTags.Size = new System.Drawing.Size(402, 464);
      this.clstCurrentTags.TabIndex = 1;
      // 
      // lblCurrentTags
      // 
      this.lblCurrentTags.Location = new System.Drawing.Point(499, 50);
      this.lblCurrentTags.Name = "lblCurrentTags";
      this.lblCurrentTags.Size = new System.Drawing.Size(178, 15);
      this.lblCurrentTags.TabIndex = 2;
      this.lblCurrentTags.Text = "Current Tags";
      // 
      // lblExistingTags
      // 
      this.lblExistingTags.Location = new System.Drawing.Point(3, 50);
      this.lblExistingTags.Name = "lblExistingTags";
      this.lblExistingTags.Size = new System.Drawing.Size(178, 15);
      this.lblExistingTags.TabIndex = 4;
      this.lblExistingTags.Text = "Existing Tags";
      // 
      // clstExistingTags
      // 
      this.clstExistingTags.CheckOnClick = true;
      this.clstExistingTags.Dock = System.Windows.Forms.DockStyle.Fill;
      this.clstExistingTags.FormattingEnabled = true;
      this.clstExistingTags.Location = new System.Drawing.Point(3, 68);
      this.clstExistingTags.Name = "clstExistingTags";
      this.clstExistingTags.Size = new System.Drawing.Size(400, 464);
      this.clstExistingTags.TabIndex = 3;
      // 
      // btnAddTag
      // 
      this.btnAddTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAddTag.Location = new System.Drawing.Point(3, 122);
      this.btnAddTag.Name = "btnAddTag";
      this.btnAddTag.Size = new System.Drawing.Size(78, 37);
      this.btnAddTag.TabIndex = 5;
      this.btnAddTag.Text = "&Add >";
      this.btnAddTag.UseVisualStyleBackColor = true;
      this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
      // 
      // tlpTags
      // 
      this.tlpTags.ColumnCount = 3;
      this.tlpTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
      this.tlpTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.tlpTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
      this.tlpTags.Controls.Add(this.flpNewTag, 2, 0);
      this.tlpTags.Controls.Add(this.clstExistingTags, 0, 2);
      this.tlpTags.Controls.Add(this.clstCurrentTags, 2, 2);
      this.tlpTags.Controls.Add(this.tlpButtons, 1, 2);
      this.tlpTags.Controls.Add(this.lblExistingTags, 0, 1);
      this.tlpTags.Controls.Add(this.lblCurrentTags, 2, 1);
      this.tlpTags.Controls.Add(this.chkHide, 0, 0);
      this.tlpTags.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpTags.Location = new System.Drawing.Point(0, 95);
      this.tlpTags.Name = "tlpTags";
      this.tlpTags.RowCount = 4;
      this.tlpTags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tlpTags.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tlpTags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlpTags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpTags.Size = new System.Drawing.Size(904, 555);
      this.tlpTags.TabIndex = 7;
      // 
      // flpNewTag
      // 
      this.flpNewTag.Controls.Add(this.lblAddNewTag);
      this.flpNewTag.Controls.Add(this.txtNewTag);
      this.flpNewTag.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flpNewTag.Location = new System.Drawing.Point(499, 3);
      this.flpNewTag.Name = "flpNewTag";
      this.flpNewTag.Size = new System.Drawing.Size(402, 44);
      this.flpNewTag.TabIndex = 9;
      // 
      // lblAddNewTag
      // 
      this.lblAddNewTag.Location = new System.Drawing.Point(3, 0);
      this.lblAddNewTag.Name = "lblAddNewTag";
      this.lblAddNewTag.Size = new System.Drawing.Size(79, 23);
      this.lblAddNewTag.TabIndex = 10;
      this.lblAddNewTag.Text = "Add new tag:";
      this.lblAddNewTag.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
      // 
      // txtNewTag
      // 
      this.txtNewTag.Location = new System.Drawing.Point(88, 3);
      this.txtNewTag.Name = "txtNewTag";
      this.txtNewTag.PlaceholderText = "Enter to add a new tag";
      this.txtNewTag.Size = new System.Drawing.Size(145, 23);
      this.txtNewTag.TabIndex = 9;
      this.txtNewTag.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNewTag_KeyUp);
      // 
      // tlpButtons
      // 
      this.tlpButtons.ColumnCount = 1;
      this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlpButtons.Controls.Add(this.btnAddTag, 0, 1);
      this.tlpButtons.Controls.Add(this.btnRemoveTag, 0, 2);
      this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpButtons.Location = new System.Drawing.Point(409, 68);
      this.tlpButtons.Name = "tlpButtons";
      this.tlpButtons.RowCount = 4;
      this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tlpButtons.Size = new System.Drawing.Size(84, 464);
      this.tlpButtons.TabIndex = 8;
      // 
      // btnRemoveTag
      // 
      this.btnRemoveTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.btnRemoveTag.Location = new System.Drawing.Point(3, 304);
      this.btnRemoveTag.Name = "btnRemoveTag";
      this.btnRemoveTag.Size = new System.Drawing.Size(78, 37);
      this.btnRemoveTag.TabIndex = 7;
      this.btnRemoveTag.Text = "< &Remove";
      this.btnRemoveTag.UseVisualStyleBackColor = true;
      this.btnRemoveTag.Click += new System.EventHandler(this.btnRemoveTag_Click);
      // 
      // lblAllLetters
      // 
      this.lblAllLetters.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.lblAllLetters.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblAllLetters.Location = new System.Drawing.Point(0, 45);
      this.lblAllLetters.Name = "lblAllLetters";
      this.lblAllLetters.Size = new System.Drawing.Size(904, 50);
      this.lblAllLetters.TabIndex = 8;
      this.lblAllLetters.Text = "The quick brown fox jumps over the lazy dog";
      this.lblAllLetters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pnlHeader
      // 
      this.pnlHeader.Controls.Add(this.lblAllLetters);
      this.pnlHeader.Controls.Add(this.lblSelectedFont);
      this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlHeader.Location = new System.Drawing.Point(0, 0);
      this.pnlHeader.Name = "pnlHeader";
      this.pnlHeader.Size = new System.Drawing.Size(904, 95);
      this.pnlHeader.TabIndex = 9;
      // 
      // chkHide
      // 
      this.chkHide.AutoSize = true;
      this.chkHide.Location = new System.Drawing.Point(3, 3);
      this.chkHide.Name = "chkHide";
      this.chkHide.Size = new System.Drawing.Size(98, 19);
      this.chkHide.TabIndex = 10;
      this.chkHide.Text = "&Hide this font";
      this.chkHide.UseVisualStyleBackColor = true;
      this.chkHide.CheckedChanged += new System.EventHandler(this.chkHide_CheckedChanged);
      // 
      // frmFontManager
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(904, 650);
      this.Controls.Add(this.tlpTags);
      this.Controls.Add(this.pnlHeader);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimumSize = new System.Drawing.Size(920, 450);
      this.Name = "frmFontManager";
      this.Text = "Font Manager";
      this.tlpTags.ResumeLayout(false);
      this.tlpTags.PerformLayout();
      this.flpNewTag.ResumeLayout(false);
      this.flpNewTag.PerformLayout();
      this.tlpButtons.ResumeLayout(false);
      this.pnlHeader.ResumeLayout(false);
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
    private System.Windows.Forms.Label lblAllLetters;
    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.TextBox txtNewTag;
    private System.Windows.Forms.FlowLayoutPanel flpNewTag;
    private System.Windows.Forms.Label lblAddNewTag;
    private System.Windows.Forms.CheckBox chkHide;
  }
}
