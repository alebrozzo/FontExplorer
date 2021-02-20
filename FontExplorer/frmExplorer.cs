using FontExplorer.Dtos;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FontExplorer
{
  public partial class frmExplorer : Form
  {
    private InstalledFontsDto installedFontsDto;

    public frmExplorer(List<FontFamily> fontList, InstalledFontsDto installedFontsDto)
    {
      InitializeComponent();
      this.SuspendLayout();
      this.installedFontsDto = installedFontsDto;
      this.CreateFontLabels(fontList);
      this.CreateTagLabels(this.installedFontsDto.Tags);
      this.ResumeLayout(true);
    }

    private void txtUserText_TextChanged(object sender, System.EventArgs e)
    {
      this.SuspendLayout();
      var useFontName = string.IsNullOrWhiteSpace(this.txtUserText.Text);
      foreach (Label label in this.flpLabelContainer.Controls)
      {
        label.Text = useFontName ? label.Font.FontFamily.Name : this.txtUserText.Text;
      }
      this.ResumeLayout(true);
    }

    private void CreateFontLabels(IList<FontFamily> fontList)
    {
      foreach (var fontFamily in fontList)
      {
        this.flpLabelContainer.Controls.Add(this.CreateFontLabel(fontFamily));
      }
    }

    private Label CreateFontLabel(FontFamily family)
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

    private void CreateTagLabels(ISet<string> tagList)
    {
      foreach (var tagName in tagList)
      {
        this.flpTagContainer.Controls.Add(this.CreateTagLabel(tagName));
      }
    }

    private Label CreateTagLabel(string tagName)
    {
      var newLabel = new Label()
      {
        Font = this.lblTagSample.Font,
        Name = "lblTag_" + tagName,
        UseMnemonic = false,
        TextAlign = ContentAlignment.MiddleCenter,
        Cursor = Cursors.Hand,
        BackColor = Color.Transparent,
        ForeColor = Color.Black,
        Text = tagName,
      };
      newLabel.Click += new System.EventHandler(this.lblTag_Click);
      return newLabel;
    }

    private void ApplyFilters()
    {
      
    }

    private void lblFont_Click(object sender, System.EventArgs e)
    {
      var frmFontManagerInstance = new frmFontManager(this.installedFontsDto);
      frmFontManagerInstance.SetSelectedFont(((Label)sender).Font.FontFamily);
      frmFontManagerInstance.MdiParent = this.MdiParent;
      frmFontManagerInstance.Show();
    }

    private void lblTag_Click(object sender, System.EventArgs e)
    {
      var clickedLabel = (Label)sender;
      bool isSelecting = clickedLabel.BackColor == Color.Transparent;
      if (isSelecting)
      {
        clickedLabel.BackColor = Color.CornflowerBlue;
        clickedLabel.ForeColor = Color.White;
      }
      else
      {
        clickedLabel.BackColor = Color.Transparent;
        clickedLabel.ForeColor = Color.Black;
      }

      this.ApplyFilters();
    }
  }
}
