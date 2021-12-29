using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class Class
    {
        public Class()
        {
            Characters = new HashSet<Character>();
            ClassHasSkillProficienciesChoices = new HashSet<ClassHasSkillProficienciesChoice>();
            AbilityNames = new HashSet<EAbilityName>();
            ArmorTypes = new HashSet<EArmorType>();
            Features = new HashSet<Feature>();
            Spells = new HashSet<Spell>();
            WeaponTypes = new HashSet<EWeaponType>();
        }

        public int ClassId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int HitDie { get; set; }

        public virtual ICollection<Character> Characters { get; set; }
        public virtual ICollection<ClassHasSkillProficienciesChoice> ClassHasSkillProficienciesChoices { get; set; }

        public virtual ICollection<EAbilityName> AbilityNames { get; set; }
        public virtual ICollection<EArmorType> ArmorTypes { get; set; }
        public virtual ICollection<Feature> Features { get; set; }
        public virtual ICollection<Spell> Spells { get; set; }
        public virtual ICollection<EWeaponType> WeaponTypes { get; set; }
    }
}
