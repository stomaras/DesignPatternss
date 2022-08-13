using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample2
{
    public class BeverageDirector
    {
        /*
         * Once you create the concrete builder classes, then you need to create the 
         * director. The director is the component that will execute the required steps
         * in a particular order to create a beverage.
         * 
         * This MakeBeverage is so generic that it can create and return different types
         * of Beverage Objects
         * 
         * Step 4: Create Director class and one method which take the abstract class as an input
         *         and then create and return a particular beverage object.
         */

        public Beverage MakeBeverage(BeverageBuilder beverageBuilder)
        {
            beverageBuilder.CreateBeverage();

            beverageBuilder.SetBeverageType();
            beverageBuilder.SetWater();
            beverageBuilder.SetMilk();
            beverageBuilder.SetSugar();
            beverageBuilder.SetPowderQuantity();

            return beverageBuilder.GetBeverage();
        }
    }
}
