using System;
using System.Collections.Generic;
using System.Text;

namespace FiskeBurgerV2
{
    class Ingredient
    {
        public string Name;
        Category Category = new Category();

        //public List<Category> Categories = new List<Category>()
        //{
        //    new Category("Bun"),
        //};

        public Ingredient(string name, Category category)
        {
            Name = name;
            Category = category;
        }
    }
}
