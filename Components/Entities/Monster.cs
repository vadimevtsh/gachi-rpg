namespace Entities
{
  public abstract class Monster : Creature {

    public Monster(string name, uint strength, uint agility, uint intelligence) : base(name, strength, agility, intelligence) {}
  }
}
