using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab10
{
    public class Validation
    {

        public static string ValidateInput(string Word)
        {

            while (Regex.IsMatch(Word, @"^[A-z\ ]+$") != true)
            {
                Console.WriteLine("You did not enter a valid word. Please make sure your selection matches a category from the list.");
                Word = Console.ReadLine();
            }
            return Word;
        }
        public static string ValidateYesNo(string Word)
        {
            while (!Regex.IsMatch(Word, @"[YyNn]"))
            {
                Console.WriteLine("You did not enter 'Y' or 'N'. Please try again.");
                Word = Console.ReadLine();
            }
            return Word;
        }

        public static int ValidateInteger(string Input)
        {
            int Answer = 0;
            bool Repeat = true;

            while (Repeat == true)
            {
                while (int.TryParse(Input, out int Result) != true)
                {
                    Console.WriteLine("You did not enter a valid number choice. Please try again.");
                    Input = Console.ReadLine();
                }

                Answer = int.Parse(Input);
                if (Answer > -1)
                {
                    Repeat = false;
                }
                else
                {
                    Console.WriteLine("Your number cannot be negative. Please try again.");
                }
            }
            return Answer;
        }
    }
}
