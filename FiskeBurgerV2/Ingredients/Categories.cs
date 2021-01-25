using System;
using System.Collections.Generic;
using System.Text;

namespace FiskeBurgerV2.Ingredients
{
    class Categories
    {
        public Category Bun { get; }
        public Category Vegetable { get; }
        public Category Burger { get; }
        public Category Topping { get; }

        public IEnumerable<Category> All => new Category[] { Bun, Vegetable, Burger, Topping };

        //public IEnumerable<Category> Alle;

        public Categories()
        {
            Bun = new Category("Bun");
            Vegetable = new Category("Vegetable");
            Burger = new Category("Burger");
            Topping = new Category("Topping");

            //Alle = new Category[] { Bun, Vegetable, Burger };
        }
    }
}
