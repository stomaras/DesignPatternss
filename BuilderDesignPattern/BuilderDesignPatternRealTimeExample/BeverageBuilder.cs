using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternRealTimeExample
{
    /*
     * Is going to act as a blueprint for any subclasses that we want to create a Beverage.
     * So it will have different subclasses implementations for different bevergae types such as Coffee, Tea, Horlicks .e.t.c
     * 
     */
    public abstract class BeverageBuilder
    {
        protected Beverage beverage;

        public void CreateBeverage()
        {
            beverage = new Beverage();
        }

        public Beverage GetBeverage()
        {
            return beverage;
        }


        public abstract void SetBeverageType();
        public abstract void SetWater();
        public abstract void SetMilk();
        public abstract void SetSugar();
        public abstract void SetPowderQuantity();
    }
}
