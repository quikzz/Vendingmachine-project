using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_inlämningsuppgift_csharp.Interfaces;

namespace Test_inlämningsuppgift_csharp.Productclasses
{
    public class Icecoffee : Product, IProduct
    {

        // For information regarding the code, please ready descriptions of product "Candy".


        public override string name => "Ice coffee";

        public override int price => 15;

        public override string description => "Cold caffeinated coffee";


        public override void Buy()
        {
            Console.WriteLine("You have bought ice coffee, enjoy!");
        }

        public override void Description()
        {
            Console.WriteLine("Ice cold coffee with flavour of salted caramel and vanilla");
        }

        public override void Use()
        {
            Console.WriteLine("*Drinking ice coffee... delicious!*");
        }
    }
}
