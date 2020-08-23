using System;
namespace Hungry_Ninja
{
    public class Food
    {
        public string Name{get;}
        public int Calories{get;}
        public bool IsSpicy{get;}
        public bool IsSweet{get;}

        public Food(string name, int calories , bool isSpicy, bool isSweet){
            this.Name = name;
            this.Calories = calories;
            this.IsSpicy=isSpicy;
            this.IsSweet = isSweet;
        }
    }

}
