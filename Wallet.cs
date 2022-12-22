using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_inlämningsuppgift_csharp
{
    public class Wallet
    {
        public int Balance { get; set; } // Property for current balance which can be modified by the user.

        private static Wallet instance = new Wallet(); // Creates an new default instance of Wallet.
        public static Wallet Default => instance;

        public void Withdraw(int amount)
        {
            if(amount > Balance) // If the product price exceeds the current wallet balance the program will display a message to user.
            {
                Console.Clear();
                Console.WriteLine("You have insufficent funds..please refill your wallet");
            }
            else
            {
                Balance -= amount; // If there is enough of wallet balance a message will be displayed containing how much totalt balance the user has left and in what values.

                Console.WriteLine($"\nYou have {Balance} kr left");
                Change(Balance);
            }
          

        }
        public void Refill(int amount) 
        {
            Balance += amount; // Method for refilling the wallet balance.
        }
        public void Change(int change)
        {
            int balance;

            // Method which calculates the change that the user gets in return. 

            balance = change / 100;
            Console.WriteLine($"\n100 kr: {balance} st");
            change = change % 100;

            balance = change / 50;
            Console.WriteLine($"50 kr: {balance} st");
            change = change % 50;

            balance = change / 20;
            Console.WriteLine($"20 kr: {balance} st");
            change = change % 20;

            balance = change / 10;
            Console.WriteLine($"10 kr: {balance} st");
            change = change % 10;

            balance = change / 5;
            Console.WriteLine($"5 kr: {balance} st");
            change = change % 5;

            balance = change / 1;
            Console.WriteLine($"1 kr: {balance} st");



        }
        public void WalletMenu()
        {
            // Menu for wallet with options to view balance and refill by calling the refill-metod + entered amount.
            do
            {
                Console.Clear();

                Console.WriteLine("[ MAIN MENU ] > [ WALLET ]");
                Console.WriteLine("\n1. View balance");
                Console.WriteLine("2. Refill balance");
                Console.WriteLine("3. Go back");
                
                switch (int.Parse(Console.ReadLine()))
                {

                    case 1:
                        Console.Clear();
                        Console.WriteLine($"Your balance is: {Balance} kr");
                        Console.WriteLine("\nPress any key to go back");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("How much would you like to add in your wallet");
                        Console.Write("\nEnter amount: ");
                        int input = int.Parse(Console.ReadLine());
                        Refill(input);
                        Console.WriteLine($"\nYour new balance is {Balance} kr");
                        Console.WriteLine("\nPress any key to go back");
                        Console.ReadKey();
                        break;
                    case 3:
                        return;
                }
            }  while(true);
        }
    }

}
