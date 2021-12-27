using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class Personality
    {
        public Personality()
        {
            Characters = new HashSet<Character>();
        }

        public int PersonalitiesId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<Character> Characters { get; set; }
    }
}
