using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

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
        var request = WebRequest.Create(url);
        request.Proxy = WebRequest.DefaultWebProxy;
        request.Credentials = CredentialCache.DefaultCredentials; ;
        request.Proxy.Credentials = CredentialCache.DefaultCredentials;
        var response = request.GetResponse();
        var reader = new StreamReader(response.GetResponseStream());

        string json = reader.ReadToEnd();

        Covers tmp;

        using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        {
          var settings = new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true };

          var serializer = new DataContractJsonSerializer(typeof(Covers), settings);
          tmp = (Covers)serializer.ReadObject(ms);
        }

        return tmp ?? c;
      }
      catch (Exception)
      {
        return c;
      }
    }

  }
}
