using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_inlämningsuppgift_csharp.Interfaces;

namespace Test_inlämningsuppgift_csharp.Products
{

    // For information regarding the code, please ready descriptions of product "Candy".


    public class Snus : Product, IProduct
    {
        public override string name => "Snus";

        public override int price => 45;

        public override string description => "Pouches with tobacco and nicotine";

     
        public override void Buy()
        {
            Console.WriteLine("You have bought snus, enjoy!");
        }

        public override void Description()
        {
            Console.WriteLine("Pouches with tobacco and nicotine");
        }

        public override void Use()
        {
            Console.WriteLine("*Puts a snus under your lip... and awaits the nicotine kick*");
        }
    }
}
