using SimpleFactory.Cards;
using SimpleFactory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    internal class Program
    {
        /*
         * If you want to create an instance of the Platinum CreditCard then call 
         * the CreateProduct method of the PlatinumFactory instance
         * 
         */
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
            Console.WriteLine("---------------------");
            creditCard = new MoneyBackFactory().CreateProduct();
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
            Console.ReadLine();
        }
    }
}
