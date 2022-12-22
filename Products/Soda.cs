using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_inlämningsuppgift_csharp.Interfaces;

namespace Test_inlämningsuppgift_csharp.Productclasses
{

    // For information regarding the code, please ready descriptions of product "Candy".


    public class Soda : Product, IProduct
    {
        public override string name => "Soda";

        public override int price => 10;

        public override string description => "Thrist quenching soda";

        public override void Buy()
        {
            Console.WriteLine("You have bought ice coffee, enjoy!");
        }

        public override void Description()
        {
            Console.WriteLine("Thirst quenching soda with raspberry flavour");
        }

        public override void Use()
        {
            Console.WriteLine("*Drinking soda... sugar rush is flowing through your body*");
        }
    }
}
