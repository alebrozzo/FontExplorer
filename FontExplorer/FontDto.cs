using System.Collections.Generic;

namespace FontExplorer.Dtos
{
  public class InstalledFontsDto
  {
    public IList<FontDto> Fonts { get; set; }

    public SortedSet<string> Tags { get; set; }
  }

  public class FontDto
  {
    public string Family { get; set; }

    public List<string> Tags { get; set; }
  }
}
