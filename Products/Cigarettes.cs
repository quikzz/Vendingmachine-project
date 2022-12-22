using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_inlämningsuppgift_csharp.Interfaces;

namespace Test_inlämningsuppgift_csharp.Products
{

    // For information regarding the code, please ready descriptions of product "Candy".


    public class Cigarettes : Product, IProduct
        {
        public override string name => "Cigarettes";

        public override int price => 54;

        public override string description => "Roasted blend flavour";


        public override void Buy()
        {
            Console.WriteLine("You have bought cigarettes, enjoy!");
        }

        public override void Description()
        {
            Console.WriteLine("Package of not so healthy cigarettes");
        }

        public override void Use()
        {
            Console.WriteLine("*Smoking... so much that the neighbours calls the fire department*");
        }
    }
}
