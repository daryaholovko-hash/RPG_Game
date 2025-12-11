namespace RPG_Game
{
    public partial interface IEquippable
    {
        string Name { get; }
        void Equip(Player player);

        void Unequip(Player player);
    }
}
