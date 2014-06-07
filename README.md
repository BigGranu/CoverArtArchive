CoverArtArchive
===============

C# data bindings for the CoverArtArchive.

Example:

// Get Covers of a release 
Covers covers = CoverArtArchive.Release.Get.Cover("76df3287-6cda-33eb-8e9a-044b5e15ffdd");

// Get Covers of a release-group 
Covers rgCovers = CoverArtArchive.Release_Group.Get.Cover("c31a5e2b-0bf8-32e0-8aeb-ef4ba9973932");
