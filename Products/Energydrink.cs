using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Test_inlämningsuppgift_csharp.Interfaces;

namespace Test_inlämningsuppgift_csharp.Productclasses
{

    // For information regarding the code, please ready descriptions of product "Candy".


    public class Energydrink : Product, IProduct
    {
      
        public override string name => "Energy drink";
        public override int price => 15;
        public override string description => "Carbonated drink with caffeine";

        public override void Buy()
        {
            Console.WriteLine("You have bought an Energy drink!");
        }

        public override void Description()
        {
            Console.WriteLine("You dont want to know what it contains... :)");
        }

        public override void Use()
        {
            Console.WriteLine("*Drinking energy drink... you can feel the energy level rising*");
        }
    }
}
