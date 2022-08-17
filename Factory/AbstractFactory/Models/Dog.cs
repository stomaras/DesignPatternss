using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    public class Dog : Animal
    {
        public string speak()
        {
            return " Bark Bark Bark";
        }
    }
}
