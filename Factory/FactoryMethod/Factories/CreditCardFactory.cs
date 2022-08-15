using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    #region Documentation
    /*
     * As per definition of the Factory Method Design Pattern, we need to create 
     * an abstract class or interface for creating the object. This is going to be 
     * the creator class that declares the factory method, which will return 
     * an object of type Product(i.e. CreditCard)
     * 
     * CreditCardFactory contains two methods, one abstract method MakeProduct()
     * and one concrete method i.e. CreateProduct(). The CreateProduct() internally calls
     * the MakeProduct() method of the subclass which will create the product instance
     * and return that instance.
     * 
     * The Abstract Creator declares the factory method , which returns an object of type 
     * Product. As per definition, we need to create an abstract class or interface for 
     * creating the object.So let us to create an abstract class that will be our factory class
     * with a publicly exposed method.That method is nothing but the factory method which will
     * return the instance of the product.
     */
    #endregion
    public abstract class CreditCardFactory
    {
        protected abstract CreditCard MakeProduct();

        public CreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}
