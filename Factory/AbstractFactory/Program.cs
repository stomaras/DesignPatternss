using AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        /*
         * The Abstract Factory Design Pattern provides a way to encapsulate 
         * a group of individual factories that have a common theme without 
         * specifying their concrete classes.
         * In simple words we can say, that the Abstract Factory is a super factory 
         * that creates other factories. The Abstract Factory is also called the 
         * Factory of Factories.
         * 
         * Let's say we have three classes Cat, Lion, Dog. And these three classes 
         * are the subclasses of Animal superclass or super interface. The Animal 
         * superclass or super interface has one method Speak(). The cat class will implement 
         * that Speak method and return Meow. Similarly the Lion class will implement 
         * the Speak() method and will return Roar. The dog class will implement Speak()
         * method and return Bark bark. The cat, lion and dog are living in the Land, so they 
         * belong to the Land Animal Group.
         * 
         * Let's say we have two factories i.e. Land Animal Factory and Sea Animal Factory.
         * Both of the Above mentioned factories are subclasses of Animal Factory. Here the 
         * Animal Factory is nothing but your Abstract Factory. The Animal Factory is responsible 
         * for creating the Sea Animal Factory and Land Animal Factory.The abstract GetAnimal method 
         * is implemented by the Sea Animal Factory and Land Animal Factory.The second method is 
         * CreateAnimalFactory. What basically this method does is, takes the factory type as an input
         * parameter, and based on the factory type it will create either the Sea Animal Factory obnject
         * or the Land Animal Factory object and return that object to the caller. So the Animal 
         * Factory acts as the Super Factory for Sea and Land Animal factories.
         */
        static void Main(string[] args)
        {
            // Create the Sea Factory object by passing the factory type as Sea
            AnimalFactory animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            Console.WriteLine("Animal Fctory Type : " + animalFactory.GetType().Name);
            Console.WriteLine();

            // Get Octopus Animal object by passing the animal type as Octopus
            Animal animal = animalFactory.GetAnimal("Octopus");
            Console.WriteLine("Animal Type " + animal.GetType().Name);
            string speakSound = animal.speak();
            Console.WriteLine(animal.GetType().Name + "Speak : " + speakSound);
            Console.WriteLine();

            // Create Land Factory object by passing the factory type as Land
            AnimalFactory landAnimalFactory = AnimalFactory.CreateAnimalFactory("Land");
            Console.WriteLine("Animal Factory Type : " + animalFactory.GetType().Name);
            Console.WriteLine();

            // Get Lion Animal object by passing the animal type as Lion
            Animal animalLand = animalFactory.GetAnimal("Lion");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            string speakSound1 = animalLand.speak();
            Console.WriteLine(animal.GetType().Name + "Speak " + speakSound1);
            Console.WriteLine();
        }
    }
}




/*
 * Notes : 
 * 
 * 1) Abstract Factory Pattern provides an interface for creating families of related
 *    dependent objects without specifying their concrete classes.
 * 2) The Abstract Factory Pattern provides a way to encapsulate a group of individual 
 *    factories that have a common theme without specifying their concrrete classes
 * 3) The abstract factory design pattern is merely an extension to the factory method pattern
 *    or factory pattern, which allows you to create objects without being concerned about the 
 *    actual class of the object being created
 * 4) The Abstract Factory Pattern is a software design pattern that provides a way to encapsulate 
 *    a group of individual factories that have a common theme.
 *    
 * When to use it Abstract Factory Design Pattern ?
 * 
 * 1) When you want to create a set of related objects or dependent objects which must be used
 *    together. 
 * 2) When the System should configure to work with multiple families of products
 * 3) When the Concrete classes should be decoupled from the clients.
 * 
 * 
 * Differences between Abstract Factory and Factory Method Design Pattern
 * 
 * 1) Abstract Factory Design Pattern adds a layer of abstraction to the Factory Method 
 *    Design Pattern
 * 2) The Abstract Factory design pattern implementation can have multiple factory methods
 * 3) Similar products of a factory implementation are grouped in the Abstract Factory
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */
