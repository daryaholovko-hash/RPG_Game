namespace RPG_Game
{
    public partial interface IEquippable
    {
        public abstract class Characer
    {
         private string _name;
        private int _health;
        private int _maxHealth;
        private int _strength;

            public string Name
            {
                get => _name;
                protected set => _name = value;
            }

            public int Health
            {
                get => _health;
                protected set => _health = Math.Max(0, Math.Min(value, _maxHealth));
            }

            public int MaxHealth
            {
                get => _maxHealth;
                protected set => _maxHealth = value;
            }

            public int Strength
            {
                get => _strength;
                protected set => _strength = value;
            }

            public bool IsAlive => _health > 0;

            protected Characer(string name, int health, int srtrenght)
            {
                _name = name;
                _health = health;
                _maxHealth = srtrenght;
                _strength = srtrenght;
            }

            public abstract void Attack(Characer target);


            public virtual void TakeDamage(int damage)
            {
                Health -= damage;
                Console.WriteLine($"{Name} отримав {damage} пошкоджень! (HP: {Health}/{MaxHealth})");

                if (!IsAlive)
                {
                    Console.WriteLine($"{Name} помер!");
                }
            }


            public void Heal(int amount)
            {
                var oldHealth = Health;
                Health += amount;
                Console.WriteLine($"{Name} відновив {Health - oldHealth} HP! (HP: {Health}/{MaxHealth}");
            }
    }
}
