using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FiskeBurgerV2.Ingredientserino;


namespace FiskeBurgerV2.Shop
{
    class Order
    {
        public bool HasIngredients;
        public List<string> UserOrder;
        private Ingredients Ingredients;

        public Order(params string[] order)
        {
            HasIngredients = true;
            Ingredients = new Ingredients();
            UserOrder = order.ToList();

            foreach (var ingredient in order)
            {
                HasIngredients &= Ingredients.All.Any(i => i.Name.Contains(ingredient));
            }
        }
    }
}
