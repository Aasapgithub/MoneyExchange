using System;

namespace MoneyExchange
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //program to exchange money with minimum number of coin possible

            Console.WriteLine("Welcome to Money exchange program!");
            Console.WriteLine("Values per coin, Gold=10, Silver=5 and Bronze=1");
            Console.WriteLine("Please enter amount to exchange:");
            string amount = Console.ReadLine();
            double amt = Convert.ToDouble(amount);
            int gold = 10;
            int silver = 5;

            double gold_coin = Math.Floor(amt / gold);
            double gold_remain = amt % gold;
            double silver_coin = Math.Floor(gold_remain / silver);
            double silver_remain = gold_remain % silver;
    
            Console.WriteLine($"Exchange of {amt} dollar is: ");
            Console.WriteLine($"number of Gold coin: {gold_coin}");
            Console.WriteLine($"number of Silver coin: {silver_coin}");
            Console.WriteLine($"number Bronze coin: {silver_remain}");

            
        }
    }
}
