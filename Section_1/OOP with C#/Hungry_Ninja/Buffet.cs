using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    public class Buffet
    {
        public List<Food> Menu;

        public Buffet ()
        {
            Menu = new List<Food>()
            {
                new Food("Sushi",300,false,true),
                new Food("HotDog",400,false,false),
                new Food("Rice",200,false,false),
                new Food("Pork", 200, false,false),
                new Food("Burgers",400,false,true),
                new Food("Soda", 100, false,false),
                new Food("Cucumbers",200, false,false),
            };
        }

        public Food Serve()
        {
            Random Rand = new Random();
            int food = Rand.Next(Menu.Count);
            return Menu[food];
        }

    }
}