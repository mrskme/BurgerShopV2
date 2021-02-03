using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FiskeBurgerV2.Ingredientserino;


namespace FiskeBurgerV2.Shop
{
    class Order
    {
        public bool IsCorrectUserInput { get; }
        public List<string> UserOrder { get; }

        private Ingredients Ingredients;
        //Always assigned before beign used? Er det i det heletatt vits å bruke før den blir assigna? 
        public List<string> WrongInputs { get; }

        public Order(params string[] order)
        {
            IsCorrectUserInput = true;
            Ingredients = new Ingredients();
            WrongInputs = new List<string>();
            UserOrder = order.ToList();

            foreach (var ingredient in order)
            {
                IsCorrectUserInput &= Ingredients.All.Any(i => i.Name.Contains(ingredient));
                if (!IsCorrectUserInput) WrongInputs.Add(ingredient);
            }
            
        }
    }
}
