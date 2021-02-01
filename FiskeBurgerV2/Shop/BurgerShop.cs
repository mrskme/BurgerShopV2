using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FiskeBurgerV2.Ingredientserino;
using FiskeBurgerV2.Shop;

namespace FiskeBurgerV2
{
    class BurgerShop
    {
        public Kitchen Kitchen { get; }

        public BurgerShop()
        {
            Kitchen = new Kitchen();
        }

        public void GiveBurgerToCustomer(Order order)
        {
            Console.WriteLine(Kitchen.MakeCustomBurger(order));
        }
    }
}
