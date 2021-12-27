using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class Class
    {
        public Class()
        {
            Characters = new HashSet<Character>();
            ArmorTypes = new HashSet<EArmorType>();
            EWeaponTypesNames = new HashSet<EWeaponType>();
            Features = new HashSet<Feature>();
            Spells = new HashSet<Spell>();
        }

        public int ClassId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int HitDie { get; set; }

        public virtual ICollection<Character> Characters { get; set; }

        public virtual ICollection<EArmorType> ArmorTypes { get; set; }
        public virtual ICollection<EWeaponType> EWeaponTypesNames { get; set; }
        public virtual ICollection<Feature> Features { get; set; }
        public virtual ICollection<Spell> Spells { get; set; }
    }
}
