using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class ESkillName
    {
        public ESkillName()
        {
            ClassHasSkillProficienciesChoices = new HashSet<ClassHasSkillProficienciesChoice>();
            Skills = new HashSet<Skill>();
        }

        public string Name { get; set; } = null!;

        public virtual ICollection<ClassHasSkillProficienciesChoice> ClassHasSkillProficienciesChoices { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
    }
}
