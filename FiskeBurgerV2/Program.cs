using System;
using System.Collections;
using System.Collections.Generic;
using FiskeBurgerV2.Ingredients;

namespace FiskeBurgerV2
{
    class Program
    {
        static void Main(string[] args)
        {
            var burgerShop = new BurgerShop();
            var kitchen = new Kitchen();
            //Ingredients = new List<Ingredient>
            //{
            //    new Ingredient("Brioche", Categories.Bun),
            //    new Ingredient("Sesame seed bun", Categories.Bun),
            //    new Ingredient("Iceberg Lettuce", Categories.Vegetable),
            //    new Ingredient("Løk", Categories.Vegetable),
            //    new Ingredient("Tomat", Categories.Vegetable),
            //    new Ingredient("Superdressing", Categories.Topping),
            //    new Ingredient("Ketchup", Categories.Topping),
            //    new Ingredient("Hamburger", Categories.Burger),
            //    new Ingredient("Fiskeburger", Categories.Burger)
            //};
            List<Ingredient> Bestilling = new List<Ingredient>() {kitchen.Ingredients[1], kitchen.Ingredients[0], kitchen.Ingredients[5], kitchen.Ingredients[7] };

            burgerShop.GiveBurgerToCustomer(Bestilling);
        }
    }
}
