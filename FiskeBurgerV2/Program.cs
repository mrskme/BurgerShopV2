using System;
using System.Collections;
using System.Collections.Generic;
using FiskeBurgerV2.Ingredients;
using FiskeBurgerV2.Shop;

namespace FiskeBurgerV2
{
    class Program
    {
        static void Main(string[] args)
        {
            var burgerShop = new BurgerShop();
            var order = new Order("Onion", "Sesame seed bun", "Tomato", "Hamburger");
            //Console.WriteLine(order.HasIngredients);
            

            burgerShop.GiveBurgerToCustomer(order);
        }
    }
}
