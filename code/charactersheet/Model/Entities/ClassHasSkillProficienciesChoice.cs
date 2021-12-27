using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class ClassHasSkillProficienciesChoice
    {
        public int ClassId { get; set; }
        public string SkillName { get; set; } = null!;
        public int Amount { get; set; }

        public virtual Class Class { get; set; } = null!;
        public virtual ESkillName SkillNameNavigation { get; set; } = null!;
    }
}
