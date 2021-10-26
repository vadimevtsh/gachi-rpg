using System.Collections.Generic;

namespace Items
{
  public class Inventory {
    private readonly List<AbstractItem> _items;

    public uint CurrentWeight { get; private set; }
    public uint Capacity { get; }

    public Inventory(uint capacity) {
      CurrentWeight = 0;
      Capacity = capacity;
    }

    public bool AddItem(AbstractItem item) {
      if (CurrentWeight + item.Weight > Capacity) {
        return false;
      }

      _items.Add(item);
      CurrentWeight += item.Weight;
      return true;
    }
  }
}
