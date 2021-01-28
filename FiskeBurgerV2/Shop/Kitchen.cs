using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FiskeBurgerV2.Ingredients;
using FiskeBurgerV2.Shop;

namespace FiskeBurgerV2
{
    class Kitchen
    {
        public Categories Categories { get; }
        public static List<Ingredient> Ingredients { get; set; }
        
    public Kitchen()
        {
            Categories = new Categories();
            Ingredients = new List<Ingredient>
            {
                new Ingredient("Brioche", Categories.Bun),
                new Ingredient("Sesame seed bun", Categories.Bun),
                new Ingredient("Iceberg Lettuce", Categories.Vegetable),
                new Ingredient("Onion", Categories.Vegetable),
                new Ingredient("Tomato", Categories.Vegetable),
                new Ingredient("Superdressing", Categories.Topping),
                new Ingredient("Ketchup", Categories.Topping),
                new Ingredient("Hamburger", Categories.Burger),
                new Ingredient("Fiskeburger", Categories.Burger),
            };

            //Categories.All
        }

        public string CustomBurger(Order order)
        {
            //Recipe recipe = new Recipe(ingredients);
            if (!order.HasIngredients) return "En eller fler av ingrediensene er manglende i vårt lager eller feil stavet";
            var bun =
            //var Recipe = recipe.Ingredients;

            Recipe recipe = new Recipe(GetIngredientsIntoList(order););

            //var Bun = Recipe.Where(i => i.Category.Name == Categories.Bun.Name);
            //if (Bun.Count() > 1) return "Du kan bare ha et brød";

            //string ingredientsString = recipe.Ingredients.Aggregate("",(seed,ingredient ) => seed + ingredient.Name + " ");
            return String.Empty;
        }

        public Ingredient GetIngredient(Ingredient stringIngredient)
        {
            var ingredient = Ingredients.FirstOrDefault(I => I.Name == stringIngredient.Name);
            //foreach (var ingredient in Ingredients)
            //{
            //    if (ingredient.Name.Equals(stringIngredient))
            //    {
            //        return ingredient;
            //    }
            //}
            return ingredient;
        }
        public Recipe GetIngredientsIntoList(Order order)
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            foreach (var stringIngredien in order.Ingredients)
            {
                ingredients.Add(GetIngredient(stringIngredient.));
            }

            var Recipe = new Recipe(Ingredients);
            return Recipe;
        }
    }
}
