using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_inlämningsuppgift_csharp.Interfaces;

namespace Test_inlämningsuppgift_csharp.Productclasses
{


    // For information regarding the code, please ready descriptions of product "Candy".


    public class Chewinggum : Product, IProduct
    {
        public override string name => "Chewing gum";
        public override int price => 13;
        public override string description => "Spearmint flavoured chewing gums";

     
        public override void Buy()
        {
            Console.WriteLine("You have bought chewing gums, enjoy!");
        }

        public override void Description()
        {
            Console.WriteLine("Chewing gums with a refreshing taste of spearmint");
        }

        public override void Use()
        {
            Console.WriteLine("*Chewing gums ... until I can't feel my jaw anymore*");
        }
    }
}
