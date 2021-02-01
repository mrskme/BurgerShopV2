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
            var recipeString = string.Empty;

            recipeString += "You are handed a burger consisting of: ";
            var vegetableDuplicates = recipe.Ingredients.Where(i => i.Category == Categories.Vegetable).ToList(); 
            var toppingDuplicates = recipe.Ingredients.Where(i => i.Category == Categories.Topping).ToList();
            var bun = recipe.Ingredients.Where(i => i.Category == Categories.Bun).ToList();
            var burger = recipe.Ingredients.Where(i => i.Category == Categories.Burger).ToList();

            recipeString += MakeString(vegetableDuplicates);
            recipeString += MakeString(toppingDuplicates);
            recipeString += MakeString(bun);
            recipeString += MakeString(burger);
            return recipeString;
        }

        private string MakeString(List<Ingredient> ingredientsDuplicates)
        {
            var categoryString = string.Empty;
            if (ingredientsDuplicates.Any())
            {
                categoryString += $"\n{ingredientsDuplicates[0].Category.Name}";
                if (ingredientsDuplicates.Count > 1) categoryString += "s";
                categoryString += ":";
                foreach (var duplicate in ingredientsDuplicates)
                {
                    categoryString += $"\n  -{duplicate.Name}";
                }
            }
            return categoryString;
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
