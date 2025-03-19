using System;                                                       // import System namespace to access input/output functions

namespace Armstrong
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)                                            // loops to keep asking for input
            {
                Console.WriteLine("Enter a number");
                Console.Write("-> ");
                int num = int.Parse(Console.ReadLine());            // read user input like scanner/scanf and int.Parse number converted to integer

                int origNum = num;                                  // store original number for comparison
                int digCount = 0;                                   // store how many digits the number has
                int sum = 0;                                        // store sum of the powered digits

                int temp = num;                                     // temporary variable to process the number
                while (temp > 0)                                    // loops until temp become 0
                {
                    temp /= 10;                                     // remove last digit
                    digCount++;
                }

                temp = num;                                         // reset temp to original number

                while (temp > 0)                                    // loops until temp becomes 0
                {
                    int digit = temp % 10;                          // extract last digit number
                    int power = 1;                                  // store result of digit^digCount

                    for (int i = 0; i < digCount; i++)
                    {
                        power *= digit;                             // multiply digit by itself digCount times
                    }

                    sum += power;
                    temp /= 10;                                     // remove last digit
                }

                if (sum == origNum)
                {
                    Console.Write(origNum + " is");
                    Console.ForegroundColor = ConsoleColor.Green;   // add text color
                    Console.WriteLine(" an Armstrong number.\n");
                    Console.ResetColor();                           // reset text color for next line
                }
                else
                {
                    Console.Write(origNum + " is");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" not an Armstrong number.\n");
                    Console.ResetColor();
                }
            }
        }
    }
}
