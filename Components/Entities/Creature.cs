using System;

namespace Entities
{
  public abstract class Creature : Entity {
    private static readonly double MOVE_SPEED_MULTIPLIER = 1.2;
    private int _damage;


    private uint _strength;
    private uint _agility;
    private uint _intelligence;

    public Creature(string name, uint strength, uint agility, uint intelligence) : base(name) {
      _strength = strength;
      _agility = agility;
      _intelligence = intelligence;
    }

    public virtual uint MoveSpeed {
      get {
        return (uint)(_agility * MOVE_SPEED_MULTIPLIER);
      }
    }

    public virtual int Damage {
      get {
        return _damage;
      }

      set {
        _damage = value;
      }
    }


    public virtual void DealDamage(IDamagable creature) {
      creature.TakeDamage(Damage);
    }
  }
}
