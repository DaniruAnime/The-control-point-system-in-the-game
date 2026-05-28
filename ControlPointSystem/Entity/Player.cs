using ControlPointSystem.Memento;
using ControlPointSystem.View;

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
      return new PlayerMemento(Name, HP, Level, Weapon);
    }

    public void Restore(PlayerMemento memento) {
      if (memento is null) {
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
      }

      GameLogger.LogDamage(Name, damage, HP);
    }

    public void LevelUp(int addLevel) {
      Level += addLevel;
      GameLogger.LogLevelUp(Name, addLevel);
    }

    public void ChangeName(string newName) {
      string pastName = Name;
      Name = newName;
      GameLogger.LogNameChange(pastName, Name);
    }

    public void ChangeWeapon(string newWeapon) {
      Weapon = newWeapon;
      GameLogger.LogWeaponChange(Name, Weapon);
    }

    public void StatusPlayer() {
      GameLogger.LogPlayerStatus(Name, HP, Level, Weapon);
    }
  }
}