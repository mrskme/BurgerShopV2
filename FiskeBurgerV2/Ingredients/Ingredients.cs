using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiskeBurgerV2.Ingredientserino
{
    class Ingredients
    {
        public Categories Categories { get; }
        
        public Ingredient Brioche { get; }
        public Ingredient SesameSeedBun { get; }
        public Ingredient IcebergLettuce { get; }
        public Ingredient Onion { get; }
        public Ingredient Tomato { get; }
        public Ingredient Superdressing { get; }
        public Ingredient Ketchup { get; }
        public Ingredient Fiskeburger { get; }
        public Ingredient Hamburger { get; }
        public List<Ingredient> All => new List<Ingredient>()
        {
            Brioche,
            SesameSeedBun, 
            IcebergLettuce, 
            Onion, 
            Tomato,
            Superdressing,
            Ketchup, 
            Fiskeburger, 
            Hamburger,
        };
        public Ingredients()
        {
            Categories = new Categories();

            Brioche = new Ingredient("Brioche", Categories.Bun);
            SesameSeedBun = new Ingredient("Sesame seed bun", Categories.Bun);
            IcebergLettuce = new Ingredient("Iceberg Lettuce", Categories.Vegetable);
            Onion = new Ingredient("Onion", Categories.Vegetable);
            Tomato = new Ingredient("Tomato", Categories.Vegetable);
            Superdressing = new Ingredient("Superdressing", Categories.Topping);
            Ketchup = new Ingredient("Ketchup", Categories.Topping);
            Hamburger = new Ingredient("Hamburger", Categories.Burger);
            Fiskeburger = new Ingredient("Fishburger", Categories.Burger);
        }
    }
}
