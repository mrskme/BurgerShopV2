using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FiskeBurgerV2.Ingredients;

namespace FiskeBurgerV2
{
    class Kitchen
    {
        public Categories Categories { get; }
        public List<Ingredient> Ingredients { get; }
        public Kitchen()
        {
            Categories = new Categories();
            Ingredients = new List<Ingredient>
            {
                new Ingredient("Brioche", Categories.Bun),
                new Ingredient("Sesame seed bun", Categories.Bun),
                new Ingredient("Iceberg Lettuce", Categories.Vegetable),
                new Ingredient("Løk", Categories.Vegetable),
                new Ingredient("Tomat", Categories.Vegetable),
                new Ingredient("Superdressing", Categories.Topping),
                new Ingredient("Ketchup", Categories.Topping),
                new Ingredient("Hamburger", Categories.Burger),
                new Ingredient("Fiskeburger", Categories.Burger),
            };
            //Categories.All
        }

        public string MakeBurger(IEnumerable<Ingredient> ingredients)
        {
            Recipe recipe = new Recipe(ingredients);
            Kitchen kitchen = new Kitchen();
            
            var Recipe = recipe.Ingredients;

            var Bun = Recipe.Where(i => i.Category.Name == Categories.Bun.Name);
            if (Bun.Count() > 1) return "Du kan bare ha et brød";
            //string ingredientsString = recipe.Ingredients.Aggregate("",(seed,ingredient ) => seed + ingredient.Name + " ");
            return "null";
        }
    }
}
