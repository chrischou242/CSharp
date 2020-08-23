using System;

namespace RPG 
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int health;
         
        public int Health
        {
            get { return health; }
           
        }
        

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
         
        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }
         
        // Build Attack method
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }

        public int DamageTaken (int damage)
        {
            if (damage <= this.health)
            {
                this.health-=damage;
            }
            else{
                damage = this.health;
                this.health =0;
                Console.WriteLine($"{Name} has Died");
            }
             return damage;
        }

        public int Heal(int health)
        {
            this.health += health;
        
            return health;
        }

        
    }
}