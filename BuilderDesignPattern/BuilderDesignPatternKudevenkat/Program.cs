using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternKudevenkat
{
    class Program
    {
        /*
         * What is Builder Design Pattern
         * Implementation Guidelines
         * Builder Design Pattern In Action
         * 
         * Builder Pattern Belongs to Creational Pattern
         * 
         * Definition : " Seperate the construction of a complex object from its representation so that the same construction process
         *                can create different representations. "
         * 
         * Builder Pattern solves the situation of increasing constructor parameters and constructors of a given class by providing 
         * a step by step initialization of Parameters.After step by step initialization, it returns the resulting constructed object at once.
         * 
         * Same construction process ---> # representations.
         * 
         * Implementation Guiideliness
         * 
         * Choose Builder Pattern When 
         * - We need to break up the construction of a complex object
         * - We need to create a complex object and it should be independednt of the parts that make up the object
         * - The construction process must allow multiple representations of the same class.
         * 
         * Builder Representation 
         * 
         * Director    ------------------------------- Builder
         * +Construct()                                + BuildPart()
         * 
         * 
         * Product ----------------------------------- ConcreteBuilder()
         *                                             +BuildPart() 
         *                                             +GetResult():Product.
         * 
         * 
         * Builder specifies an abstract interface for creating parts of a product object.
         * ConcreteBuilder implements the Builder Interface and provide an interface for getting the product.
         * Director is responsible to construct the object through the builder interface.
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         */
        static void Main(string[] args)
        {
        }
    }
}
