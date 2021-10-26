using System;

// TODO: Implement builder pattern
namespace Entities {
  public abstract class Entity {
    public ValueTuple<int, int> Coords { get; }
    public string Name { get; }
    public virtual uint Health { get; protected set; }

    public Entity(string name) {
      Name = name;
    }

    public Entity(string name, ValueTuple<int, int> coords) : this(name) {
      Coords = coords;
    }

    public Entity(string name, ValueTuple<int, int> coords, uint health) : this(name, coords) {
      Health = health;
    }
  }
}
