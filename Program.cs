using System;

namespace Iterative_Statements
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter an integer between 2 and 10: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                for (int i = 0; i < num + 1; i++)
                    Console.WriteLine("{0}. You entered an even number.", i + 1);
            }
            else
            {
                for (int i = 0; i < num - 1; i++)
                    Console.WriteLine("{0}. You entered an odd number.", i + 1);
            }
        }
    }
}
