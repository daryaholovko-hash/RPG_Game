using static RPG_Game.IEquippable;

namespace RPG_Game
{
    public interface ISpellCaster
    {
        int Mana { get; }
        void CastSpell(Characer target);
        void RestoreMana(int amount);
    }
}
