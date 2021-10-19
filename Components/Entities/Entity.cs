using System;

// TODO: Implement builder pattern
namespace Entities {
  public abstract class Entity {
    private ValueTuple<int, int> _coords;
    private string _name;

    public Entity(string name) => _name = name;
    public Entity(string name, ValueTuple<int, int> coords) : this(name) => _coords = coords;

    public string Name {
      get {
        return _name;
      }
    }

    public ValueTuple<int, int> Coords {
      get {
        return _coords;
      }
    }
  }
}
