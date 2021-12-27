using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class Class
    {
        public Class()
        {
            Characters = new HashSet<Character>();
            Features = new HashSet<Feature>();
            Items = new HashSet<Item>();
            Spells = new HashSet<Spell>();
        }

        public int ClassId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int HitDieId { get; set; }

        public virtual Dicethrow HitDie { get; set; } = null!;
        public virtual ICollection<Character> Characters { get; set; }

        public virtual ICollection<Feature> Features { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<Spell> Spells { get; set; }
    }
}
