using System;

namespace Hungry_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja Chris = new Ninja();
            Buffet Sushi = new Buffet();
            for ( int i= 0 ; i < 11 ; i++){
                Food NewFood = Sushi.Serve();
                Chris.Eat(NewFood);
            }
           foreach (var food in Chris.FoodHistory){
               Console.WriteLine(food.Name);
           }
        }
    }
}
