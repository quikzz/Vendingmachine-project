using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_inlämningsuppgift_csharp.Interfaces;

namespace Test_inlämningsuppgift_csharp.Productclasses
{

    // For information regarding the code, please ready descriptions of product "Candy".


    public class Water : Product, IProduct
    {
        public override string name => "Water";

        public override int price => 10;

        public override string description => "Non-carbonated fresh water";



        public override void Buy()
        {
            Console.WriteLine("You have bought a bottle of water, enjoy!");
        }

        public override void Description()
        {
            Console.WriteLine("Thirst quenching water with water flavour :)");
        }

        public override void Use()
        {
            Console.WriteLine("*Drinking water... you feel refreshed*");
        }
    }
}
