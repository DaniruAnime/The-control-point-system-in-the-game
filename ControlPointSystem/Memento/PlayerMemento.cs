namespace ControlPointSystem.Memento {
  public class PlayerMemento {
    public string Name { get; }

    public int HP { get; }

    public int Level { get; }

    public string Weapon { get; }

    public PlayerMemento(string name, int hp, int level, string weapon) {
      Name = name;
      HP = hp;
      Level = level;
      Weapon = weapon;
    }
  }
}