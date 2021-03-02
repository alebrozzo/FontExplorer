using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FontExplorer.Dtos;

namespace FontExplorer
{
  public partial class frmExplorer : Form
  {
    private readonly InstalledFontsDto installedFontsDto;

    public frmExplorer(IList<string> fontList, InstalledFontsDto installedFontsDto)
    {
      InitializeComponent();
      this.installedFontsDto = installedFontsDto;
      this.installedFontsDto.DatabaseUpdated += this.installedFontsDto_DatabaseUpdated;
      this.LoadDatabaseInfo(fontList);
    }

    private void LoadDatabaseInfo(IList<string> fontList)
    {
      this.flpLabelContainer.SuspendLayout();
      this.CreateTagLabels(this.installedFontsDto.Tags);
      this.CreateFontLabels(fontList);
      this.ApplyFilters(new List<string>(0));
      this.flpLabelContainer.ResumeLayout(true);
    }

    private void CreateFontLabels(IList<string> fontList)
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
      newLabel.Click += new EventHandler(this.lblFont_Click);

      this.ttFontName.SetToolTip(newLabel, familyName);
      return newLabel;
    }

    private void CreateTagLabels(ISet<string> tagList)
    {
      foreach (var tagName in tagList)
      {
        bool tagLabelExists = this.flpTagContainer.Controls.OfType<Label>().Any(ctrl => ctrl.Text == tagName);
        if (!tagLabelExists)
        {
          this.flpTagContainer.Controls.Add(this.CreateTagLabel(tagName));
        }
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
      newLabel.Click += new EventHandler(this.lblTag_Click);
      return newLabel;
    }

    private void ApplyFilters(IList<string> selectedTags)
    {
      var fontsToShow = this.GetFontsToShow(selectedTags);
      this.FilterFontLabels(fontsToShow);
    }

    private IList<string> GetFontsToShow(IList<string> selectedTags)
    {
      var noTagSelected = selectedTags.Count() == 0;
      if (noTagSelected)
      {
        return this.GetAllNonHiddenFonts();
      }

      bool isHiddenSelected = selectedTags.Contains(InstalledFontsDto.HiddenFontTag);
      if (isHiddenSelected)
      {
        return this.GetHiddenFonts();
      }

      return this.GetFontsWithMatchingTag(selectedTags);
    }

    private IList<string> GetFontsWithMatchingTag(IList<string> selectedTags)
    {
      return this.installedFontsDto.Fonts
        .Where(f => f.Tags.Any(t => selectedTags.Contains(t)))
        .Where(f => !f.Tags.Contains(InstalledFontsDto.HiddenFontTag))
        .Select(f => f.Family)
        .ToList();
    }

    private IList<string> GetHiddenFonts()
    {
      return this.installedFontsDto.Fonts
        .Where(f => f.Tags.Contains(InstalledFontsDto.HiddenFontTag))
        .Select(f => f.Family)
        .ToList();
    }

    private IList<string> GetAllNonHiddenFonts()
    {
      var allFontsToHide = this.installedFontsDto.Fonts
        .Where(f => f.Tags.Contains(InstalledFontsDto.HiddenFontTag))
        .Select(f => f.Family)
        .ToList();
      var allFontNames = this.flpLabelContainer.Controls.OfType<Label>().Select(l => l.Font.FontFamily.Name);
      var notHidentFontNames = allFontNames.Where(fontName => !allFontsToHide.Contains(fontName));
      return notHidentFontNames.ToList();
    }

    private void FilterFontLabels(IList<string> fontNameList)
    {
      var selectedTags = this.SelectedTags();
      this.flpLabelContainer.SuspendLayout();
      foreach (Label label in this.flpLabelContainer.Controls)
      {
        label.Visible = fontNameList.Contains(label.Font.FontFamily.Name);
      }
      this.flpLabelContainer.ResumeLayout(true);
    }

    private IList<string> SelectedTags()
    {
      var labelControls = this.flpTagContainer.Controls.OfType<Label>();
      return labelControls.Where(IsSelected).Select(l => l.Text).ToList();
    }

    private static bool IsSelected(Label label)
    {
      return label.BackColor != Color.Transparent;
    }

    private void SetTagLabelAsSelected(Label label)
    {
      label.BackColor = Color.CornflowerBlue;
      label.ForeColor = Color.White;
    }

    private void SetTagLabelAsNotSelected(Label label)
    {
      label.BackColor = Color.Transparent;
      label.ForeColor = Color.Black;
    }

    private void SetAllTagLabelAsNotSelected()
    {
      foreach (Label label in this.flpTagContainer.Controls)
      {
        if (label.Text != InstalledFontsDto.HiddenFontTag)
        {
          this.SetTagLabelAsNotSelected(label);
        }
      }
    }

    private void txtUserText_TextChanged(object sender, EventArgs e)
    {
      this.flpLabelContainer.SuspendLayout();
      var useFontName = string.IsNullOrWhiteSpace(this.txtUserText.Text);
      foreach (Label label in this.flpLabelContainer.Controls)
      {
        label.Text = useFontName ? label.Font.FontFamily.Name : this.txtUserText.Text;
      }
      this.flpLabelContainer.ResumeLayout(true);
    }

    private void lblFont_Click(object sender, EventArgs e)
    {
      var frmFontManagerInstance = new frmFontManager(this.installedFontsDto);
      frmFontManagerInstance.SetSelectedFont(((Label)sender).Font.FontFamily);
      frmFontManagerInstance.MdiParent = this.MdiParent;
      frmFontManagerInstance.Show();
    }

    private void lblTag_Click(object sender, EventArgs e)
    {
      var clickedLabel = (Label)sender;
      if (!IsSelected(clickedLabel))
      {
        this.SetTagLabelAsSelected(clickedLabel);
        if (clickedLabel.Text == InstalledFontsDto.HiddenFontTag)
        {
          this.SetAllTagLabelAsNotSelected();
        }
        else
        {
          var hiddenTag = this.flpTagContainer.Controls.OfType<Label>().SingleOrDefault(l => l.Text == InstalledFontsDto.HiddenFontTag);
          this.SetTagLabelAsNotSelected(hiddenTag);
        }
      }
      else
      {
        this.SetTagLabelAsNotSelected(clickedLabel);
      }

      var selectedTags = this.SelectedTags();
      this.ApplyFilters(selectedTags);
    }

    private void installedFontsDto_DatabaseUpdated(object sender, EventArgs e)
    {
      this.CreateTagLabels(this.installedFontsDto.Tags);
      var selectedTags = this.SelectedTags();
      this.ApplyFilters(selectedTags);
    }
  }
}
