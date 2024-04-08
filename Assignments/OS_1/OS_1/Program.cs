using System;
using System.Diagnostics;
using System.Management;

// Omid Tarabavar

namespace OS_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inp = 0;
            do
            {
                menu();
                inp = int.Parse(Console.ReadLine());

                switch (inp)
                {
                    case 1:
                        startProc();
                        break;
                    case 2:
                        listProc();
                        break;
                    case 3:
                        killProc();
                        break;
                    case 4:
                        getParent();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("\nEnter a valid number!\n");
                        break;
                }

            } while (inp != 5);

        }

        static void menu()
        {
            Console.WriteLine("\n1- Start a process");
            Console.WriteLine("2- List of processes");
            Console.WriteLine("3- Kill a process");
            Console.WriteLine("4- Get parent");
            Console.WriteLine("5- Quit");
            Console.Write("\nChoose a number: ");
        }

        static void startProc()
        {
            Console.Write("\nEnter the name of your process: ");
            string pName = Console.ReadLine();
            try
            {
                Process.Start(pName);
            }
            catch (Exception e)
            {
                Console.WriteLine("Process not found!");
            }
        }

        static Process[] getProcList()
        {
            return Process.GetProcesses();
        }

        static void listProc()
        {
            Console.WriteLine();
            Process[] pList = getProcList();
            foreach (Process p in pList)
            {
                Console.WriteLine(p.Id + "\t" + p.ProcessName);
            }
            Console.WriteLine();
        }

        static Process getProcessById(int id)
        {
            Process[] pList = getProcList();
            foreach (Process p in pList)
            {
                if (p.Id == id)
                    return p;
            }
            return null;
        }

        static void killProc()
        {
            Console.Write("Enter process id: ");
            int pid = int.Parse(Console.ReadLine());
            Process p = getProcessById(pid);
            if (p != null)
                p.Kill();
            else
                Console.WriteLine("Process not found!");

        }

        static void getParent()
        {
            Console.Write("Enter process id: ");
            int pid = int.Parse(Console.ReadLine());
            Process p = getProcessById(pid);
            if (p != null)
            {
                int parentPid = 0;

                try
                {
                    using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Process WHERE ProcessId=" + pid))
                    {
                        foreach (ManagementObject queryObj in searcher.Get())
                        {
                            parentPid = Convert.ToInt32(queryObj["ParentProcessId"]);
                            break;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nError getting parent pid!\n");
                }

                Console.WriteLine("Parent: " + parentPid + "\t" + getProcessById(parentPid).ProcessName);

            }
            else { Console.WriteLine("Process not found!"); }
        }
    }
}


