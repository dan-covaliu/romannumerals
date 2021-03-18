using System;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            bool success = Int32.TryParse(Console.ReadLine(), out result);
            while (!success) {
                success = Int32.TryParse(Console.ReadLine(), out result);
            }
            string romanNumeral = new RomanNumeralsConverter().Convert(result);
            Console.WriteLine(romanNumeral);
            Console.ReadLine();
        }
    }
}
