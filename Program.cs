using System.Threading.Channels;
using System.Transactions;

namespace Demo_Revision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int YearOfBirth = 0;
            int Age = 0;

            Console.WriteLine("Enter your Year of Birth please...");
            string input = Console.ReadLine();
            YearOfBirth = int.Parse(input);

            const int CurrentYear = 2023;

            Age = CurrentYear - YearOfBirth;

            Console.WriteLine($"Your age is {Age}");

        }
    }
}