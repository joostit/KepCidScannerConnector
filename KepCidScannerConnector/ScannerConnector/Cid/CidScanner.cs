using KepServer.CidLib;
using KepServer.CidLib.Tags;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScannerConnector
{
    class CidScanner
    {

        private CidConnector cidConnector;

        public TagsCollection Tags { get; private set; }

        public StringTag ErrorMessageTag { get; private set; }

        public StringArrayTag ShapeListTag { get; private set; }

        public CidScanner()
        {
            CreateTags();
            HookUpEvents();
        }



        private void CreateTags()
        {
            Tags = new TagsCollection();

            // Instantiate the tag properties here
            ErrorMessageTag = new StringTag("ErrorMessage", "The error message when available", 150);
            ShapeListTag = new StringArrayTag("ShapeList", 30, "The shape list when available", 100);

            // Create the device and add the tags
            Tags.AddDevice("3ShapeScanner", "The 3Shape scanner")
                .AddTag(ErrorMessageTag)
                .AddTag(ShapeListTag);

        }

        internal void Stop()
        {
            cidConnector.Stop();
        }

        public void Run()
        {
            cidConnector = new CidConnector();
            cidConnector.Start(Tags);
        }


        private void HookUpEvents()
        {
            
        }
    }
}
