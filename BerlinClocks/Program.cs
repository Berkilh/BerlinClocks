using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BerlinClocks
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ClockData getClock = new ClockData();
                Console.WriteLine("Please input the time with sample format. \nSample(hh:mm:ss) ");
                var givenTime = Console.ReadLine();
                try
                {

                    DateTime dt = Convert.ToDateTime(givenTime);
                    givenTime = dt.ToString("HH:mm:ss");
                    string[] separetedTimes = givenTime.Split(':');
                    string timeCode = getClock.BerlinClock(Convert.ToInt32(separetedTimes[0]), Convert.ToInt32(separetedTimes[1]), Convert.ToInt32(separetedTimes[2]));
                    Console.WriteLine(timeCode);
                    Console.WriteLine("\nDo you want to continue ? press 'Y' ");
                    
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    Console.WriteLine("\n ");
                    if (keyInfo.Key != ConsoleKey.Y)
                        break; 



                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }




        }
    }
}
