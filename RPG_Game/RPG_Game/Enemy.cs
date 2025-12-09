using static RPG_Game.IEquippable;

namespace RPG_Game
{
    public abstract class Enemy : Characer
    {

        private int _expertienceReward;
        private List<Item> _loot;

        public int ExpertienceReward
        {
            get => _expertienceReward;
            protected set => _expertienceReward = value;
        }
        protected Enemy(string name, int health, int srtrenght, int expertienceReward) : base(name, health, srtrenght)
        {
            _expertienceReward = expertienceReward;
            _loot = new List<Item>();
        }
        protected void AddLoot(Item item)
        {
            _loot.Add(item);
        }

        public List<Item> GetLoot()
        {
            return new List<Item>(_loot); 
        }
    }
}
