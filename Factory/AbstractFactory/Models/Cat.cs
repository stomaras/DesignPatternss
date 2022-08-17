using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /*
     * Step 2: Creating Concrete Product
     * This is a class that implements the Abstract Factory interface(in our case animal)
     * to create concrete products.In our example, the Product classes are Cat, Lion, Dog
     * 
     */
    public class Cat : Animal
    {
        public string speak()
        {
            return "Meow Meow Meow";
        }
    }
}
