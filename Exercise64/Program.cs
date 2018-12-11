using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise64
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number:  ");
                string userInput = Console.ReadLine();
                var newValidator = new Validator();
                
                if (newValidator.IsInt(userInput))
                {
                    Console.WriteLine($"{userInput} can be parse as an integer");
                }
                else if (!newValidator.IsInt(userInput))
                {
                    Console.WriteLine($"{userInput} cannot be parses as an integer.");
                    continue;
                }

                Console.Write("Would you like to continue(y/n): ");
                char continueInput = Console.ReadKey().KeyChar;
                
                if (continueInput.ToString().ToLower() == "y" )
                {
                    Console.WriteLine();
                    continue;
                }
                if (continueInput.ToString().ToLower() == "n")
                {
                    Console.WriteLine(Environment.NewLine + "Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine(Environment.NewLine + "Invalid Entry");
                    break;
                }

            }
            

            Console.ReadKey();
        }
    }

    class Validator
    {

        public bool IsInt(string userInput)
        {
            if (int.TryParse(userInput, out int numberValid) )
            {
                return true;
            }

            return false;
        }

    }
}
