using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace ClassLibrary1
{
    public class Class1
    {
        private Image _image;

        /// <summary>
        ///     Load the Image from Url
        /// </summary>
        public Image Image => _image;

        public void Save(string filename, ImageFormat format = null)
        {
            if (format == null)
                format = ImageFormat.Jpeg;

            Image?.Save(filename, format);
        }

    }


}
