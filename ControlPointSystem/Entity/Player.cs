using ControlPointSystem.Memento;

namespace ControlPointSystem.Entity {
  public class Player {
    public string Name { get; private set; }

    public int HP { get; private set; }

    public int Level { get; private set; }

    public string Weapon { get; private set; }

    public Player(string name, int hp, int level, string weapon) {
      Name = name;
      HP = hp;
      Level = level;
      Weapon = weapon;
    }

    public PlayerMemento Save() {
      Console.WriteLine("Сохранение данных...\n");
      return new PlayerMemento(Name, HP, Level, Weapon);
    }

    public void Restore(PlayerMemento memento) {
      if (memento is null) {
        Console.WriteLine("Сохранений нет\n");
        return;
      } else {
        Name = memento.Name;
        HP = memento.HP;
        Level = memento.Level;
        Weapon = memento.Weapon;
      }
    }

    public void TakeDamage(int damage) {
      HP -= damage;

      if (HP <= 0) {
        HP = 0;
        Console.WriteLine($"Игрок {Name} погиб\n");
      } else {
        Console.WriteLine($"Игрок {Name} получил {damage} урона\n");
      }
    }

    public void LevelUp(int addLevel) {
      Level += addLevel;
      Console.WriteLine($"Уровень игрока {Name} был повышен на {addLevel}");
    }

    public void ChangeName(string newName) {
      string pastName = Name;
      Name = newName;
      Console.WriteLine($"Игрок {pastName} изменил своё имя на {Name}");
    }

    public void ChangeWeapon(string newWeapon) {
      Weapon = newWeapon;
      Console.WriteLine($"Игрок {Name} изменил своё оружие на {Weapon}");
    }

    public void StatusPlayer() {
      Console.WriteLine($"Текущие параметры игрока:\n" +
                        $"Имя: {Name}\n" +
                        $"ХП: {HP}\n" +
                        $"Уровень: {Level}\n" +
                        $"Оружие: {Weapon}\n" +
                        $"Нажмите Enter, чтобы продолжить...");
      _ = Console.ReadLine();
    }
  }
}