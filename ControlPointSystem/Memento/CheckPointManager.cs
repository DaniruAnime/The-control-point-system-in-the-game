namespace ControlPointSystem.Memento {
  public class CheckPointManager {
    private Stack<PlayerMemento> saves = new Stack<PlayerMemento>();

    public void SaveCheckPoint(PlayerMemento memento) {
      saves.Push(memento);
    }

    public PlayerMemento Undo() {
      if (saves.Count == 0) {
        return null;
      } else {
        Console.WriteLine("Загрузка контрольной точки...\n");
        return saves.Peek();
      }
    }
  }
}