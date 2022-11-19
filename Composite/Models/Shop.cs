using Composite.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Models
{
    public class Shop : ShopMain, IShopFunctions
    {
        private List<ShopMain> _gifts;
        public Shop(string name, int price)
            : base(name, price)
        {
            _gifts = new List<ShopMain>();
        }
        public void Add(ShopMain gift)
        {
            _gifts.Add(gift);
        }
        public void Remove(ShopMain gift)
        {
            _gifts.Remove(gift);
        }
        public override int CalculatePrice()
        {
            int total = 0;
            Console.WriteLine($"{name} contains the following products with prices:");
            foreach (var gift in _gifts)
            {
                total += gift.CalculatePrice();
            }
            return total;
        }
    }
}
