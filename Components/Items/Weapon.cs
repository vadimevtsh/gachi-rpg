namespace Items
{
  public class Weapon : AbstractItem {
    public bool IsTwoHanded { get; }
    public bool IsMainHanded { get; }
    public uint Range { get; }
    public int Damage { get; }
  }
}
