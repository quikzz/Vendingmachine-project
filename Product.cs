using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_inlämningsuppgift_csharp.Interfaces;
using Test_inlämningsuppgift_csharp.Products;

namespace Test_inlämningsuppgift_csharp
{
    public abstract class Product : IProduct
    {
        // Sets the properties of a product.
        public abstract string name { get; } 
        public abstract int price { get; }
        public abstract string description { get; }

        //Inherits the behavior from the interface, this is for now not implemented thus it will be inside each unique product class.
        public abstract void Buy();
        public abstract void Description();
        public abstract void Use();
    }
}
