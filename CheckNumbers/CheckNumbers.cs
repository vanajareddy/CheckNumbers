using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckNumbersDivBy3And5
{
    class CheckNumbers
    {
        static void Main(string[] args)
        {
            FindNumbersDivisibleBy3And5();
        }

        //The method checks the numbers which are divisible by 3,5 or both and then writes
        // the output to the console.
        public static void FindNumbersDivisibleBy3And5()
        {
            int index;
            int modReminder3;
            int modReminder5;

            for (index = 1; index <= 100; index++)
            {
                //Get the 3 Mod of the number
                modReminder3 = index % 3;

                //Get the 5 Mod of the number
                modReminder5 = index % 5;

                //Check if mod value is 0 for both
                if (modReminder3 == 0 && modReminder5 == 0)
                {
                    Console.WriteLine("ModernMedical");
                }
                //Check if 3 Mod value is 0.
                else if (modReminder3 == 0)
                {
                    Console.WriteLine("Modern");
                }
                //Check if 5 Mod value is 0.
                else if (modReminder5 == 0)
                {
                    Console.WriteLine("Medical");
                }
                // Write the number as it is if the aboe conditions fail
                else
                {
                    Console.WriteLine(index.ToString());
                }
            }
        }
    }
}
