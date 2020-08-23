using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] RanArray = new int[] {5,10,15,20,7,11,16,21,22,23};
            RandomArray(RanArray);
            Console.WriteLine(TossCoin());
            Names();
        }
        public static void RandomArray(int[] numbers)
        {
            int min= numbers[0];
            int max =numbers[0];
            int sum =0;
            for (int i=0; i < numbers.Length ; i++){
                sum = sum + numbers[i];
                if(numbers[i]>max){
                    max = numbers[i];
                }
                else if (numbers[i] < min){
                    min = numbers[i];
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(max);
            Console.WriteLine(min);
        }

        public static string TossCoin()
        {
            Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            
            int num = rand.Next(1,3);
            if (num ==1){
                return "Heads!";
            }
            return "Tails";
            
        }

        public static List<string> Names()
        {
            List<string> names= new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");
            Random rand = new Random();
            for ( int i=0; i<names.Count*5; i++){
                int index1 = rand.Next(names.Count);
                int index2 = rand.Next(names.Count);
                string temp = names[index1];
                names[index1]= names[index2];
                names[index2] = temp;
            }
           
            for (int i=0 ; i<names.Count ; i++)
            {
                if (names[i].Length <=5){
                    names.RemoveAt(i);
                }
            }
            
            foreach ( var name in names)
            {
                Console.WriteLine(name);
            }
            return names;
            
        }
    }
}
