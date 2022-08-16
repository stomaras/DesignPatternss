using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Cards
{
    public class Titanium : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 1500;
        }

        public string GetCardType()
        {
            return " Titanium Edge";
        }

        public int GetCreditLimit()
        {
            return 25000;
        }
    }
}
