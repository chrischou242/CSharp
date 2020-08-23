using System;
using System.Collections.Generic;

namespace Collection_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray;
            numArray = new int[] {0,1,2,3,4,5,6,7,8};
            Console.WriteLine(numArray[0]);

            string[] names = new string[] {"Tim","Martin","Nikki","Sara"};
            string [] boolean = new string[]{"true","false","true","false","true","false","true","false","true","false"};

            List<string> iceCream= new List<string> {"Vanilla", "Chocolate", "Mint", "StrawBerry", "BlueBerry"};
            Console.WriteLine(iceCream.Count);
            iceCream.Remove("Mint");
            Console.WriteLine(iceCream.Count);

           Dictionary<string,string> Cream = new Dictionary<string,string>();
            Cream.Add("Tim", "Vanilla");
            Cream.Add("Martin", "Chocolate");
            Cream.Add("Nikki", "Mint");
            Cream.Add("Sara", "Strawberry");

           
            foreach (var entry in Cream)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }


        }
    }
}
