using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class Trait
    {
        public Trait()
        {
            Races = new HashSet<Race>();
        }

        public int TraitId { get; set; }
        public string Label { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<Race> Races { get; set; }
    }
}
