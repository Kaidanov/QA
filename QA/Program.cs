using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ///testing clock
            MaximumDigitalTimeClock c = new MaximumDigitalTimeClock();
            Console.WriteLine("2, 4, 0, 0 => " + c.CalculateMaximumDigitalTimeFromDigits(2, 4, 0, 0));
            Console.WriteLine("3, 7, 0, 7 => " + c.CalculateMaximumDigitalTimeFromDigits(3, 7, 0, 7));
            Console.WriteLine("9, 1, 9, 7 => " + c.CalculateMaximumDigitalTimeFromDigits(9, 1, 9, 7));
            Console.WriteLine("2, 2, 9, 9 => " + c.CalculateMaximumDigitalTimeFromDigits(2, 2, 9, 9));
            Console.WriteLine("0,0,1,1 =>" + c.CalculateMaximumDigitalTimeFromDigits(0, 0, 1, 1));
            Console.WriteLine("9,5,3,2 =>" + c.CalculateMaximumDigitalTimeFromDigits(9, 5, 3, 2));
            Console.WriteLine("0,0,0,1 =>" + c.CalculateMaximumDigitalTimeFromDigits(0, 0, 0, 1));
            Console.WriteLine("2,2,2,2 =>" + c.CalculateMaximumDigitalTimeFromDigits(2, 2, 2, 2));
            Console.WriteLine("3,2,3,3 =>" + c.CalculateMaximumDigitalTimeFromDigits(3, 2, 3, 3));
            Console.WriteLine("3,3,3,3 =>" + c.CalculateMaximumDigitalTimeFromDigits(3, 3, 3, 3));
            Console.WriteLine("0,7,0,0 =>" + c.CalculateMaximumDigitalTimeFromDigits(0, 7, 0, 0));
            Console.WriteLine("0,7,2,1 =>" + c.CalculateMaximumDigitalTimeFromDigits(0, 7, 2, 1));
            Console.ReadKey();
        }
    }
}
