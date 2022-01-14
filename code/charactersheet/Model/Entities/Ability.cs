using System;
using System.Collections.Generic;

namespace Model.Entities {
    public partial class Ability {
        public Ability() {
            Skills = new HashSet<Skill>();
        }

        public int AbilityId { get; set; }
        public string Name { get; set; } = null!;
        public int AbilityScore { get; set; }
        public sbyte Proficient { get; set; }
        public int CharacterId { get; set; }

        public virtual Character Character { get; set; } = null!;
        public virtual EAbilityName NameNavigation { get; set; } = null!;
        public virtual ICollection<Skill> Skills { get; set; }
    }
}