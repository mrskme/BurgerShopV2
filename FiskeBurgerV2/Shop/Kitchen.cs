using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FiskeBurgerV2.Ingredientserino;
using FiskeBurgerV2.Shop;

namespace FiskeBurgerV2
{
    class Kitchen
    {
        //public  List<Ingredient> Ingredients { get; set; }
        public Ingredients Ingredients;
        private Categories Categories;
        public Kitchen()
        {
            Ingredients = new Ingredients();
            Categories = Ingredients.Categories;
        }

        public string MakeCustomBurger(Order order)
        {
            if (!order.HasIngredients) return "En eller fler av ingrediensene er manglende i vårt lager eller feil stavet";

            Recipe recipe = MakeRecipeOfOrder(order);

            if (IsDuplicateIngredient(recipe, Categories.Bun)) return "Du kan bare ha et brød";

            if (IsDuplicateIngredient(recipe, Categories.Burger)) return "Du kan bare ha en burger";

            return MakeStringOfRecipe(recipe);
        }

        public Recipe MakeRecipeOfOrder(Order order)
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            foreach (var stringIngredient in order.UserOrder)
            {
                ingredients.Add(ConvertFromOrderToIngredient(stringIngredient));
            }
            var Recipe = new Recipe(ingredients);
            return Recipe;
        }
        public string MakeStringOfRecipe(Recipe recipe)
        {
            string RecipeString = recipe.Ingredients.Aggregate("", (seed, ingredient) => seed + ingredient.Name + " ");
            return RecipeString;
        }
        public bool IsDuplicateIngredient(Recipe recipe, Category category)
        {
            var isDuplicateIngredient = recipe.Ingredients.Count(i => i.Category == category) > 1;
            return isDuplicateIngredient;
        }

        public Ingredient ConvertFromOrderToIngredient(string stringIngredient)
        {
            var chosenIngredient = Ingredients.All.FirstOrDefault(I => I.Name == stringIngredient);
            return chosenIngredient;
        }
    }
}
