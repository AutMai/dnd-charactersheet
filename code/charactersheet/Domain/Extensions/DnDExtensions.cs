using Model.Entities;

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

    public static string[] AbilitiesSorted { get; } =
        { "STRENGTH", "DEXTERITY", "CONSTITUTION", "INTELLIGENCE", "WISDOM", "CHARISMA" };

    public static int GetAbilityModifier(this int abilityScore) =>
        Convert.ToInt32(Math.Floor(Convert.ToDecimal((abilityScore - 10m) / 2m)));
    
    public static int GetAbilityModifier(this Ability ability) =>
        Convert.ToInt32(Math.Floor(Convert.ToDecimal((ability.AbilityScore - 10m) / 2m)));
    
    public static int ModifierWithPossibleProficiencyBonus(this Ability ability, int proficiencyBonus) {
        var abilityModifier = ability.AbilityScore.GetAbilityModifier();
        if (ability.Proficient == 1) 
            return abilityModifier + 2; // + proficiency bonus
        
        return abilityModifier;
    }
    public static int ModifierWithPossibleProficiencyBonus(this Skill skill, int proficiencyBonus) {
        var abilityModifier = skill.Ability.AbilityScore.GetAbilityModifier();
        if (skill.Proficient == 1) 
            return abilityModifier + 2; // + proficiency bonus
        
        return abilityModifier;
    }
    
    public static string AddSign(this int number) {
        if (Math.Sign(number) == -1) 
            return number.ToString();
        
        return "+" + number;
    }

    public static int GetAttackBonus(this Weapon weapon, ICollection<Ability> abilities, int proficiencyBonus) {
        if (new[] { "DART", "HAND CROSSBOW", "LIGHT CROSSBOW", "SLING", "SHORTBOW", "LONGBOW"}.Contains(weapon.WeaponType)) { // is ranged
            return abilities.SingleOrDefault(a => a.Name == "DEXTERITY").AbilityScore.GetAbilityModifier() + proficiencyBonus;
        }

        return abilities.SingleOrDefault(a => a.Name == "STRENGTH").AbilityScore.GetAbilityModifier() + proficiencyBonus;
    }

    public static Personality PersonalityTraits(this Character character) => character.Personalities.SingleOrDefault(p => p.Name == "Personality Traits");
    public static Personality Ideals(this Character character) => character.Personalities.SingleOrDefault(p => p.Name == "Ideals");
    public static Personality Bonds(this Character character) => character.Personalities.SingleOrDefault(p => p.Name == "Bonds");
    public static Personality Flaws(this Character character) => character.Personalities.SingleOrDefault(p => p.Name == "Flaws");


    
}