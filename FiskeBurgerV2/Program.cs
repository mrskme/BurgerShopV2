﻿using System;
using System.Collections;
using System.Collections.Generic;
using FiskeBurgerV2.Ingredientserino;
using FiskeBurgerV2.Shop;

namespace FiskeBurgerV2
{
    class Program
    {
        static void Main(string[] args)
        {
            var burgerShop = new BurgerShop();

            var order = new Order("Onion","Tomato", "Sesame seed bun", "Hamburger","asdasd");

            burgerShop.GiveBurgerToCustomer(order);
        }
    }
}
