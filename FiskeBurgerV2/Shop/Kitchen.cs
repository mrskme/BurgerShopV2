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
            if (!order.IsCorrectUserInput) return MakeErrorResponse(order);
            
            Recipe recipe = MakeRecipeOfOrder(order);

            if (IsIllegalDuplicateIngredient(recipe, Categories.Bun)) return "Du kan bare ha et brød";

            return MakeStringOfRecipe(recipe);
        }

        public string MakeErrorResponse(Order order)
        {
            string errorResponse = string.Empty;
            if (order.WrongInputs.Count > 1) errorResponse += "Disse ingrediensene\n";
            else errorResponse += "Denne ingrediensen\n";
            foreach (var wrongInput in order.WrongInputs) errorResponse += "\"" + wrongInput + "\"\n";
            errorResponse += "\ner ikke varer tilgjengelig i vårt sortiment.\nSjekk om du har stavet riktig, alle ingrediensene skal begynne med stor bokstav";
            return errorResponse;
        }

        public Recipe MakeRecipeOfOrder(Order order)
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            foreach (var stringIngredient in order.UserOrder)
            {
                ingredients.Add(ConvertFromOrderToIngredient(stringIngredient));
            }
            var recipe = new Recipe(ingredients);
            return recipe;
        }
        public string MakeStringOfRecipe(Recipe recipe)
        {
            var recipeString = "You are handed a burger consisting of: ";

            var categorizedIngredients = new List<List<Ingredient>>(Categories.All.Count())
            {
                AllIngredientsOfSameCategory(recipe, Categories.Vegetable),
                AllIngredientsOfSameCategory(recipe, Categories.Topping),
                AllIngredientsOfSameCategory(recipe, Categories.Bun),
                AllIngredientsOfSameCategory(recipe, Categories.Burger),
            };

            categorizedIngredients.ForEach(i => recipeString += MakeString(i));
            
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

        private List<Ingredient> AllIngredientsOfSameCategory(Recipe recipe, Category category) 
            => recipe.Ingredients.Where(i => i.Category == category).ToList();

        public bool IsIllegalDuplicateIngredient(Recipe recipe, Category category) 
            => recipe.Ingredients.Count(i => i.Category == category) > 1;

        public Ingredient ConvertFromOrderToIngredient(string stringIngredient) 
            => Ingredients.All.FirstOrDefault(I => I.Name == stringIngredient);

    }
}
