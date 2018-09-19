using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BigGranu.CoverArtArchive;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // https://ia800607.us.archive.org/32/items/mbid-2ba4396d-c0be-4a56-b4ea-0438306eb3be/mbid-2ba4396d-c0be-4a56-b4ea-0438306eb3be-829914835_thumb250.jpg

            // http://archive.org/download/mbid-2ba4396d-c0be-4a56-b4ea-0438306eb3be/mbid-2ba4396d-c0be-4a56-b4ea-0438306eb3be-829914835_thumb250.jpg

            // http://coverartarchive.org/release/2ba4396d-c0be-4a56-b4ea-0438306eb3be/front-250

            var ret1 = Search.Release("2ba4396d-c0be-4a56-b4ea-0438306eb3be", Search.Typ.Front, Search.Size.Small);

            var ret2 = Search.Release("2ba4396d-c0be-4a56-b4ea-0438306eb3be");

            var ret3 = Search.ReleaseGroup("c31a5e2b-0bf8-32e0-8aeb-ef4ba9973932", Search.Typ.Front);
        }
    }
}
