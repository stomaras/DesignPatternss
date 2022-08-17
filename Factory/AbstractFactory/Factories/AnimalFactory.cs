using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    /*
     * AbstractFactory declares an interface for operations that will create AbstractProduct
     * objects. In our example, it is going to be AnimalFactory. Contains two methods.
     * The GetAnimal method is an abstract method that is going to be implemented by the 
     * child factory classes. The CreateAnimalFactory method takes an input parameter 
     * i.e factory type and then creates and returns the appropriate factory object to the 
     * caller.
     * 
     */
    public abstract class AnimalFactory
    {
        public abstract Animal GetAnimal(string AnimalType);

        public static AnimalFactory CreateAnimalFactory(string factoryType)
        {
            if (factoryType.Equals("Sea"))
            {
                return new SeaAnimalFactory();
            }
            else
            {
                return new LandAnimalFactory();
            }
        }
    }
}
