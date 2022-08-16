using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample2.Business.Models
{
    /*
     * Item will have Name Price
     * 
     */
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Item(int id, string name, decimal price)        {
            Id = id;
            Name = name;
            Price = price;
        }

    }
}
