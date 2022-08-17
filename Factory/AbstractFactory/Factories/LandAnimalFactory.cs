using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    /*
     * Step 4 : Create Concrete Factory 
     * 
     * This is a class that implements the Abstract Factory (Animal Factory) class. In our
     * example, this class is going to implement the GetAnimal method of the Animal Factory
     * class. There are two types of concrete abstract factories in our example i.e 
     * LandAnimalFactory and Sea AnimalFactory.
     * As you can see the GetAnimal method creates and returns the appropriate Land Animal
     * object(i.e. Dog, Cat, and Lion) based on the input parameter i.e AnimalType is received
     * Similarly , create another class file with the name SeaAnimalFactory.cs
     */
    public class LandAnimalFactory : AnimalFactory
    {
        public override Animal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Dog"))
            {
                return new Dog();
            }
            else if (AnimalType.Equals("Cat"))
            {
                return new Cat();
            }
            else if (AnimalType.Equals("Lion"))
            {
                return new Lion();
            }
            else
            {
                return null;
            }
        }
    }
}
