using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.DateTime;

namespace ConditionalLabTimeClass
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime currentTime =  DateTime.UtcNow;
            int seconds =Convert.ToInt32( currentTime.ToString("ss"));
            Console.WriteLine(seconds);
            //Console.WriteLine(currentTime.ToString(":ss"));

            switch (seconds)
            {
                case 0:
                    Console.WriteLine("The New Minute is just Beginning");
                    break;
                case 15:
                    Console.WriteLine("We're one quarter done");
                    break;
                case 30:
                    Console.WriteLine("half way there");
                    break;
                case 45:
                    Console.WriteLine("Getting close to done");
                    break;

                default:
                    Console.WriteLine("Working on it");
                    break;
            }
        }
    }
}
