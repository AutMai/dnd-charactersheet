using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class ESkillName
    {
        public ESkillName()
        {
            Skills = new HashSet<Skill>();
        }

        public string Name { get; set; } = null!;

        public virtual ICollection<Skill> Skills { get; set; }
    }
}
