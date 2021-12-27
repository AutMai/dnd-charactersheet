﻿namespace Model.Entities
{
    public partial class Race
    {
        public Race()
        {
            Characters = new HashSet<Character>();
            InverseParentRace = new HashSet<Race>();
            LanguageNames = new HashSet<ELanguage>();
            Traits = new HashSet<Trait>();
        }

        public int RaceId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Size { get; set; } = null!;
        public int Speed { get; set; }
        public int? ParentRaceId { get; set; }

        public virtual Race? ParentRace { get; set; }
        public virtual ESize SizeNavigation { get; set; } = null!;
        public virtual ICollection<Character> Characters { get; set; }
        public virtual ICollection<Race> InverseParentRace { get; set; }

        public virtual ICollection<ELanguage> LanguageNames { get; set; }
        public virtual ICollection<Trait> Traits { get; set; }
    }
}