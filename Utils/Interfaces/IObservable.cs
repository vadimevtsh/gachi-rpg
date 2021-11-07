using System;

namespace Utils {
  public interface IObservable {
    IDisposable Subscribe(IObserver observer);
  }
}
