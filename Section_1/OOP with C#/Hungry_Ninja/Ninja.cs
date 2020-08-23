using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    class Ninja
    {
        private int _calorieIntake;
        public List<Food> FoodHistory{get;}
        
        
        
        public Ninja()
        {
            this._calorieIntake=0;
            FoodHistory = new List<Food>();
        }

        public bool isFull()
        {
            if (_calorieIntake>1200)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void Eat(Food item)
        {
        
        
            if (isFull())
            {
               Console.WriteLine("Ninja is full");
            }
            else
            {
                 _calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"{item.Name} is spicy: {item.IsSpicy} is sweet {item.IsSweet}");

            }

          
        }

    }
   
    
}


