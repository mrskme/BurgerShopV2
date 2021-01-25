using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FiskeBurgerV2.Ingredients;

namespace FiskeBurgerV2
{
    class BurgerShop
    {
        private Kitchen _kitchen;

        public BurgerShop()
        {
            _kitchen = new Kitchen();
        }

        public void GiveBurgerToCustomer(IEnumerable<Ingredient> ingredients)
        {
            Console.WriteLine(_kitchen.MakeBurger(ingredients.ToList()));
        }
    }
}
