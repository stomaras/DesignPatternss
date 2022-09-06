using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternRealTimeExample
{
    /*
     * Create a class with the name Beverage 
     * This is going to be our product and in this class, 
     * we put all the attributes such as Water, Milk, Sugar, PowederQuantity, BeverageName which is common to prepare beverages
     * (i.e. Coffee or Tea). We also create one method (i.e. ShowBeverage) which returns the beverage details.
     * 
     */
    public class Beverage
    {
        public int Water { get; set; }
        public int Milk { get; set; }
        public int Sugar { get; set; }
        public int PowderQuantity { get; set; }
        public string BeverageName { get; set; }

        public string ShowBeverage()
        {
            return "Hot " + BeverageName + " [" + Water + " ml of water, " + Milk + " ml of milk, " + Sugar + " gm of sugar, " + PowderQuantity + " gm of " +
                BeverageName + "]\n";
        }
    }
}
