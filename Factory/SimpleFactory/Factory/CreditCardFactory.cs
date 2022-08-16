using SimpleFactory.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Factory
{
    /*
     * The Abstract Creator declares the Factory Method , which returns an object 
     * of type Product.
     * 
     * 
     */
    public abstract class CreditCardFactory
    {
        protected abstract CreditCard MakeProduct();

        public CreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}
