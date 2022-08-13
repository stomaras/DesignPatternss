using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample2
{
    /*
     * Create a class file with name BeverageBuilder.cs 
     * This BeverageBuilder class is going to be an abstract class and will act as
     * a blueprint for any subclasses that want to create a Beverage. So it will have 
     * different subclasses implementations for different beverage types such as Coffee
     * , Tea, Horlicks, e.t.c. This class is having different abstract methods to set the
     * Milk, Water, Sugar, PowderQuantity, and BeverageType.
     * 
     * Step 2: Create Abstract Class of Product Type
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
