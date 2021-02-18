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
      FontDto selectedFontDto = this.installedFontsDto.Fonts.SingleOrDefault(f => f.Family == fontFamily.Name);
      if (selectedFontDto == null)
      {
        selectedFontDto = new FontDto()
        {
          Family = fontFamily.Name,
          Tags = new List<string>(),
        };
      }

      var nonUsedTags = this.installedFontsDto.Tags.Except(selectedFontDto.Tags);
      this.clstCurrentTags.Items.AddRange(selectedFontDto.Tags.ToArray());
      this.clstExistingTags.Items.AddRange(nonUsedTags.ToArray());
    }
  }
}
