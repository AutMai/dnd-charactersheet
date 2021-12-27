namespace Model.Entities
{
    public partial class Character
    {
        public Character()
        {
            Abilities = new HashSet<Ability>();
            CharactersHasItems = new HashSet<CharactersHasItem>();
            Names = new HashSet<ELanguage>();
            Personalities = new HashSet<Personality>();
            Spells = new HashSet<Spell>();
        }

        public int CharacterId { get; set; }
        public string Name { get; set; } = null!;
        public int RaceId { get; set; }
        public int ClassId { get; set; }
        public int BackgroundId { get; set; }
        public int MaxHp { get; set; }
        public int CurrentHp { get; set; }
        public int TemporaryHp { get; set; }
        public sbyte Inspiration { get; set; }
        public int Xp { get; set; }
        public int BronzeCoins { get; set; }
        public int Speed { get; set; }
        public string Alignment { get; set; } = null!;
        public int HitDice { get; set; }
        public int ArmorClass { get; set; }

        public virtual Background Background { get; set; } = null!;
        public virtual Class Class { get; set; } = null!;
        public virtual Race Race { get; set; } = null!;
        public virtual DeathSafe DeathSafe { get; set; } = null!;
        public virtual ICollection<Ability> Abilities { get; set; }
        public virtual ICollection<CharactersHasItem> CharactersHasItems { get; set; }
        public virtual ICollection<ELanguage> Names { get; set; }
        public virtual ICollection<Personality> Personalities { get; set; }
        public virtual ICollection<Spell> Spells { get; set; }
    }
}
