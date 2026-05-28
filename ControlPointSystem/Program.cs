using ControlPointSystem.Entity;
using ControlPointSystem.Memento;

namespace ControlPointSystem {
  public class Program {
    public static void Main() {
      int playerHP = 100;
      int playerLevel = 1;
      int lowDamage = 10;
      int fatalDamage = 1000;
      int addLevel = 2;

      Player player = new Player("Daniru", playerHP, playerLevel, "Elucidator");
      CheckPointManager checkPoint = new CheckPointManager();

      // Тестовый сценарий игры
      player.StatusPlayer();

      player.TakeDamage(lowDamage);

      player.StatusPlayer();
      checkPoint.SaveCheckPoint(player.Save());

      player.ChangeName("Bye bye");
      player.ChangeWeapon("Сибирский лук 42-го региона");
      player.LevelUp(addLevel);
      player.TakeDamage(fatalDamage);

      player.StatusPlayer();
      player.Restore(checkPoint.Undo());

      player.StatusPlayer();
    }
  }
}