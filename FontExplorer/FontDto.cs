using System.Collections.Generic;

namespace FontExplorer.Dtos
{
  public class InstalledFontsDto
  {
    public IList<FontDto> fonts { get; set; }

    public IList<string> tags { get; set; }
  }

  public class FontDto
  {
    public string family { get; set; }

    public string[] tags { get; set; }
  }
}
