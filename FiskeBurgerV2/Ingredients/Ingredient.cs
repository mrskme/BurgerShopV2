using System;
using System.Collections.Generic;
using System.Text;

namespace FiskeBurgerV2
{
    class Ingredient
    {
        public string Name { get; }
        public Category Category { get; }

        public Ingredient(string name, Category category)
        {
            Name = name;
            Category = category;
        }
    }
}
