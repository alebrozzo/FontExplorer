using FontExplorer.Dtos;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FontExplorer
{
  public partial class frmFontManager : Form
  {
    private FontFamily fontFamily;
    private InstalledFontsDto installedFontsDto;
    private FontDto selectedFontDto;

    public frmFontManager(InstalledFontsDto installedFontsDto)
    {
      InitializeComponent();
      this.installedFontsDto = installedFontsDto;
    }

    public void SetSelectedFont(FontFamily fontFamily)
    {
      this.fontFamily = fontFamily;
      this.lblSelectedFont.Font = new Font(fontFamily, this.lblSelectedFont.Font.Size);
      this.lblSelectedFont.Text = fontFamily.Name;
      this.lblAllLetters.Font = new Font(fontFamily, this.lblAllLetters.Font.Size);
      this.selectedFontDto = this.installedFontsDto.Fonts.SingleOrDefault(f => f.Family == fontFamily.Name);
      if (this.selectedFontDto == null)
      {
        this.selectedFontDto = new FontDto()
        {
          Family = fontFamily.Name,
          Tags = new List<string>(),
        };
        this.installedFontsDto.Fonts.Add(this.selectedFontDto);
      }

      var nonUsedTags = this.installedFontsDto.Tags.Except(this.selectedFontDto.Tags);
      this.clstCurrentTags.Items.AddRange(this.selectedFontDto.Tags.ToArray());
      this.clstExistingTags.Items.AddRange(nonUsedTags.ToArray());
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
        this.installedFontsDto.Save();
      }
      this.ResumeLayout(true);
    }

    private void btnRemoveTag_Click(object sender, System.EventArgs e)
    {
      this.SuspendLayout();
      if (this.clstCurrentTags.CheckedItems.Count > 0)
      {
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
        this.installedFontsDto.Save();
      }
      this.ResumeLayout(true);
    }
  }
}
