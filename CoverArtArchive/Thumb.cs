using Newtonsoft.Json;

namespace CoverArtArchive
{
  /// <summary>
  /// Thumbnails
  /// </summary>
  public class Thumb
  {
    public Thumb()
    {
      Large = string.Empty;
      Small = string.Empty;
    }

    /// <summary>
    ///  http://coverartarchive.org/...-500.jpg
    /// </summary>
    [JsonProperty("large")]
    public string Large { get; set; }

    /// <summary>
    ///  http://coverartarchive.org/...-250.jpg
    /// </summary>
    [JsonProperty("small")]
    public string Small { get; set; }
  }
}
