using System;
using System.Collections.Generic;

namespace Utils {
  public class ObservableProperty<T> : IObservable, IDisposable {
    public ObservableProperty(T value) {
      _observers = new List<IObserver>();

      _value = value;

      (value as IUpdateNotifier)?.SetUpdateAction(Notify);
    }

    public T Value {
      get => _value;
      set {
        if (_value.Equals(value)) { return; }

        _value = value;

        Notify();
      }
    }

    private void Notify() {
      foreach (IObserver observer in _observers) {
        observer.OnNext();
      }
    }

    public IDisposable Subscribe(IObserver observer) {
      if (observer == null || _observers.Contains(observer)) { return null; }

      _observers.Add(observer);
      return new Unsubscriber(_observers, observer);
    }

    public void Dispose() {
      foreach (IObserver observer in _observers) {
        observer.OnCompleted();
      }

      _observers.Clear();

      GC.SuppressFinalize(this);
    }

    private class Unsubscriber : IDisposable {
      private readonly List<IObserver> _observers;
      private readonly IObserver _observer;

      public Unsubscriber(List<IObserver> observers, IObserver observer) {
        _observers = observers;
        _observer = observer;
      }

      public void Dispose() {
        if (_observer != null && _observers.Contains(_observer)) {
          _observers.Remove(_observer);
        }
      }
    }

    private readonly List<IObserver> _observers;
    private T _value;
  }
}
