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
            connection = new ScannerConnection();

            bool exportConfig = false;

            BeginWaitingForUserExit();

            if (exportConfig)
            {
                connection.ExportCidConfiguration();
            }
            else
            {
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
