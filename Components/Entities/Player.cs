namespace Entities
{
  public class Player : Creature {
    private Items.Equipment _equipment;
    private Items.Inventory _inventory;

    // Bulder pattern...
    public Player(string name, uint strength, uint agility, uint intelligence) : base(name, strength, agility, intelligence) {

    }
  }
}
