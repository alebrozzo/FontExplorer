using System.Linq;
using System.Windows.Forms;

namespace FontExplorer
{
  public partial class mdiContainer : Form
  {
    public mdiContainer()
    {
      InitializeComponent();
    }

    private void mnsMainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
      bool formAlreadyOpen = this.MdiChildren.Any(form => form.Name == e.ClickedItem.Tag.ToString());
      if (formAlreadyOpen)
      {
        return;
      }

      Form childForm = e.ClickedItem.Tag switch
      {
        "frmExplorer" => new frmExplorer(),
        _ => throw new System.Exception($"{e.ClickedItem.Tag} is not defined"),
      };
      childForm.MdiParent = this;
      childForm.Show();
    }
  }
}
