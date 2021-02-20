using FontExplorer.Dtos;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FontExplorer
{
  public partial class frmExplorer : Form
  {
    private readonly IList<FontFamily> fontList;
    private InstalledFontsDto installedFontsDto;

    public frmExplorer(IList<FontFamily> fontList, InstalledFontsDto installedFontsDto)
    {
      InitializeComponent();
      this.SuspendLayout();
      this.fontList = fontList;
      this.installedFontsDto = installedFontsDto;
      this.CreateFontLabels(fontList.Select(ff => ff.Name));
      this.CreateTagLabels(this.installedFontsDto.Tags);
      this.ResumeLayout(true);
    }

    private void CreateFontLabels(IEnumerable<string> fontList)
    {
      this.flpLabelContainer.Controls.Clear();
      foreach (var fontFamily in fontList)
      {
        this.flpLabelContainer.Controls.Add(this.CreateFontLabel(fontFamily));
      }
    }

    private Label CreateFontLabel(string familyName)
    {
      var newLabel = new Label()
      {
        Font = new Font(familyName, 24),
        Size = new Size(250, 75),
        Name = "lblFont_" + familyName,
        AutoEllipsis = true,
        UseMnemonic = false,
        TextAlign = ContentAlignment.MiddleCenter,
        Cursor = Cursors.Hand,
        Text = familyName,
      };
      newLabel.Click += new System.EventHandler(this.lblFont_Click);

      this.ttFontName.SetToolTip(newLabel, familyName);
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
        Font = this.lblTagHidden.Font,
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

    private void ApplyFilters(IEnumerable<string> selectedTags)
    {
      var fontNameList = this.installedFontsDto.Fonts
        .Where(f => f.Tags.Any(t => selectedTags.Contains(t)))
        .Select(f => f.Family);
      this.FilterFontLabels(fontNameList);
    }

    private void FilterFontLabels(IEnumerable<string> fontNameList)
    {
      this.flpLabelContainer.SuspendLayout();
      var fontList = fontNameList.ToList();
      var forceVisible = this.SelectedTags().Count() == 0;
      foreach (Label label in this.flpLabelContainer.Controls)
      {
        label.Visible = forceVisible || fontList.Contains(label.Font.FontFamily.Name);
      }
      this.flpLabelContainer.ResumeLayout(true);
    }

    private IEnumerable<string> SelectedTags()
    {
      var labelControls = this.flpTagContainer.Controls.OfType<Label>();
      return labelControls.Where(IsSelected).Select(l => l.Text);
    }

    private static bool IsSelected(Label label)
    {
      return label.BackColor != Color.Transparent;
    }

    private void txtUserText_TextChanged(object sender, System.EventArgs e)
    {
      this.flpLabelContainer.SuspendLayout();
      var useFontName = string.IsNullOrWhiteSpace(this.txtUserText.Text);
      foreach (Label label in this.flpLabelContainer.Controls)
      {
        label.Text = useFontName ? label.Font.FontFamily.Name : this.txtUserText.Text;
      }
      this.flpLabelContainer.ResumeLayout(true);
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
      if (!IsSelected(clickedLabel))
      {
        clickedLabel.BackColor = Color.CornflowerBlue;
        clickedLabel.ForeColor = Color.White;
      }
      else
      {
        clickedLabel.BackColor = Color.Transparent;
        clickedLabel.ForeColor = Color.Black;
      }

      var selectedTags = this.SelectedTags();
      this.ApplyFilters(selectedTags);
    }
  }
}
