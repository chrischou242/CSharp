using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Ninja Ninja1 = new Ninja("Chris");
            Wizard Wizard1 = new Wizard("David");
            Console.WriteLine("Hello World!");
            Console.WriteLine(Wizard1.Health);
            Ninja1.Attack(Wizard1);
            Console.WriteLine(Wizard1.Health);
            Ninja1.Steal(Wizard1);
        }
    }
}
