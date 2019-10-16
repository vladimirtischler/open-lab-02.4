using System;

namespace ConsoleApp2
{
    
    class Program
    {
        public static int GetLegsCount(int cows, int chicken, int pigs)
        {
            return (cows * 4 + chicken * 2 + pigs * 4);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count of cows!");
            int cows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the count of chickens!");
            int chickens = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the count of pigs!");
            int pigs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The count of legs on the farm is {(GetLegsCount(cows, chickens,pigs))}.");
        }
    }
}
