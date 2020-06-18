using KepServer.CidLib;
using System;
using System.Threading;

namespace ScannerConnector
{
    public class ScannerConnection
    {
        // Change this according to the actual URL, or better yet: make configurable
        private const string scannerUrl = @"http://192.168.178.41:8735/WSIQueryService/ProcessCommandsViaGet";

        private volatile bool continueRunning = true;
        private CidScanner cidScanner;
        private HttpScanner httpScanner;


        public void Run()
        {
            cidScanner = new CidScanner();
            httpScanner = new HttpScanner(scannerUrl);

            RunUpdateLoop();

            CloseConnections();
        }


        private void CloseConnections()
        {
            cidScanner.Stop();
        }



        public void ExportCidConfiguration()
        {
            if (cidScanner != null)
            {
                throw new InvalidOperationException("Exporting the configuration should be a stand-alone opperation and cannot be combined with running the Cid connection.");
            }

            CidConnector cidConnector = new CidConnector();
            cidScanner = new CidScanner();
            cidConnector.ExportConfiguration(cidScanner.Tags);

            cidScanner = null;
            cidConnector.Stop();
            cidConnector = null;
        }



        private void RunUpdateLoop()
        {

            httpScanner.GetStatus();

            while (continueRunning)
            {
                // Read stuff from the scanner through REST

                // Write that stuff to the Kepware tags

                // Read kepware tags if they contain a command for the scanner

                // Send those commands to the scanner

                // Sleep. Because otherwise we'll keep the CPU busy for 100%
                Thread.Sleep(5000);
            }
        }



        public void Stop()
        {
            continueRunning = false;
        }


    }
}
