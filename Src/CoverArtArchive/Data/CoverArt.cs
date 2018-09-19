//using System.Drawing;
//using System.Drawing.Imaging;

namespace CoverArtArchive.Data
{
    /// <summary>
    ///     CoverArt
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    public class CoverArt
    {
        //private Image _image;

        /// <summary>
        ///     Create a new CoveArt
        /// </summary>
        /// <param name="url">URL to the Image</param>
        public CoverArt(string url)
        {
            Url = url;
        }

        /// <summary>
        ///     URL to the Image
        /// </summary>
        public string Url { get; }

        ///// <summary>
        /////     Load the Image from Url
        ///// </summary>
        //public Image Image => _image ?? (_image = Download());

        ///// <summary>
        /////     Save the Image
        ///// </summary>
        ///// <param name="filename">Filename</param>
        ///// <param name="format">Imageformat</param>
        //public void Save(string filename, ImageFormat format = null)
        //{
        //    if (format == null)
        //        format = ImageFormat.Jpeg;

        //    Image?.Save(filename, format);
        //}

        //private Image Download()
        //{
        //    try
        //    {
        //        Image img;
        //        using (var wc = new WebClient())
        //        {
        //            using (var stream = wc.OpenRead(Url))
        //            {
        //                img = new Bitmap(stream);
        //                stream.Flush();
        //            }
        //        }

        //        return img;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }

        //    return null;
        //}
    }
}