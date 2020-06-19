using ScannerConnector;
using System;
using System.Threading;

namespace KepCidScannerConnectorApp
{
    class Program
    {

        private static Thread WaitForUserQuitThread;
        private static ScannerConnection connection;

        static void Main(string[] args)
        {

            // To export the configuration XML file, set this to true and run the application once.
            // The xml file will be in the bin/debug folder
            bool exportConfig = false;

            connection = new ScannerConnection();
            

            if (exportConfig)
            {
                connection.ExportCidConfiguration();
                Thread.Sleep(2000);
            }
            else
            {
                BeginWaitingForUserExit();
                connection.Run();
            }

            
        }




        private static void BeginWaitingForUserExit()
        {

            WaitForUserQuitThread = new Thread((o) =>
            {
                Console.WriteLine("Press 'q' to quit");
                bool retry = true;
                do
                {
                    var pressed = Console.ReadKey();

                    retry = !(pressed.KeyChar == 'q' || pressed.KeyChar == 'Q');
                } while (retry);

                connection.Stop();

            });


            WaitForUserQuitThread.IsBackground = true;
            WaitForUserQuitThread.Name = "WaitForUserQuitThread";
            WaitForUserQuitThread.Start();
        }

    }
}
