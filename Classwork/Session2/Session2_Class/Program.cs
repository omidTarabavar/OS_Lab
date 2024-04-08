using System;
using System.Runtime.InteropServices;
using System.Threading;



namespace Session2_Class
{
    internal class Program
    {
        [Flags]
        public enum MouseEvents
        {
            LeftDown = 0x00000002,
            LeftUp = 0x00000004,
            RightDown = 0x00000008,
            RightUp = 0x00000010
            

        }
        [DllImport("user32.dll")]
        private static extern int mouse_event(int dwFlags, int dxm, int dym, int dwData, int dwExt);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thread.Sleep(1000);
            mouse_event((int)MouseEvents.RightDown, 100,100,0,0);
            mouse_event((int)MouseEvents.RightUp, 500, 500, 0, 0);

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
