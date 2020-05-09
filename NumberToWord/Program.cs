using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWord
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellNumberToWord spellObj = new SpellNumberToWord();
            Console.WriteLine("Enter an Whole Number:");
            int enteredNumber;
            try
            {
                while (true)
                {
                    enteredNumber = int.Parse(Console.ReadLine());
                    string numberSpelledToWord = spellObj.SpellTheNumber(enteredNumber);
                    Console.WriteLine(numberSpelledToWord);
                }
            }
            catch
            {
                Console.WriteLine("Warning : Please enter correct number format");
            }
            Console.ReadLine();
        }
    }
}
