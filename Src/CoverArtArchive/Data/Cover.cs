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
using Newtonsoft.Json;

namespace CoverArtArchive.Data
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
    public  class Cover
    {
        /// <summary>
        ///     Collection of Informations about the last Call
        /// </summary>
        public ApiStatus ApiStatus { get; set; }

        /// <summary>
        ///     If using Typ in Search, the selected Image is here
        /// </summary>
        public CoverArt CoverArt;

        /// <summary>
        ///     List of Images
        /// </summary>
        [JsonProperty("images")]
        public List<Image> Images { get; set; }

        /// <summary>
        ///     Release
        /// </summary>
        [JsonProperty("release")]
        public Uri Release { get; set; }
    }

    /// <summary>
    ///     Image
    /// </summary>
    public class Image
    {
        /// <summary>
        ///     List of Imagetypes
        /// </summary>
        [JsonProperty("types")]
        public List<string> Types { get; set; }

        /// <summary>
        ///     Frontimage
        /// </summary>
        [JsonProperty("front")]
        public bool Front { get; set; }

        /// <summary>
        ///     Backimage
        /// </summary>
        [JsonProperty("back")]
        public bool Back { get; set; }

        /// <summary>
        ///     Comment
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; set; }

        /// <summary>
        ///     Image
        /// </summary>
        [JsonProperty("image")]
        public Uri ImageImage { get; set; }

        /// <summary>
        ///     List of Thumbnails
        /// </summary>
        [JsonProperty("thumbnails")]
        public Thumbnails Thumbnails { get; set; }

        /// <summary>
        ///     Approved?
        /// </summary>
        [JsonProperty("approved")]
        public bool Approved { get; set; }

        /// <summary>
        ///     Edit?
        /// </summary>
        [JsonProperty("edit")]
        public long Edit { get; set; }

        /// <summary>
        ///     ArchiveId
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    /// <summary>
    ///     List of Thumbnails
    /// </summary>
    public class Thumbnails
    {   
        /// <summary>
        ///     Url for the small Thumbnail
        /// </summary>
        [JsonProperty("small")]
        public Uri Small { get; set; }

        /// <summary>
        ///     Url for the large Thumbnail
        /// </summary>
        [JsonProperty("large")]
        public Uri Large { get; set; }

        /// <summary>
        ///     Url for the 250px Thumbnail
        /// </summary>
        [JsonProperty("250", NullValueHandling = NullValueHandling.Ignore)]
        public Uri The250 { get; set; }

        /// <summary>
        ///     Url for the 500px Thumbnail
        /// </summary>
        [JsonProperty("500", NullValueHandling = NullValueHandling.Ignore)]
        public Uri The500 { get; set; }

        /// <summary>
        ///     Url for the 120px Thumbnail
        /// </summary>
        [JsonProperty("1200", NullValueHandling = NullValueHandling.Ignore)]
        public Uri The1200 { get; set; }
    }


}