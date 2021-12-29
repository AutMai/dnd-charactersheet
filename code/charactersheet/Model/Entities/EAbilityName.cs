using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class EAbilityName
    {
        public EAbilityName()
        {
            Abilities = new HashSet<Ability>();
            RaceHasAbilityScoreIncreases = new HashSet<RaceHasAbilityScoreIncrease>();
            Classes = new HashSet<Class>();
            SkillNames = new HashSet<ESkillName>();
        }

        public string Name { get; set; } = null!;

        public virtual ICollection<Ability> Abilities { get; set; }
        public virtual ICollection<RaceHasAbilityScoreIncrease> RaceHasAbilityScoreIncreases { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<ESkillName> SkillNames { get; set; }
    }
}
