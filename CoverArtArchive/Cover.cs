using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CoverArtArchive
{
  /// <summary>
  /// a Cover with Details
  /// </summary>
  [DataContract]
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
    [DataMember(Name = "types")]
    public List<string> Types { get; set; }

    /// <summary>
    ///  boolean, indicates if this is the "main front"
    /// </summary>
    [DataMember(Name = "front")]
    public bool Front { get; set; }

    /// <summary>
    /// boolean, indicates if this is the "main back"
    /// </summary>
    [DataMember(Name = "back")]
    public bool Back { get; set; }

    /// <summary>
    /// the edit id on musicbrainz (e.g. 123)
    /// </summary>
    [DataMember(Name = "edit")]
    public int? Edit { get; set; }

    /// <summary>
    /// the full coverartarchive.org url to the original image
    /// </summary>
    [DataMember(Name = "image")]
    public string Image { get; set; }

    /// <summary>
    /// a free text comment
    /// </summary>
    [DataMember(Name = "comment")]
    public string Comment { get; set; }

    /// <summary>
    /// whether the image was approved by the musicbrainz edit system
    /// </summary>
    [DataMember(Name = "approved")]
    public bool Approved { get; set; }

    /// <summary>
    /// The CoverArtArchive ID
    /// </summary>
    [DataMember(Name = "id")]
    public string Id { get; set; }

    /// <summary>
    /// a List of Thumbs
    /// </summary>
    [DataMember(Name = "thumbnails")]
    public Thumb Thumbnails { get; set; }
  }
}
