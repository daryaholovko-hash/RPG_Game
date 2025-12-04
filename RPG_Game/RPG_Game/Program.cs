namespace RPG_Game
{
    public partial interface IEquippable
    {
        string Name { get; }
        void Equip();

        void Unequip();
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
