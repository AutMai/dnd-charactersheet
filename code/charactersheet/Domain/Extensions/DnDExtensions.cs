namespace Domain.Extensions;

public static class DnDExtensions {
    private static Random _random = new Random();

    public static List<int> RollDice(int amount, int type, bool dropLowest = false) {
        List<int> rolls = new List<int>();
        for (int i = 0; i < amount; i++) {
            rolls.Add(_random.Next(1, type + 1));
        }

        if (dropLowest) 
            rolls.Remove(rolls.Min());
        
        return rolls;
    }

    public static string[] AbilitiesSorted { get; } = { "STRENGTH", "DEXTERITY", "CONSTITUTION", "INTELLIGENCE", "WISDOM", "CHARISMA" };
}