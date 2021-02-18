using FontExplorer.Dtos;
using System.Drawing;
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
    }
  }
}
