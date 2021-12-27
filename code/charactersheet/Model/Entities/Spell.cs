using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class Spell
    {
        public Spell()
        {
            Characters = new HashSet<Character>();
            Classes = new HashSet<Class>();
        }

        public int SpellId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Level { get; set; }
        public string Range { get; set; } = null!;
        public string Duration { get; set; } = null!;
        public string Components { get; set; } = null!;
        public string DamageType { get; set; } = null!;
        public int DamageDieAmount { get; set; }
        public int DamageDieType { get; set; }

        public virtual EDamageType DamageTypeNavigation { get; set; } = null!;

        public virtual ICollection<Character> Characters { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
    }
}
