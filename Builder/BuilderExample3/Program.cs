using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample3
{
    internal class Program
    {
        /*
         * The Builder Design Pattern seperates the construction of a complex object
         * from its representation so that the same construction process can create 
         * different representations
         * 
         * - Builder (VehicleBuilder)
         *      - specifies an abstract interface for creating parts of a Product object
         *      
         * - ConcreteBuilder (MotorCycleBuilder, CarBuilder, ScooterBuilder)
         *      - constructs and assembles parts of the product by implementing the Builder 
         *        interface
         *      - defines and keeps track of the representation it creates
         *      - provides an interface for retrieving the product
         * - Director (Shop)
         *      - constructs an object using the Builder Interface
         * - Product (Vehicle)
         *      - 
         */
        static void Main(string[] args)
        {
        }
    }
}
