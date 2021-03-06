﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace FontExplorer.Dtos
{
  public class InstalledFontsDto
  {
    private const string FontDbFileName = "FontDb.json";

    public static readonly string HiddenFontTag = " Hidden fonts";

    public event EventHandler DatabaseUpdated;

    public IList<FontDto> Fonts { get; set; }

    public SortedSet<string> Tags { get; set; }

    public static InstalledFontsDto Load()
    {
      if (!File.Exists(FontDbFileName))
      {
        var initDto = new InstalledFontsDto()
        {
          Fonts = new List<FontDto>(0),
          Tags = new SortedSet<string>() { HiddenFontTag, "Glifos" },
        };
        var initDb = JsonSerializer.Serialize(initDto);
        File.WriteAllText(FontDbFileName, initDb);
      }

      string jsonDb = File.ReadAllText(FontDbFileName);
      return JsonSerializer.Deserialize<InstalledFontsDto>(jsonDb);
    }

    public async Task Save()
    {
      string text = JsonSerializer.Serialize(this);
      await File.WriteAllTextAsync(FontDbFileName, text);
      this.OnSave(new EventArgs());
    }

    protected virtual void OnSave(EventArgs e)
    {
       DatabaseUpdated?.Invoke(this, e);
    }
  }

  public class FontDto
  {
    public string Family { get; set; }

    public SortedSet<string> Tags { get; set; }
  }
}
