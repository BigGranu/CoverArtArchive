#region Copyright (C) 2015-2018 BigGranu

/*
    Copyright (C) 2015-2018 BigGranu

    This file is part of mInfo <https://github.com/BigGranu/MusicApiCollection>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BigGranu.CoverArtArchive.Data
{
    /// <summary>
    ///     Covers
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    [DataContract]
    public class Cover
    {
        /// <summary>
        ///     Collection of Informations about the last Call
        /// </summary>
        public ApiStatus ApiStatus { get; set; }

        /// <summary>
        ///     If using Typ in Search, the selected Image is here
        /// </summary>
        public string Selected;

        /// <summary>
        ///     List of Images
        /// </summary>
        [DataMember(Name = "images")]
        public List<Image> Images { get; set; }

        /// <summary>
        ///     Release
        /// </summary>
        [DataMember(Name = "release")]
        public string MusicBrainzRelease { get; set; }
    }

    /// <summary>
    /// a Cover with Details
    /// </summary>
    [DataContract]
    public class Image
    {
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
        public int Edit { get; set; }

        /// <summary>
        /// the full coverartarchive.org url to the original image
        /// </summary>
        [DataMember(Name = "image")]
        public string Uri { get; set; }

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

    /////// <summary>
    ///////     Image
    /////// </summary>
    ////public class Image
    ////{
    ////    /// <summary>
    ////    ///     List of Imagetypes
    ////    /// </summary>
    ////    [JsonProperty("types")]
    ////    public List<string> Types { get; set; }

    ////    /// <summary>
    ////    ///     Frontimage
    ////    /// </summary>
    ////    [JsonProperty("front")]
    ////    public bool Front { get; set; }

    ////    /// <summary>
    ////    ///     Backimage
    ////    /// </summary>
    ////    [JsonProperty("back")]
    ////    public bool Back { get; set; }

    ////    /// <summary>
    ////    ///     Comment
    ////    /// </summary>
    ////    [JsonProperty("comment")]
    ////    public string Comment { get; set; }

    ////    /// <summary>
    ////    ///     Image
    ////    /// </summary>
    ////    [JsonProperty("image")]
    ////    public Uri ImageImage { get; set; }

    ////    /// <summary>
    ////    ///     List of Thumbnails
    ////    /// </summary>
    ////    [JsonProperty("thumbnails")]
    ////    public Thumbnails Thumbnails { get; set; }

    ////    /// <summary>
    ////    ///     Approved?
    ////    /// </summary>
    ////    [JsonProperty("approved")]
    ////    public bool Approved { get; set; }

    ////    /// <summary>
    ////    ///     Edit?
    ////    /// </summary>
    ////    [JsonProperty("edit")]
    ////    public long Edit { get; set; }

    ////    /// <summary>
    ////    ///     ArchiveId
    ////    /// </summary>
    ////    [JsonProperty("id")]
    ////    public string Id { get; set; }
    ////}

    /////// <summary>
    ///////     List of Thumbnails
    /////// </summary>
    ////public class Thumbnails
    ////{   
    ////    /// <summary>
    ////    ///     Url for the small Thumbnail
    ////    /// </summary>
    ////    [JsonProperty("small")]
    ////    public Uri Small { get; set; }

    ////    /// <summary>
    ////    ///     Url for the large Thumbnail
    ////    /// </summary>
    ////    [JsonProperty("large")]
    ////    public Uri Large { get; set; }

    ////    /// <summary>
    ////    ///     Url for the 250px Thumbnail
    ////    /// </summary>
    ////    [JsonProperty("250", NullValueHandling = NullValueHandling.Ignore)]
    ////    public Uri The250 { get; set; }

    ////    /// <summary>
    ////    ///     Url for the 500px Thumbnail
    ////    /// </summary>
    ////    [JsonProperty("500", NullValueHandling = NullValueHandling.Ignore)]
    ////    public Uri The500 { get; set; }

    ////    /// <summary>
    ////    ///     Url for the 120px Thumbnail
    ////    /// </summary>
    ////    [JsonProperty("1200", NullValueHandling = NullValueHandling.Ignore)]
    ////    public Uri The1200 { get; set; }
    ////}

    /// <summary>
    /// Thumbnails
    /// </summary>
    [DataContract]
    public class Thumb
    {
        /// <summary>
        ///  Url for the large Thumbnail
        /// </summary>
        [DataMember(Name = "large")]
        public string Large { get; set; }

        /// <summary>
        ///  Url for the small Thumbnail
        /// </summary>
        [DataMember(Name = "small")]
        public string Small { get; set; }

        /// <summary>
        ///     Url for the 250px Thumbnail
        /// </summary>
        [DataMember(Name = "250")]
        public Uri The250 { get; set; }

        /// <summary>
        ///     Url for the 500px Thumbnail
        /// </summary>
        [DataMember(Name = "500")]
        public Uri The500 { get; set; }

        /// <summary>
        ///     Url for the 120px Thumbnail
        /// </summary>
        [DataMember(Name = "1200")]
        public Uri The1200 { get; set; }
    }

    //[DataContract]
    //public class Thumbnails
    //{

    //    [DataMember(Name = "large")]
    //    public string Large { get; set; }

    //    [DataMember(Name = "small")]
    //    public string Small { get; set; }
    //}

    //[DataContract]
    //public class Image
    //{

    //    [DataMember(Name = "types")]
    //    public IList<string> Types { get; set; }

    //    [DataMember(Name = "front")]
    //    public bool Front { get; set; }

    //    [DataMember(Name = "back")]
    //    public bool Back { get; set; }

    //    [DataMember(Name = "edit")]
    //    public int Edit { get; set; }

    //    [DataMember(Name = "image")]
    //    public string Url { get; set; }

    //    [DataMember(Name = "comment")]
    //    public string Comment { get; set; }

    //    [DataMember(Name = "approved")]
    //    public bool Approved { get; set; }

    //    [DataMember(Name = "thumbnails")]
    //    public Thumbnails Thumbnails { get; set; }

    //    [DataMember(Name = "id")]
    //    public string Id { get; set; }
    //}

    //[DataContract]
    //public class Cover
    //{
    //    /// <summary>
    //    ///     Collection of Informations about the last Call
    //    /// </summary>
    //    public ApiStatus ApiStatus { get; set; }

    //    /// <summary>
    //    ///     If using Typ in Search, the selected Image is here
    //    /// </summary>
    //    public CoverArt CoverArt;

    //    [DataMember(Name = "images")]
    //    public IList<Image> Images { get; set; }

    //    [DataMember(Name = "release")]
    //    public string Release { get; set; }
    //}

}