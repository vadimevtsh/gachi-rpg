using System;
using System.Collections.Generic;

namespace Utils {
  public class ComputedProperty<T> : IObserver, IDisposable, IUpdateNotifier {
    public delegate T Compute();
    public ComputedProperty(Compute compute, params IObservable[] dependencies) {
      _compute = compute;

      _isChanged = true;
      _unsubscribers = new List<IDisposable>();

      foreach (IObservable dependency in dependencies) {
        Subscribe(dependency);
      }
    }

    public T Value {
      get {
        if (_isChanged) {
          _computed = _compute.Invoke();
          _isChanged = false;
        }

        return _computed;
      }
    }

    public void SetUpdateAction(Action updateAction) {
      _updateAction = updateAction;
    }

    private bool _isChanged;
    private T _computed;
    private readonly Compute _compute;

    private void Subscribe(IObservable dependency) {
      if (dependency == null) { return; }

      IDisposable unsubscriber = dependency.Subscribe(this);
      if (unsubscriber == null) { return; }

      _unsubscribers.Add(unsubscriber);
    }

    public void OnCompleted() {
      Dispose();
    }

    public void OnNext() {
      _isChanged = true;
      _updateAction?.Invoke();
    }

    public void Dispose() {
      foreach (IDisposable unsubscriber in _unsubscribers) {
        unsubscriber?.Dispose();
      }

      _unsubscribers.Clear();

      GC.SuppressFinalize(this);
    }

    private Action _updateAction;
    private readonly List<IDisposable> _unsubscribers;
  }
}
