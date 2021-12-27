using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class Dicethrow
    {
        public Dicethrow()
        {
            Spells = new HashSet<Spell>();
            Weapons = new HashSet<Weapon>();
        }

        public int DicethrowId { get; set; }
        public int DiceCount { get; set; }
        public int DiceType { get; set; }

        public virtual ICollection<Spell> Spells { get; set; }
        public virtual ICollection<Weapon> Weapons { get; set; }
    }
}
