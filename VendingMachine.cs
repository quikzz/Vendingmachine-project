using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_inlämningsuppgift_csharp.Interfaces;
using Test_inlämningsuppgift_csharp.Productclasses;
using Test_inlämningsuppgift_csharp.Products;

namespace Test_inlämningsuppgift_csharp
{
    public class VendingMachine
    {
       


        public static void ShowBeverageMenu()
        {
            Console.Clear(); // Clears console to only display this particular menu.

            var Snack = new List<Tuple<string, int>>(); // Creating a tuples list of object properties that is going to be displayed.
            Snack.Add(new Tuple<string, int>(new Soda().name, new Soda().price));
            Snack.Add(new Tuple<string, int>(new Energydrink().name, new Energydrink().price));
            Snack.Add(new Tuple<string, int>(new Icecoffee().name, new Icecoffee().price));
            Snack.Add(new Tuple<string, int>(new Water().name, new Water().price));


            var index = 1; // Number indicator for menu options.

            Console.WriteLine("[MAIN MENU] > [BEVERAGES]\n");

            foreach (var item in Snack) // Writing out each objekt with an index indicator by using a loop.
            {
                Console.WriteLine($"{index}. {item.Item1} - {item.Item2} kr");
                index++;
            }
            Console.WriteLine("\n5. Go back to main menu");
        }
        public static void ShowSnackMenu()
        {
            Console.Clear(); // Clears console to only display this particular menu.

            var Snack = new List<Tuple<string, int>>(); // Clears console to only display this particular menu.
            Snack.Add(new Tuple<string, int>(new Snackbar().name, new Snackbar().price)); 
            Snack.Add(new Tuple<string, int>(new Candy().name, new Candy().price));
            Snack.Add(new Tuple<string, int>(new Chips().name, new Chips().price));
            Snack.Add(new Tuple<string, int>(new Chewinggum().name, new Chewinggum().price));

            var index = 1;// Number indicator for menu options.

            Console.WriteLine("[MAIN MENU] > [SNACK]\n");

            foreach (var item in Snack) // Writing out each objekt with an index indicator by using a loop.
            {
                Console.WriteLine($"{index}. {item.Item1} - {item.Item2} kr");
                index++;
            }
            Console.WriteLine("\n5. Go back to main menu");
        }
        public static void ShowTobaccoMenu()
        {
            // Creates a list of tuples that fetches property name and price, this will later be printed out.
            var Tobacco = new List<Tuple<string, int>>();
            Tobacco.Add(new Tuple<string, int>(new Cigarettes().name, new Cigarettes().price));
            Tobacco.Add(new Tuple<string, int>(new Snus().name, new Snus().price));
            Tobacco.Add(new Tuple<string, int>(new Nicotinegum().name, new Nicotinegum().price));

            var index = 1; // Number indicator for menu options.
            Console.WriteLine("[MAIN MENU] > [TOBACCO]\n");

            // Prints out tuples list of Tobacco products with fetched names and prices properties from each class
            foreach (var item in Tobacco)
            {
                Console.WriteLine($"{index}. {item.Item1} - {item.Item2} kr");
                index++;
            }
            Console.WriteLine("\n4. Go back to main menu");

        }
        public static void BeveragesMenu()
        {
            int input;

            do//while loop which lets user decides which object (product) which should be displayed.
            {
                Console.Clear();

                ShowBeverageMenu(); // Prints out menu for the specific category.

                Energydrink energydrink = new Energydrink(); // Creates new objects of the products connected to the category.
                Icecoffee icecoffee = new Icecoffee();
                Water water = new Water();
                Soda soda = new Soda();


                input = int.Parse(Console.ReadLine()); // Reads input from user.

                switch (input)
                {
                    case 1:
                        Console.Clear();
                        Options(soda);
                        break;
                    case 2:
                        Console.Clear();
                        Options(energydrink);
                        break;
                    case 3:
                        Console.Clear();
                        Options(icecoffee);
                        break;
                    case 4:
                        Console.Clear();
                        Options(water);
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Option does not exists");
                        break;
                }
            } while (input != 5);
        }
        public static void SnackMenu()
        {
            int input;

            do//while loop which lets user decides which object (product) which should be displayed.
            {
                Console.Clear();

                ShowSnackMenu(); // Prints out menu for the specific category 

                Snackbar snackbar = new Snackbar(); // Creates new objects of the products connected to the category
                Candy candy = new Candy();
                Chips chips = new Chips();
                Chewinggum chewinggum = new Chewinggum();

                input = int.Parse(Console.ReadLine()); // Reads input from user.

                switch (input)
                {
                    case 1:
                        Console.Clear();
                        Options(snackbar);
                        break;
                    case 2:
                        Console.Clear();
                        Options(candy);
                        break;
                    case 3:
                        Console.Clear();
                        Options(chips);
                        break;
                    case 4:
                        Console.Clear();
                        Options(chewinggum);
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Option does not exists");
                        break;
                }
            } while (input != 5);
        }
        public static void TobaccoMenu()
        {
            int input;
           
            do//while loop which lets user decides which object (product) which should be displayed.
            {
                Console.Clear();

                ShowTobaccoMenu(); // Prints out menu for the specific category 

                Cigarettes cigarettes = new Cigarettes(); // Creates new objects of the products connected to the category
                Snus snus = new Snus();
                Nicotinegum nicotinegum = new Nicotinegum();

                input = int.Parse(Console.ReadLine()); // Reads input from user.

                switch (input)
                {
                    case 1:
                        Console.Clear();
                        Options(cigarettes);
                        break;
                    case 2:
                        Console.Clear();
                        Options(snus);
                        break;
                    case 3:
                        Console.Clear();
                        Options(nicotinegum);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Option does not exists");
                        break;
                }

            } while (input != 4);
   
        }
        public static void MainMenu()
        {
            
            int input;
            do
            {
                Console.Clear();

                Console.WriteLine("[ MAIN MENU ]\n"); // Prints out main menu and main menu options.
                Console.WriteLine("Choose from the menu below by pressing one of the following numbers\n");
                Console.WriteLine("1. Beverages");
                Console.WriteLine("2. Snack");
                Console.WriteLine("3. Tobacco");
                Console.WriteLine("4. Wallet");
                Console.WriteLine("5. Quit");

                input = int.Parse(Console.ReadLine()); // Reads input from user.

                switch (input) // Switch case-statement which lets the user access products from the different menus by calling the methods.
                {
                    case 1:
                        Console.Clear();
                        BeveragesMenu();
                        break;
                    case 2:
                        Console.Clear();
                        SnackMenu();
                        break;
                    case 3:
                        Console.Clear();
                        TobaccoMenu();
                        break;
                    case 4:
                        Wallet.Default.WalletMenu();
                        break;
                    case 5:
                        break;

                    default:
                        Console.WriteLine("Option does not exists");
                        break;
                }
            } while (input != 5);   
        }
        public static void AskToBuy(Product produkt)
        {
            int input;
            do
            {
                Console.Clear();

                Console.WriteLine($"Do you want to buy {produkt.name}"); // Asks user if it wants to buy product + property of the product.
                Console.WriteLine("\n1. YES - Buy product");
                Console.WriteLine("2. NO - Go back");

                input = int.Parse(Console.ReadLine()); // Reads input from user.

                switch (input)
                {

                    case 1: // If input is 1. Yes - call method buy in the specific product. 
                            // 2. No - go back to main menu.
                        Console.Clear();
                        produkt.Buy();
                        if (Wallet.Default.Balance < produkt.price) // Program runs a control if there is enough money, if not, the user has to refill wallet.
                        {
                            Wallet.Default.Withdraw(produkt.price);
                            Console.WriteLine("\nPress any key to go back");
                            Console.ReadKey();
                            return;
                        }
                        else
                        {
                            Wallet.Default.Withdraw(produkt.price);
                            Console.WriteLine($"\nPress any key to use {produkt.name}");
                            Console.ReadKey();
                            Console.Clear();
                            produkt.Use();
                            Console.WriteLine("\nPress any key to go back");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        break;
                    default:
                        Console.WriteLine("Option does not exist");
                        break;
                }
            } while (input != 2);
            

        }
        public static void Options(Product produkt)
        {

            int input;

            do
            {
                Console.Clear();

                Console.WriteLine($"{produkt.name} - {produkt.description}"); // Writes out which product the user has chosen and also an small description.

                Console.WriteLine("\n1. Buy");
                Console.WriteLine("2. Description");
                Console.WriteLine("3. Go back");

                input = int.Parse(Console.ReadLine());

                switch (input) // Gives the user the option of buying product or viewing description and go back to main menu.
                {
                    case 1:
                        Console.Clear();
                        AskToBuy(produkt); // If user chooses to buy the product method AskToBuy is called.
                        break;
                    case 2:
                        Console.Clear();
                        produkt.Description(); // Else view description
                        Console.WriteLine($"\nPress any key to go back..");
                        Console.ReadKey();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Option does not exists");
                        break;
                }
            } while (input != 3);
        }
    }
}
