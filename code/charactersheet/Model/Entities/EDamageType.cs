using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class EDamageType
    {
        public EDamageType()
        {
            Spells = new HashSet<Spell>();
            Weapons = new HashSet<Weapon>();
        }

        public string Name { get; set; } = null!;

        public virtual ICollection<Spell> Spells { get; set; }
        public virtual ICollection<Weapon> Weapons { get; set; }
    }
}
