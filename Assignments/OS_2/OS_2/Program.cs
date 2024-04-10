using System;
using System.IO;


namespace OS_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Waiting for flash device...");
            while (true)
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in drives)
                {
                    if (drive.DriveType == DriveType.Removable)
                    {
                        System.Diagnostics.Process.Start("mspaint.exe");
                        return;
                    }
                }
                System.Threading.Thread.Sleep(1000);
            }

        }
    }
}
