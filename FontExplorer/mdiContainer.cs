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
