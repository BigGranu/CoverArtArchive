using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CoverArtArchive
{
  /// <summary>
  /// All Covers 
  /// </summary>
  [DataContract]
  public class Covers
  {
    public Covers()
    {
      Images = new List<Cover> {new Cover()};
      Release = String.Empty;
    }

    /// <summary>
    /// a List of Covers
    /// </summary>
    [DataMember(Name = "images")]
    public List<Cover> Images { get; set; }

    /// <summary>
    /// the MusicBrainz release
    /// </summary>
    [DataMember(Name = "release")]
    public string Release { get; set; }
  }
}
