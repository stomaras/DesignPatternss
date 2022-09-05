using FactoryPluralSight.Business;
using FactoryPluralSight.Business.Models.Commerce;
using FactoryPluralSight.Business.Models.Shipping.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPluralSight
{
    /*
     * Documentation Learn About Factory, Factory Method, and Abstract Factory.
     * Factory Method , Abstract Factory 
     * Understanding the Characteristics of these patterns
     * Implement them in c#
     * Whole Purpose of a factory is to product a product as a consmer i don't need to know the way of creation of these phone.
     * The advantages of having a factory which product this phone is that multiple clients of the factory can get these phones
     * without having care about the procees of creating the phone.
     * 
     * A factory is an object for creating objects.
     * Purpose of the factory is to produce extensibility.
     * 
     * There are in fact three different flavors of the factory patterns.
     * 1) Simple Factory
     * 2) Factory Method
     * 3) Abstract Factory.
     * 
     * Client should be a shopping cart class inside in an ecommerce system.
     * The Shopping Cart needs to be able to ship your order, but does not necessarily want to care about how to instantiate or create 
     * an instance of a country-specific shipping provider.
     * 
     * Client               Creator                     Product
     * Shopping Cart        ShippingProviderFactory     ShippingProvider Instance.
     * 
     * The ShippingProvider it produces or , in other terms , create an instance for, could be different classes depending on 
     * what country the order needs to be shipped from 
     * 
     * The client no longer needs to know how to create an object or exactly what flavor of that class it will use.
     * 
     * In the Shopping Cart example we could introduct a class called ShippingProviderFactory, this will expose a method , which purpose it 
     * to create an instance of a shipping provider. Depending on which parameters are passed to thsi method, you may get different variations 
     * of the shipping providers.
     * 
     * Shopping Cart -> Uses ------> Shipping Provider Factory 
     *                                         |
     *                                         |
     *                                         |
     *                              CreateShippingProvider()
     *                                         |
     *                                         | Creates
     *                                         |
     *                              Country Specific Shipping Provider.
     * 
     * 
     * 
     * ShoppingCar should know about of the client id,  secret, the shippingCostCalculator,Customs or Insurance Options ?
     * We also want to extract this creation of the shipping provider out of the shopping cart , becuase the instantiatio
     * does not belong in the shopping cart. and the same goes for the instantiation of the Swedish Postal Service Provider
     * 
     * We must make the implementation details and usage of the shipping provider 
     * All that needs to know about is that it can generate a shipping label for an order.
     * Simple Factory is going to live in our business layer.
     * 
     * ShippingProviderFactory puspose is for create an instance of a shipping provider based on some user input or configuration.
     * In our case , it is based on the country from where this order is being sent.
     * There is nothing inside this class that will keep a state, 
     * So it make sense to introduce a static method that allows us to create an instance of a shipping provider.
     * 
     * 
     * When we are instantiating our shopping cart we also need to pass the appropriate ShippingProviderFactory.
     * The concrete factory is most of the time determined based on user input or configuration during runtime.
     * 
     * VIP vs Standard User
     * 
     * VIP ---> uses ---> Global Express Shipping Provider Factory.
     * Standard ---> uses ---> Standard Shipping Provider Factory.
     * 
     * The abstract factory pattern provides a way to encapsulate a group of individual factories that have a common theme 
     * without specifying their concrete classes.
     * 
     * IPurchaseProviderFactory
     * - CreateShippingProvider(): IShippingProvider
     * - CreateInvoice(): IInvoice
     * - CreateSummary(): ISummary
     * 
     * SwedenPurchaseFactory                AustraliaPurchaseFactory
     * - CreateShippingProvider()           - CreateShippingProvider()
     * - CreateInvoice()                    - CreateInvoice()
     * - CreateSummary()                    - CreateSummary()
     * 
     * Invoices and tax on them work very different in these countries.
     * 
     * Example : Using the Abstract Factory 
     * 
     * var shippingProvider = purchaseProviderFactroy.CreateShippingProvider(order);
     * var invoice = purchaseProviderFactory.CreateInvoice(order);
     * 
     * Common thing is that all depend on the order in the shopping cart.
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
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            var cart = new ShoppingCart(order, new ShippingProviderFactory());
            var shippingLabel = cart.Finalize();
            Console.WriteLine(shippingLabel);
        }
    }
}
