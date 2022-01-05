using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities{
    public partial class Character{
        public Character(){
            Abilities = new HashSet<Ability>();
            CharactersHasItems = new HashSet<CharactersHasItem>();
            Names = new HashSet<ELanguage>();
            Personalities = new HashSet<Personality>();
            Spells = new HashSet<Spell>();
        }

        public int CharacterId{ get; set; }
        public string Name{ get; set; } = null!;
        public int RaceId{ get; set; }
        public int ClassId{ get; set; }
        public int BackgroundId{ get; set; }
        public string UserId{ get; set; }
        public int MaxHp{ get; set; }
        public int CurrentHp{ get; set; }
        public int TemporaryHp{ get; set; }
        public sbyte Inspiration{ get; set; }
        public int Xp{ get; set; }
        public int CopperCoins{ get; set; }
        public int Speed{ get; set; }
        public string Alignment{ get; set; } = null!;
        public int ArmorClass{ get; set; }
        public int HitDiceAmount{ get; set; }
        public int DeathSaveSuccessCount{ get; set; }
        public int DeathSaveFailureCount{ get; set; }

        public virtual Background Background{ get; set; } = null!;
        public virtual Class Class{ get; set; } = null!;
        public virtual Race Race{ get; set; } = null!;
        public virtual ApplicationUser ApplicationUser{ get; set; } = null!;
        public virtual ICollection<Ability> Abilities{ get; set; }
        public virtual ICollection<CharactersHasItem> CharactersHasItems{ get; set; }

        public virtual ICollection<ELanguage> Names{ get; set; }
        public virtual ICollection<Personality> Personalities{ get; set; }
        public virtual ICollection<Spell> Spells{ get; set; }
    }
}