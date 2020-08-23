namespace Human{
    public class Person{
        public string Name {get;}
        public int Strength{get;}
        public int Intelligence{get;}
        public int Dexterity{get;}
        private int _health;
        public int Health
        {
            get {return _health;}
        }

        
        public Person(string name="Chris", int strength=3, int intelligence=3, int dexterity=3, int health=100)
        {
            this.Name =name;
            this.Strength=strength;
            this.Intelligence=intelligence;
            this.Dexterity=dexterity;
            this._health=health;
        }

       
        public int Attack(Person human){
            human._health -=  this.Strength*5;
            return human._health;
        }
        
    }

   
}