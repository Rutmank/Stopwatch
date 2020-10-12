using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec;
            int min = 0;
            int hour = 0;

            for (sec = 1; ; sec++)
            {
                if (sec % 60 == 0)
                {
                    sec = 0;
                    min++;
                    Console.WriteLine("Время: " + hour + ":" + min + ":" + sec);
                    System.Threading.Thread.Sleep(1000);

                    if (min % 60 == 0)
                    {
                        min = 0;
                        hour++;
                        Console.WriteLine("Время: " + hour + ":" + min + ":" + sec);
                        System.Threading.Thread.Sleep(1000);

                    }
                }
                else
                {
                    Console.WriteLine("Время: " + hour + ":" + min + ":" + sec);
                    System.Threading.Thread.Sleep(1000);
                }
            }
            Console.ReadLine();
        }
    }
}
