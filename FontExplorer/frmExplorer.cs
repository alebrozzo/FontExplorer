using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace FontExplorer
{
  public partial class frmExplorer : Form
  {
    private readonly List<FontFamily> fontList;

    public frmExplorer()
    {
      InitializeComponent();
      this.fontList = GetFontList();
      foreach (var fontFamily in this.fontList)
      {
        this.flowLabelContainer.Controls.Add(this.CreateLabel(fontFamily));
      }
    }

    private void txtUserText_TextChanged(object sender, System.EventArgs e)
    {
      foreach (var label in this.flowLabelContainer.Controls)
      {
        ((Label)label).Text = this.txtUserText.Text;
      }
    }

    private static List<FontFamily> GetFontList()
    {
      var installedFontCollection = new InstalledFontCollection();
      var fonts = new List<FontFamily>(10);
      fonts.AddRange(installedFontCollection.Families);
      return fonts;
    }

    private Label CreateLabel(FontFamily family)
    {
      var newLabel = new Label()
      {
        Font = new Font(family, 24),
        Size = new Size(250, 75),
        Name = "lblSample_" + family,
        AutoEllipsis = true,
        UseMnemonic = false,
        TextAlign = ContentAlignment.MiddleCenter,
      };
      this.ttFontName.SetToolTip(newLabel, family.Name);
      return newLabel;
    }

    private void frmExplorer_Load(object sender, System.EventArgs e)
    {
      ((mdiContainer)this.MdiParent).ssStatusBar.Items["tsiFontCount"].Text = $"{this.fontList.Count} fonts";
    }
  }
}
