using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_inlämningsuppgift_csharp.Interfaces;

namespace Test_inlämningsuppgift_csharp.Productclasses
{

    // For information regarding the code, please ready descriptions of product "Candy".


    public class Chips : Product, IProduct
    {
        public override string name => "Chips";
        public override int price => 15;
        public override string description => "Crispy chips with sourcream and onion flavour";
       

        public override void Buy()
        {
            Console.WriteLine("You have bought chips, enjoy!");
        }

        public override void Description()
        {
            Console.WriteLine("Crispy chips with sourcream and onion flavour");
        }

        public override void Use()
        {
            Console.WriteLine("*Eating chips... omnomnom*");
        }
    }
}
