using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
namespace OS_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _ = a_wait();
            Console.ReadKey();
        }
        static async Task a_wait()
        {
            await GetData();
        }

        static async Task GetData()
        {
            using (HttpClient ht = new HttpClient())
            {
                try
                {
                    string url = "https://jsonplaceholder.typicode.com/posts/1";
                    HttpResponseMessage hrm = await ht.GetAsync(url);
                    if (hrm.IsSuccessStatusCode)
                    {
                        string msg = await hrm.Content.ReadAsStringAsync();
                        Console.WriteLine(msg);
                    }
                    else
                    {
                        Console.WriteLine("Failed:" + hrm.StatusCode);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("err:" + ex.Message);
                }
            }
        }

        static void do1()
        {
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("th1 : " + i);
                Thread.Sleep(1000);

            }
        }

        static void do2()
        {
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("th2 : " + i);
                Thread.Sleep(1500);

            }
        }


        static void f()
        {
            int[] ar = { 5, 6, 7, 8, 9 };
            DateTime start = DateTime.Now;
            foreach (int a in ar)
            {
                Task.Run(() =>
                {
                    Console.WriteLine($"factoriel of {a} is {factoriel(a)}");
                });
            }
            Console.WriteLine($"Time Elapsed: {DateTime.Now.Subtract(start)}");
            Console.ReadKey();
        }

        static long factoriel(int x)
        {
            if (x == 1) return 1;
            return x * factoriel(x - 1);
        }
    }
}