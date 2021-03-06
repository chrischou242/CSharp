namespace AbstractIntro
{
    public class Tower : Building, IDamageable
    {
        public int Health { get; set; }
        public override string Name { get; set; }

        public Tower(string name, int health = 100, int floors = 2)
        {
            Name = name;
            // overwrite the default floors from the abstract building class
            Health = health;
            Floors = floors;
        }

        // inherits the default TakeDamage method from IDamageable, can be replaced if we need to customize
    }
}