using System;

namespace PatternofStrings
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string input = Console.ReadLine();
            int x = input.Length-1;

            do
            {
                for (int i = 0; i < x; i++)
                {
                    Console.Write(input[i]);
                }
                Console.WriteLine();
                x--;
            } while (x !=0);
            int y = x+2;
            do
            {
                for (int i = 0; i < y; i++)
                {
                    Console.Write(input[i]);
                }
                Console.WriteLine();
                y++;
            } while (y <= input.Length);


        }
    }
}
