using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FiskeBurgerV2.Ingredients;
using FiskeBurgerV2.Shop;

namespace FiskeBurgerV2
{
    class BurgerShop
    {
        public Kitchen Kitchen { get; }
        public Order Order { get; }

        public BurgerShop()
        {
            Kitchen = new Kitchen();
            Order = new Order();
        }

        public void GiveBurgerToCustomer(Order order)
        {
            Console.WriteLine(Kitchen.CustomBurger(order));
        }
    }
}
