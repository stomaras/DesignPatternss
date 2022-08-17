using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    public class Lion : Animal
    {
        public string speak()
        {
            return "Roar Roar";
        }
    }
}
