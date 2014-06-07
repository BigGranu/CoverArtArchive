using System;
using System.Net;
using Newtonsoft.Json;

namespace CoverArtArchive.Release_Group
{
  public class Get
  {
    /// <summary>
    /// Fetches a listing of available Covers for a MusicBrainz release.
    /// </summary>
    /// <param name="mbid">MusicBrainzId</param>
    /// <returns></returns>
    public static Covers Cover(string mbid)
    {
      return Search("http://www.coverartarchive.org/release-group/" + mbid + "/");
    }

    private static Covers Search(string url)
    {
      var c = new Covers();

      try
      {
        string json;
        using (var w = new WebClient())
        {
          json = w.DownloadString(url);
        }

        var settings = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };
        return JsonConvert.DeserializeObject<Covers>(json, settings);
      }
      catch (Exception)
      {
        return c;
      }
    }

  }
}
