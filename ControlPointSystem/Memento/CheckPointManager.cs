using ControlPointSystem.View;

namespace ControlPointSystem.Memento {
  public class CheckPointManager {
    private readonly LinkedList<PlayerMemento> _saves = new LinkedList<PlayerMemento>();
    private readonly int _maxStorage = 3;

    public void SaveCheckPoint(PlayerMemento memento) {
      GameLogger.LogCheckPointSaved(_saves.Count + 1);
      _ = _saves.AddLast(memento);

      if (_saves.Count > _maxStorage) {
        _saves.RemoveFirst();
        GameLogger.LogCheckPointLimitReached(_maxStorage);
      }
    }

    public PlayerMemento Undo() {
      if (_saves.Count == 0) {
        return null;
      } else {
        GameLogger.LogCheckPointLoaded();

        // Возвращает объект последнего сохранения PlayerMemento
        return _saves.Last.Value;
      }
    }
  }
}