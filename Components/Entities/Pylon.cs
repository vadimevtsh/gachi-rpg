namespace Entities
{
	public class Pylon : Entity {
    public Pylon(string name) : base(name) {}

    public Monster Summon() {
      return new Slime();
    }
  }
}
