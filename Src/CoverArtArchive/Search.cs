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
using CoverArtArchive.Data;
using CoverArtArchive.Events;
using CoverArtArchive.Helper;

namespace CoverArtArchive
{
    /// <summary>
    ///     Search on CoverArtArchive
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    public class Search
    {
        private static readonly Logging Logging = Logging.Instance;
        private static readonly Exceptions Exceptions = Exceptions.Instance;
        private static readonly string ns = "CoverArtArchive";
        private static readonly string cl = "Search";

        /// <summary>
        ///     Coversize
        /// </summary>
        public enum Size
        {
            /// <summary>
            ///     250 px
            /// </summary>
            Small,

            /// <summary>
            ///     500 px
            /// </summary>
            Large,

            /// <summary>
            ///     max Size
            /// </summary>
            Full
        }

        /// <summary>
        ///     Covertyp
        /// </summary>
        public enum Typ
        {
            /// <summary>
            ///     Front
            /// </summary>
            Front,

            /// <summary>
            ///     Back
            /// </summary>
            /// <remarks>
            ///     Only supported in Release <br />
            ///     In Releasegroup it os ignored
            /// </remarks>
            Back,

            /// <summary>
            ///     Null
            /// </summary>
            Null
        }

        /// <summary>
        ///     <a href="https://musicbrainz.org/doc/Cover_Art_Archive/API#.2Frelease.2F.7Bmbid.7D.2F" target="_blank">
        ///         Available Cover Art for a MusicBrainz release
        ///     </a>
        /// </summary>
        /// <param name="mbid">MusicbrainzId</param>
        /// <param name="typ">Covertyp</param>
        /// <param name="size">Coversize</param>
        /// <returns>
        ///     Covers
        /// </returns>
        public static Cover Release(string mbid, Typ typ = Typ.Null, Size size = Size.Full)
        {
            Logging.NewLogEntry(new LoggingArgs(ns, cl, "Release", new Para("mbid", mbid)));

            var ret = new Cover();

            try
            {
                var imageUrl = "";

                if (typ == Typ.Front)
                    imageUrl = "/front";

                if (typ == Typ.Back)
                    imageUrl = "/back";

                if (size == Size.Small && typ != Typ.Null)
                    imageUrl += "-250";

                if (size == Size.Large && typ != Typ.Null)
                    imageUrl += "-500";

                if (imageUrl != "")
                    ret.CoverArt = new CoverArt(Http.GetImageUrl("http://coverartarchive.org/release/" + mbid + imageUrl));
                else
                    ret = Json.Deserialize<Cover>(Http.Request("http://coverartarchive.org/release/" + mbid + "/"));
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            ret.ApiStatus = new ApiStatus(ns, cl, "Release");
            Logging.NewStatus(ret.ApiStatus);
            return ret;
        }

        //70664047-2545-4e46-b75f-4556f2a7b83e
        //http://coverartarchive.org/release-group/c194aa0b-f8a8-3d98-9283-7cee370a5ace


        /// <summary>
        ///     Covers for a Releasegroup
        /// </summary>
        /// <param name="mbid">MusicbrainzId</param>
        /// <param name="typ">Covertyp</param>
        /// <param name="size">Coversize</param>
        /// <returns>
        ///     Covers
        /// </returns>
        public static Cover ReleaseGroup(string mbid, Typ typ = Typ.Null, Size size = Size.Full)
        {
            Logging.NewLogEntry(new LoggingArgs(ns, cl, "ReleaseGroup", new Para("mbid", mbid)));

            var ret = new Cover();

            try
            {
                var imageUrl = "";

                if (typ == Typ.Front)
                    imageUrl = "/front";

                if (size == Size.Small && typ != Typ.Null)
                    imageUrl += "-250";

                if (size == Size.Large && typ != Typ.Null)
                    imageUrl += "-500";

                if (imageUrl != "")
                    ret.CoverArt = new CoverArt(Http.GetImageUrl("http://coverartarchive.org/release-group/" + mbid + imageUrl));
                else
                    ret = Json.Deserialize<Cover>(Http.Request("http://coverartarchive.org/release-group/" + mbid + "/"));
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            ret.ApiStatus = new ApiStatus(ns, cl, "Release");
            Logging.NewStatus(ret.ApiStatus);
            return ret;
        }
    }
}