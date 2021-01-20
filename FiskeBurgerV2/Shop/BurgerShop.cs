using System;
using System.Collections.Generic;
using System.Text;

namespace FiskeBurgerV2
{
    class BurgerShop
    {
        Kitchen kitchen = new Kitchen();

        public void GiveBurgerToCustomer()
        {
            Console.WriteLine(kitchen.MakeBurger());
        }

    }
}
