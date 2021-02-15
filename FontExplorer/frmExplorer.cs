using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FontExplorer
{
  public partial class frmExplorer : Form
  {
    public frmExplorer(List<FontFamily> fontList)
    {
      InitializeComponent();
      foreach (var fontFamily in fontList)
      {
        this.flowLabelContainer.Controls.Add(this.CreateLabel(fontFamily));
      }
    }

    private void txtUserText_TextChanged(object sender, System.EventArgs e)
    {
      var useFontName = string.IsNullOrWhiteSpace(this.txtUserText.Text);
      foreach (Label label in this.flowLabelContainer.Controls)
      {
        label.Text = useFontName ? label.Font.FontFamily.Name : this.txtUserText.Text;
      }
    }

    private Label CreateLabel(FontFamily family)
    {
      var newLabel = new Label()
      {
        Font = new Font(family, 24),
        Size = new Size(250, 75),
        Name = "lblFont_" + family,
        AutoEllipsis = true,
        UseMnemonic = false,
        TextAlign = ContentAlignment.MiddleCenter,
        Cursor = Cursors.Hand,
        Text = family.Name,
      };
      newLabel.Click += new System.EventHandler(this.lblFont_Click);

      this.ttFontName.SetToolTip(newLabel, family.Name);
      return newLabel;
    }

    private void lblFont_Click(object sender, System.EventArgs e)
    {
      var frmFontManagerInstance = new frmFontManager();
      frmFontManagerInstance.SetSelectedFont(((Label)sender).Font.FontFamily);
      frmFontManagerInstance.MdiParent = this.MdiParent;
      frmFontManagerInstance.Show();
    }
  }
}
