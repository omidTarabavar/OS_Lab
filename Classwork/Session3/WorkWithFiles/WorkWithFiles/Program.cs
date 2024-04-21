using System;
using System.IO;


namespace WorkWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\New folder\s.txt";
            if(!File.Exists(path))
            {
                var f = File.Create(path);
                f.Close();
            }
            string str = "salam\nkhobi?";
            File.WriteAllText(path,str);

            File.AppendAllText(path,"\nchetori?");
            //File.Copy(path,"s24.txt");
            File.Move(path, @"F:\New folder\a.exe");
        }
    }
}
