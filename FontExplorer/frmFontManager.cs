using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FontExplorer.Dtos;

namespace FontExplorer
{
  public partial class frmFontManager : Form
  {
    private InstalledFontsDto installedFontsDto;
    private FontDto selectedFontDto;

    public frmFontManager(InstalledFontsDto installedFontsDto)
    {
      InitializeComponent();
      this.installedFontsDto = installedFontsDto;
    }

    public void SetSelectedFont(FontFamily fontFamily)
    {
      this.lblSelectedFont.Font = new Font(fontFamily, this.lblSelectedFont.Font.Size);
      this.lblSelectedFont.Text = fontFamily.Name;
      this.lblAllLetters.Font = new Font(fontFamily, this.lblAllLetters.Font.Size);
      this.selectedFontDto = this.installedFontsDto.Fonts.SingleOrDefault(f => f.Family == fontFamily.Name);
      if (this.selectedFontDto == null)
      {
        this.selectedFontDto = new FontDto()
        {
          Family = fontFamily.Name,
          Tags = new SortedSet<string>(),
        };
        this.installedFontsDto.Fonts.Add(this.selectedFontDto);
      }

      var nonUsedTags = this.installedFontsDto.Tags.Except(this.selectedFontDto.Tags);
      this.clstCurrentTags.Items.AddRange(this.selectedFontDto.Tags.ToArray());
      this.clstExistingTags.Items.AddRange(nonUsedTags.ToArray());

      bool isHiddenFont = selectedFontDto.Tags.Contains(InstalledFontsDto.HiddenFontTag);
      this.chkHide.Checked = isHiddenFont;
      this.SetVisibility(visible: !isHiddenFont);
    }

    private void btnAddTag_Click(object sender, System.EventArgs e)
    {
      this.SuspendLayout();
      if (this.clstExistingTags.CheckedItems.Count > 0)
      {
        var existing = new SortedSet<string>(this.clstExistingTags.Items.OfType<string>());
        var current = new SortedSet<string>(this.clstCurrentTags.Items.OfType<string>());
        foreach (var item in this.clstExistingTags.CheckedItems.OfType<string>())
        {
          existing.Remove(item);
          current.Add(item);
          this.selectedFontDto.Tags.Add(item);
        }
        this.clstExistingTags.Items.Clear();
        this.clstExistingTags.Items.AddRange(existing.ToArray());
        this.clstCurrentTags.Items.Clear();
        this.clstCurrentTags.Items.AddRange(current.ToArray());
        _ = this.installedFontsDto.Save();
      }
      this.ResumeLayout(true);
    }

    private void btnRemoveTag_Click(object sender, System.EventArgs e)
    {
      if (this.clstCurrentTags.CheckedItems.Count > 0)
      {
        this.SuspendLayout();
        var current = new SortedSet<string>(this.clstCurrentTags.Items.OfType<string>());
        var existing = new SortedSet<string>(this.clstExistingTags.Items.OfType<string>());
        foreach (var item in this.clstCurrentTags.CheckedItems.OfType<string>())
        {
          current.Remove(item);
          existing.Add(item);
          this.selectedFontDto.Tags.Remove(item);
        }
        this.clstCurrentTags.Items.Clear();
        this.clstCurrentTags.Items.AddRange(current.ToArray());
        this.clstExistingTags.Items.Clear();
        this.clstExistingTags.Items.AddRange(existing.ToArray());
        _ = this.installedFontsDto.Save();
        this.ResumeLayout(true);
      }
    }

    private void txtNewTag_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        this.SuspendLayout();
        var newTag = this.txtNewTag.Text.Trim();
        this.selectedFontDto.Tags.Add(newTag);
        this.installedFontsDto.Tags.Add(newTag);
        _ = this.installedFontsDto.Save();
        var current = new SortedSet<string>(this.clstCurrentTags.Items.OfType<string>());
        current.Add(newTag);
        this.clstCurrentTags.Items.Clear();
        this.clstCurrentTags.Items.AddRange(current.ToArray());
        this.txtNewTag.Text = string.Empty;
        this.ResumeLayout(true);
      }
    }

    private void chkHide_CheckedChanged(object sender, EventArgs e)
    {
      bool visible = !this.chkHide.Checked;
      this.SetVisibility(visible);
      if (visible)
      {
        this.selectedFontDto.Tags.Remove(InstalledFontsDto.HiddenFontTag);
      }
      else
      {
        this.selectedFontDto.Tags.Add(InstalledFontsDto.HiddenFontTag);
        // Initially it will not exist
        this.installedFontsDto.Tags.Add(InstalledFontsDto.HiddenFontTag);
      }
      _ = this.installedFontsDto.Save();
    }

    private void SetVisibility(bool visible)
    {
      this.lblAddNewTag.Visible = visible;
      this.txtNewTag.Visible = visible;
      this.lblExistingTags.Visible = visible;
      this.clstExistingTags.Visible = visible;
      this.lblCurrentTags.Visible = visible;
      this.clstCurrentTags.Visible = visible;
      this.tlpButtons.Visible = visible;
    }
  }
}
