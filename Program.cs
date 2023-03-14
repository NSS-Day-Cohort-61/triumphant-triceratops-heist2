using System;

namespace Heist_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank theBank = new Bank
            {
                CashOnHand = 40,
                AlarmScore = 20,
                VaultScore = 10,
                SecurityGuardScore = 15
            };
            
            System.Console.WriteLine("Welcome to the Heist");

            
        }
    }
}
