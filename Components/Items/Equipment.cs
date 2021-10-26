namespace Items
{
  public class Equipment {
    public Weapon Weapon { get; set; }
    public Helmet Helmet { get; set; }
    public Chestplate Chestplate { get; set; }
    public Leggins Leggins { get; set; }
    public Boots Boots { get; set; }

    public int Damage => Weapon.Damage;
    public uint Defence => Helmet.Defense + Chestplate.Defense + Leggins.Defense + Boots.Defense;
  }
}
