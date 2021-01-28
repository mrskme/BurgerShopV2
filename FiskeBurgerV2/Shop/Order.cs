using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiskeBurgerV2.Shop
{
    class Order
    {
        public bool HasIngredients = true;
        public List<string> UserOrder;

        public Order(params string[] order)
        {
            UserOrder = order.ToList();

            foreach (var ingredient in order)
            {
                HasIngredients &= Kitchen.Ingredients.Any(i => i.Name.Contains(ingredient));
            }
        }
    }
}
