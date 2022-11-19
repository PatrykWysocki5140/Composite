using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Models
{
    public class Item : ShopMain
    {
        public Item(string name, int price)
            : base(name, price)
        {
        }
        public override int CalculatePrice()
        {
            Console.WriteLine($"{name} with the price {price}");
            return price;
        }
    }
}
