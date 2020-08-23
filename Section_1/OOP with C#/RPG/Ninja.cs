using System;

namespace RPG 
{

    public class Ninja :Human
    {
        public Ninja( string name, int str=3, int dex=175,int intel=25, int health =50): base(name,str,intel,dex,health)
        {

        }

         public override int Attack (Human target) 
        {
            
            int steal = this.Dexterity*5;
            target.DamageTaken(steal);
            
            Random Random = new Random();
            int stealing = Random.Next(0,101);
                if (stealing<=20)
                {
                    target.DamageTaken(10);

                }
                
           
            return target.Health;

            
        }
        public void Steal(Human target)
        {
            target.DamageTaken(5);
            this.Heal(5);
            
            return;
        }


    }





}

