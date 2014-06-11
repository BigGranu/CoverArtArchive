using System.Runtime.Serialization;

namespace CoverArtArchive
{
  /// <summary>
  /// Thumbnails
  /// </summary>
  [DataContract]
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
    [DataMember(Name = "large")]
    public string Large { get; set; }

    /// <summary>
    ///  http://coverartarchive.org/...-250.jpg
    /// </summary>
    [DataMember(Name = "small")]
    public string Small { get; set; }
  }
}
