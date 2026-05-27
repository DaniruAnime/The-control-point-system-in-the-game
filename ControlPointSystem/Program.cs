using ControlPointSystem.Entity;
using ControlPointSystem.Memento;

namespace ControlPointSystem {
  public class Program {
    public static void Main() {
      int playerHP = 100;
      int playerLevel = 1;

      Player player = new Player("Daniru", playerHP, playerLevel, "Elucidator");
      CheckPointManager checkPoint = new CheckPointManager();

      player.StatusPlayer();

      player.TakeDamage(10);

      player.StatusPlayer();
      checkPoint.SaveCheckPoint(player.Save());

      player.ChangeName("Bye bye");
      player.ChangeWeapon("Сибирский лук 42-го региона");
      player.LevelUp(2);
      player.TakeDamage(1000);

      player.StatusPlayer();
      player.Restore(checkPoint.Undo());

      player.StatusPlayer();
    }
  }
}