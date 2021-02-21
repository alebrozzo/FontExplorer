using FontExplorer.Dtos;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace FontExplorer
{
  public partial class mdiContainer : Form
  {
    private readonly IList<FontFamily> fontList;
    private InstalledFontsDto installedFontsDto;

    public mdiContainer()
    {
      InitializeComponent();
      this.Cursor = Cursors.WaitCursor;
      this.fontList = GetFontList();
      this.ssStatusBar.Items["tsiFontCount"].Text = $"{this.fontList.Count} fonts";
      this.installedFontsDto = InstalledFontsDto.Load();
      this.Cursor = Cursors.Default;
    }

    private static List<FontFamily> GetFontList()
    {
      var installedFontCollection = new InstalledFontCollection();
      var fonts = new List<FontFamily>(10);
      fonts.AddRange(installedFontCollection.Families);
      return fonts;
    }

    private void mnsMainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
      bool formAlreadyOpen = this.MdiChildren.Any(form => form.Name == e.ClickedItem.Tag.ToString());
      if (formAlreadyOpen)
      {
        return;
      }

      this.Cursor = Cursors.WaitCursor;
      Form childForm = e.ClickedItem.Tag switch
      {
        "frmExplorer" => new frmExplorer(this.fontList.Select(ff => ff.Name).ToList(), this.installedFontsDto),
        _ => throw new System.Exception($"{e.ClickedItem.Tag} is not defined"),
      };
      this.Cursor = Cursors.Default;
      childForm.MdiParent = this;
      childForm.Show();
    }
  }
}
