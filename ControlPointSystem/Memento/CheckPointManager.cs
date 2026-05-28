namespace ControlPointSystem.Memento {
  public class CheckPointManager {
    private readonly LinkedList<PlayerMemento> _saves = new LinkedList<PlayerMemento>();
    private readonly int _maxStorage = 3;

    public void SaveCheckPoint(PlayerMemento memento) {
      _ = _saves.AddLast(memento);

      if (_saves.Count > _maxStorage) {
        _saves.RemoveFirst();
        Console.WriteLine($"Достигнут лимит сохранений ({_maxStorage}). Самая старая точка удалена");
      }

      Console.WriteLine($"Всего сохранений в памяти: {_saves.Count}\n");
    }

    public PlayerMemento Undo() {
      if (_saves.Count == 0) {
        return null;
      } else {
        Console.WriteLine("Загрузка контрольной точки...\n");

        // Возвращает объект последнего сохранения PlayerMemento
        return _saves.Last.Value;
      }
    }
  }
}