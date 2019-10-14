using System;

namespace open_lab_02._4
{
    class Program
    {
        public static int GetLegsCount(int chickens, int cows, int pigs)
        {
            return (chickens + cows + pigs);
        }
        static void Main(string[] args)
        {
            int chickenlegs = 2;
            int cowslegs = 4;
            int pigslegs = 4;
            Console.WriteLine(GetLegsCount(chickenlegs, cowslegs, pigslegs));
        }
    }
}
