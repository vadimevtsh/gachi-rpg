using System;

namespace Utils {
  public interface IUpdateNotifier {
    void SetUpdateAction(Action updateAction);
  }
}
