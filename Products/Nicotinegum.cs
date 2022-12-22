using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_inlämningsuppgift_csharp.Interfaces;

namespace Test_inlämningsuppgift_csharp.Products
{
    public class Nicotinegum : Product, IProduct
    {

        // For information regarding the code, please ready descriptions of product "Candy".


        public override string name => "Nicotine gum";

        public override int price => 50;

        public override string description => "Nicotine gums with mint flavour";


        public override void Buy()
        {
            Console.WriteLine("You have bought nicotine gums, enjoy!");
        }

        public override void Description()
        {
            Console.WriteLine("Nicotine gums with mint flavour");
        }

        public override void Use()
        {
            Console.WriteLine("*Chewing the gum... with hopes of becoming less addicted to nicotine*");
        }
    }
}
