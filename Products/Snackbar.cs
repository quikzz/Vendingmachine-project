using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_inlämningsuppgift_csharp.Interfaces;

namespace Test_inlämningsuppgift_csharp.Productclasses
{

    // For information regarding the code, please ready descriptions of product "Candy".


    public class Snackbar : Product, IProduct
    {
        public override string name => "Snackbar";

        public override int price => 8;

        public override string description => "Not so healthy but delicious snackbar";

  

        public override void Buy()
        {
            Console.WriteLine("You have bought a snackbar, enjoy!");
        }

        public override void Description()
        {
            Console.WriteLine("Chocolate snackbar with peanuts and caramel");
        }

        public override void Use()
        {
            Console.WriteLine("*Eating chips... and trying not to think of the calories*");
        }
    }
}
