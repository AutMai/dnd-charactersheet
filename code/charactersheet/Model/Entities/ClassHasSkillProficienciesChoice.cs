using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class ClassHasSkillProficienciesChoice
    {
        public int ClassId { get; set; }
        public string Skill { get; set; } = null!;
        public int Amount { get; set; }

        public virtual Class Class { get; set; } = null!;
        public virtual ESkillName SkillNavigation { get; set; } = null!;
    }
}
