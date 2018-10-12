using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_
{
    class Program
    {
        static void Main(string[] args)
        {
            string userNumber, userAnswer;
            int number, i, result;
            bool parsed;

            while (true)
            {
                //Ask user for a number
                Console.WriteLine("Enter a number: ");
                parsed = int.TryParse(Console.ReadLine(), out number);

                //Print out multiplication table for that number 
                //start at 0 end at 12
                for (i = 0; i <= 12; i++)
                {
                    result = i * number;
                    Console.WriteLine(i + " x " + number + " = " + result);
                }

                //Prompt user to continue
                Console.WriteLine(" ");
                Console.WriteLine("Would you like to enter another number? Type N to quit.");
                userAnswer = Console.ReadLine().ToUpper();
                if (userAnswer == "N")
                {
                    break;
                }
            }
        }
    }
}
