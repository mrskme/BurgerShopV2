using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiskeBurgerV2
{
    class Recipe
    {
        public List<Ingredient> Ingredients { get; }

        public Recipe(IEnumerable<Ingredient> ingredients)
        {
            Ingredients = ingredients.ToList();
        }

        public string WriteIngredients()
        {
            string ingredientsString = null;
            foreach (var ingredient in Ingredients)
            {
                ingredientsString += ingredient.Name;
            }
            return ingredientsString;
        }
    }
}
