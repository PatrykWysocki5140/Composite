using Composite.Models;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var sword = new Item("Sword", 122222);
            sword.CalculatePrice();
            Console.WriteLine();

            var gunShop = new Shop("Gun Shop", 0);
            var rifle = new Item("Rifle", 12200);
            var pistol = new Item("Pistol", 1200);
            gunShop.CalculatePrice();
            gunShop.Add(rifle);
            gunShop.Add(pistol);
            var shoesShop = new Shop("Shoes Shop", 0);
            var nike = new Item("Nike", 1500);
            shoesShop.Add(nike);
            shoesShop.CalculatePrice();
            gunShop.Add(shoesShop);
  
            Console.WriteLine($"Total price in GunShop: {gunShop.CalculatePrice()}");
            Console.WriteLine($"Total price in sword: {sword.CalculatePrice()}");
            Console.WriteLine($"Total price in shoesShop: {shoesShop.CalculatePrice()}");
        }
    }
}