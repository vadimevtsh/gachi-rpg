using System;

namespace Entities
{
  public interface IMovable
  {
    void Move(ValueTuple<float, float> direction);
  }
}
