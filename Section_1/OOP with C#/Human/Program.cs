using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person Human1 = new Person("Chris", 3, 50, 50);
            Console.WriteLine(Human1.Name);
            Console.WriteLine(Human1.Health);
            Person Human2 = new Person("Mouse",10,health:90);
            Console.WriteLine(Human1.Attack(Human2));
            Console.WriteLine(Human2.Health);
            
            
        }
    }

}
