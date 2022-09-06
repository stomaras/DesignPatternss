using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternRealTimeExample
{
    public class TeaBuilder : BeverageBuilder
    {
        public override void SetBeverageType()
        {
            Console.WriteLine("Tea");
            GetBeverage().BeverageName = "Tea";
        }

        public override void SetMilk()
        {
            Console.WriteLine("Step 2: Adding Milk");
            GetBeverage().Milk = 60;
        }

        public override void SetPowderQuantity()
        {
            Console.WriteLine("Step 4 : Adding 20 Grams of coffee powder");
            GetBeverage().PowderQuantity = 20;
        }

        public override void SetSugar()
        {
            Console.WriteLine("Step 3: Adding Sugar");
            GetBeverage().Sugar = 15;
        }

        public override void SetWater()
        {
            Console.WriteLine("Step 1: Boiling Water");
            GetBeverage().Water = 50;
        }
    }
}
