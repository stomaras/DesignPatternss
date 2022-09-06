using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternRealTimeExample
{
    /*
     * Let's say, you want to prepare Coffee. In order to prepare coffee, you need to use components such as Water, Milk, Sugar, and coffee product. 
     * So waht you need to do is mix all these components and prepare coffee
     * So coffee is the complex object and the small Components (Milk, Water, Sugar and Coffee Product) are the simple objects,
     * you can prepare the complex object.i.e.coffee.
     * 
     * Suppose you want to Prepare Tea, then what you need to do is, you need to use water, milk, sugar, and Tea Product.
     * 
     * Builder Desing Pattern is used to build a complex using a generic step-by-step process so that the same construction process can be used
     * to build different representations of the same complex objects.
     * 
     * If you observe the process of creating tea and coffee is the same, only the content is different. So you can create one generic process something like below
     * 1) Add Water
     * 2) Add Milk
     * 3) Add Suagar
     * 4) Add Powder.
     * Beverage Builder (Generic Process)
     * 
     * Using the above genreric process, you can prepare Tea, Coffee, Horlicks.
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage;
            BeverageDirector beverageDirector = new BeverageDirector();

            TeaBuilder tea = new TeaBuilder();
            beverage = beverageDirector.MakeBeverage(tea);
            Console.WriteLine(beverage.ShowBeverage());

            CoffeeBuilder coffee = new CoffeeBuilder();
            beverage = beverageDirector.MakeBeverage(coffee);
            Console.WriteLine(beverage.ShowBeverage());

            Console.ReadKey();
        }
    }
}
