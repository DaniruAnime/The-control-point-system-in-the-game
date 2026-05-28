namespace ControlPointSystem.View {
  public static class GameLogger {
    public static void LogDamage(string name, int damage, int currentHP) {
      if (currentHP <= 0) {
        Console.WriteLine($"Игрок {name} погиб, получив {damage} урон(а)\n");
      } else {
        Console.WriteLine($"Игрок {name} получил {damage} урон(а)\n");
      }
    }

    public static void LogLevelUp(string name, int addLevel) {
      Console.WriteLine($"Уровень игрока {name} был повышен на {addLevel}\n");
    }

    public static void LogNameChange(string pastName, string newName) {
      Console.WriteLine($"Игрок {pastName} изменил имя на {newName}\n");
    }

    public static void LogWeaponChange(string name, string newWeapon) {
      Console.WriteLine($"Игрок {name} изменил оружие на {newWeapon}\n");
    }

    public static void LogCheckPointSaved(int currentCount) {
      Console.WriteLine($"Сохранение данных...\n" +
                        $"Всего сохранений в памяти: {currentCount}\n");
    }

    public static void LogCheckPointLimitReached(int maxStorage) {
      Console.WriteLine($"Достигнут лимит сохранений ({maxStorage}). Самая старая точка удалена");
    }

    public static void LogCheckPointLoaded() {
      Console.WriteLine("Загрузка контрольной точки...\n");
    }

    public static void LogPlayerStatus(string name, int hp, int level, string weapon) {
      Console.WriteLine($"Текущие параметры игрока:\n" +
                        $"Имя: {name}\n" +
                        $"ХП: {hp}\n" +
                        $"Уровень: {level}\n" +
                        $"Оружие: {weapon}\n" +
                        $"Нажмите Enter, чтобы продолжить...");
      _ = Console.ReadLine();
    }
  }
}