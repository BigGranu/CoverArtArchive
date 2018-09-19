using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using CoverArtArchive;

namespace test20
{
    class Program
    {
        static void Main(string[] args)
        {

            // http://coverartarchive.org/release/2ba4396d-c0be-4a56-b4ea-0438306eb3be

            // http://coverartarchive.org/release/2ba4396d-c0be-4a56-b4ea-0438306eb3be/829917611.jpg
            // https://ia800607.us.archive.org/32/items/mbid-2ba4396d-c0be-4a56-b4ea-0438306eb3be/mbid-2ba4396d-c0be-4a56-b4ea-0438306eb3be-829917611.jpg


            var ret = CoverArtArchive.Search.Release("2ba4396d-c0be-4a56-b4ea-0438306eb3be", Search.Typ.Front, Search.Size.Small);


        }
    }
}