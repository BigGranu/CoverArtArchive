using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CoverArtArchive
{
  /// <summary>
  /// All Covers 
  /// </summary>
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
    [JsonProperty("images")]
    public List<Cover> Images { get; set; }

    /// <summary>
    /// the MusicBrainz release
    /// </summary>
    [JsonProperty("release")]
    public string Release { get; set; }
  }
}
