using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_inlämningsuppgift_csharp.Interfaces
{
    public interface IProduct
    {
        // Creates an interface which should be the default behavior of every product.
        void Buy(); 
        void Description();
        void Use();
    }
}
