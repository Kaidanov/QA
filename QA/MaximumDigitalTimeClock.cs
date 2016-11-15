using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA
{

    /// My Comments 
    /// Going though 2 out of 4 tests 
    /// have some issues with LINQ getting the default value back
    /// I understand that better way was probably to go through recurtion somehow.
    /// 
    using System.Collections.Generic;
    using System.Linq;

 

    class MaximumDigitalTimeClock
    {



        public string CalculateMaximumDigitalTimeFromDigits(int A, int B, int C, int D)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            List<int> digits = new List<int>(new int[] { A, B, C, D });


            bool flagPossible;
            int firstDigitHour;
            int tryFirstDigit = 2;
            CalculateFirstDigit(digits, out flagPossible, out firstDigitHour,  tryFirstDigit);



            int secondDigitOfHour = CalculateSecondDigitOfHour(digits,  firstDigitHour);

            int tensOfMinutes = digits.Where(n => n >= 0 && n <= 5)
                                            .DefaultIfEmpty(-1)
                                            .Max();

            if (tensOfMinutes != -1)
            {
                digits.Remove(tensOfMinutes);
            }

            if (tensOfMinutes == -1 && (secondDigitOfHour >=0 && secondDigitOfHour <= 5))
            {
                tensOfMinutes = secondDigitOfHour;
                secondDigitOfHour = CalculateSecondDigitOfHour(digits,  firstDigitHour);              
            }

            if (tensOfMinutes == -1 || secondDigitOfHour == -1)
                flagPossible = false;

            int minutes = digits.Where(n => n >= 0 && n <= 9).Max();


            if (flagPossible == false)
                return "NOT POSSIBLE";
            else
                return "" + firstDigitHour + secondDigitOfHour + ":" + tensOfMinutes + minutes;

        }

        private static void CalculateFirstDigit(List<int> digits, out bool flagPossible, out int firstDigitHour,   int tryFirstDigit)
        {

            flagPossible = true;
            int tempMax = tryFirstDigit;
            firstDigitHour = digits.Where(n => n >= 0 && n <= tempMax)
                        .DefaultIfEmpty(-1)
                        .Max();
            if (firstDigitHour == -1)
                flagPossible = false;
            else
                digits.Remove(firstDigitHour);
        }



        private static int CalculateSecondDigitOfHour(List<int> digits, int firstDigitHour)
        {
            int secondDigitOfHour;
            if (firstDigitHour == 0 || firstDigitHour == 1)
            {
                secondDigitOfHour = digits.Where(n => n >= 0 && n <= 9).Max();
            }
            else
            {
                secondDigitOfHour = digits.Where(n => n >= 0 && n <= 3).DefaultIfEmpty(-1).Max();
                if (secondDigitOfHour == -1)
                {                   
                    return secondDigitOfHour;
                }
            }
            digits.Remove(secondDigitOfHour);
            return secondDigitOfHour;
        }

    }
}



