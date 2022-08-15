using FactoryMethod.Factories;
using FactoryMethod.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {

        #region Documentation
        /*
         * We have three credit cards i.e MoneyBack, Titanium, Platinum.
         * These credit cards are nothing but our Product classes. Again these 
         * three Credit Card classes are the subclasses of the CreditCard super interface.
         * The credit card super interface defines the operations (i.e GetCardType,
         * GetCreditLimit, and GetAnnualCharge) which needs to be implemented by the 
         * subclasses (i.e MoneyBack, Titanium, and Platinum).

         */
        #endregion
        static void Main(string[] args)
        {

            CreditCard creditCard = new PlatinumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge : " + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
            Console.WriteLine("----------------------------------");
            creditCard = new TitaniumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge : " + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.WriteLine("Invalid Card Type!");
            }
            Console.ReadLine();

        }
    }
}
