using System;

namespace RPG 
{
    public class Wizard : Human
    {
        public Wizard(string name, int str=3, int dex=3,int intel=25, int health =50): base(name,str,intel,dex,health)
        {
            
        }


        public override int Attack (Human target) 
        {
            int damage = this.Intelligence*5;
            int damageTaken =target.DamageTaken(damage);
            this.health += damageTaken;
            Console.WriteLine($"{this.Name} has cassed a spell at {target.Name} dealt: {damageTaken}");
            return target.Health;

        }

        public int Heal(Human target)
        {
            target.Heal(this.Intelligence*10);
            return target.Health;

        }
    }
}