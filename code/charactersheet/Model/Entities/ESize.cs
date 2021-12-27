using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class ESize
    {
        public ESize()
        {
            Races = new HashSet<Race>();
        }

        public string Label { get; set; } = null!;

        public virtual ICollection<Race> Races { get; set; }
    }
}
