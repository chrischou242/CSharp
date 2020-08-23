using System;

namespace RPG 
{

    public class Samurai :Human
    {
        private int MaxHp{get;}
        public Samurai( string name, int str=3, int dex=3,int intel=25, int health =200 ): base(name,str,intel,dex,health)
        {
            this.MaxHp = health;
        }
         public override int Attack (Human target) 
        {
           
            if (target.Health < 50)
            {
                int HP =target.Health;
                target.DamageTaken(HP);
            }
            else
            {
                base.Attack(target);
            }
           return this.health;

        }
        public int Meditate()
        {
            this.health =this.MaxHp ;
            return this.health;
        }
    }

    


    


}

