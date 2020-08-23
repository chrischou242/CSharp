using System;
using System.Collections.Generic;

namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> items = new List<object>();
            items.Add(7);
            items.Add(28);
            items.Add(-1);
            items.Add(true);
            items.Add("Chair");
            int sum =0;
            for (var i =0; i< items.Count; i++){
                
                
                if (items[i] is int){
                    
                    sum = sum + (int)(items[i]);
                    Console.WriteLine(sum);
                }
                else if(items[i] is string){
                    Console.WriteLine(items[i]);
                }
                
            }
                Console.WriteLine(sum);
            
        }
    }
}
