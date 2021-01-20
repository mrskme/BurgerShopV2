using System;
using System.Collections.Generic;
using System.Text;

namespace FiskeBurgerV2
{
    class Kitchen
    {
        public enum CategoryEnum {Bun,Salad,Burger}
        static List<Category> Categories = new List<Category>()
        {
            new Category("Bun"),
            new Category("Salad"),
            new Category("Burger"),
        };
        List<Ingredient> ingredients = new List<Ingredient>()
        {
            new Ingredient("Brioche", Categories[(int)CategoryEnum.Bun]),
            new Ingredient("Sesanme seed bun", Categories[(int)CategoryEnum.Bun]),
            new Ingredient("Iceberg Lettuce",Categories[(int)CategoryEnum.Salad]),
        };

        public string MakeBurger()
        {
            Recipe recipe = new Recipe();
            
            return string.Empty;
        }
    }
}
