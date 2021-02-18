using FontExplorer.Dtos;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace FontExplorer
{
  public partial class mdiContainer : Form
  {
    private const string FontDbFileName = "FontDb.json";
    private readonly List<FontFamily> fontList;
    private InstalledFontsDto installedFontsDto;

    public mdiContainer()
    {
      InitializeComponent();
      this.Cursor = Cursors.WaitCursor;
      this.fontList = GetFontList();
      this.ssStatusBar.Items["tsiFontCount"].Text = $"{this.fontList.Count} fonts";
      if (!File.Exists(FontDbFileName))
      {
        var initDto = new InstalledFontsDto()
        {
          fonts = new List<FontDto>(0),
          tags = new List<string>(0),
        };
        var initDb = JsonSerializer.Serialize(initDto);
        File.WriteAllText(FontDbFileName, initDb);
      }

      string jsonDb = File.ReadAllText(FontDbFileName);
      this.installedFontsDto = JsonSerializer.Deserialize<InstalledFontsDto>(jsonDb);
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
        "frmExplorer" => new frmExplorer(this.fontList, this.installedFontsDto),
        _ => throw new System.Exception($"{e.ClickedItem.Tag} is not defined"),
      };
      this.Cursor = Cursors.Default;
      childForm.MdiParent = this;
      childForm.Show();
    }
  }
}
