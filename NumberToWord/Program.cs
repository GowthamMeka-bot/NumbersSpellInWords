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
            Console.WriteLine("Enter an Whole Number:");
            int enteredNumber = int.Parse(Console.ReadLine());
            string numberSpelledToWord = SpellNumberToWord.SpellTheNumber(enteredNumber);
            Console.WriteLine(numberSpelledToWord);
            Console.ReadLine();
        }
    }
}
