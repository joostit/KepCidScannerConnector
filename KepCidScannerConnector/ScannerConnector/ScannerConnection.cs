using KepServer.CidLib;
using ScannerConnector.Http.Xml.Response;
using System;
using System.Threading;

namespace ScannerConnector
{
    public class ScannerConnection
    {
        // Change this according to the actual URL, or better yet: make configurable.
        // Note: Add this in the form of "http://domain:port" (Without trailing '/')
        private const string scannerBaseUrl = @"http://192.168.178.41:8735";

        private volatile bool continueRunning = true;
        private CidScanner cidScanner;
        private HttpScanner httpScanner;


        public void Run()
        {
            cidScanner = new CidScanner();
            cidScanner.Run();

            httpScanner = new HttpScanner(scannerBaseUrl);

            Thread.Sleep(2000);    // QAD Give the CUD system some time to initialize
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

            OrderInterface scannerResponse;

            while (continueRunning)
            {

                // Read stuff from the scanner through REST
                scannerResponse = httpScanner.GetStatus();


                // Write that stuff to the Kepware tags
                if (scannerResponse.ErrorSpecified)
                {
                    cidScanner.ErrorMessageTag.Value = scannerResponse.Message;
                }
                else
                {
                    cidScanner.ErrorMessageTag.Value = "OK";
                }

                // **
                // Just for demo purposes remove the error line for a few seconds before trying again
                // **
                Thread.Sleep(3000);
                cidScanner.ErrorMessageTag.Value = "Will try again in a few seconds" + (char) 0;
                // **
                // END of demo code
                //***

                // Read kepware tags if they contain a command for the scanner

                // Send those commands to the scanner

                // Sleep. Because otherwise we'll keep the CPU busy for 100%
                Thread.Sleep(3000);
            }
        }



        public void Stop()
        {
            continueRunning = false;
        }


    }
}
