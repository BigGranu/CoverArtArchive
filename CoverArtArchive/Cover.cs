using System.Collections.Generic;
using Newtonsoft.Json;

namespace CoverArtArchive
{
  /// <summary>
  /// a Cover with Details
  /// </summary>
  public class Cover
  {
    public Cover()
    {
      Types = new List<string>();
      Front = false;
      Back = false;
      Edit = 0;
      Image = string.Empty;
      Comment = string.Empty;
      Approved = false;
      Id = string.Empty;
      Thumbnails = new Thumb();
    }

    /// <summary>
    ///  list of zero or more types for the image
    /// </summary>
    [JsonProperty("types")]
    public List<string> Types { get; set; }

    /// <summary>
    ///  boolean, indicates if this is the "main front"
    /// </summary>
    [JsonProperty("front")]
    public bool Front { get; set; }

    /// <summary>
    /// boolean, indicates if this is the "main back"
    /// </summary>
    [JsonProperty("back")]
    public bool Back { get; set; }

    /// <summary>
    /// the edit id on musicbrainz (e.g. 123)
    /// </summary>
    [JsonProperty("edit")]
    public int Edit { get; set; }

    /// <summary>
    /// the full coverartarchive.org url to the original image
    /// </summary>
    [JsonProperty("image")]
    public string Image { get; set; }

    /// <summary>
    /// a free text comment
    /// </summary>
    [JsonProperty("comment")]
    public string Comment { get; set; }

    /// <summary>
    /// whether the image was approved by the musicbrainz edit system
    /// </summary>
    [JsonProperty("approved")]
    public bool Approved { get; set; }

    /// <summary>
    /// The CoverArtArchive ID
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }

    /// <summary>
    /// a List of Thumbs
    /// </summary>
    [JsonProperty("thumbnails")]
    public Thumb Thumbnails { get; set; }
  }
}
