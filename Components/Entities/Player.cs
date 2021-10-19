namespace Entities
{
  public class Player : Creature {
    private Items.Equipment _equipment;

    // Bulder pattern...
    Player(string name, uint strength, uint agility, uint intelligence) : base(name, strength, agility, intelligence) {}
  }
}
