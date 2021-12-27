using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class EAbilityName
    {
        public EAbilityName()
        {
            Abilities = new HashSet<Ability>();
            ClassesClasses = new HashSet<Class>();
        }

        public string Name { get; set; } = null!;

        public virtual ICollection<Ability> Abilities { get; set; }

        public virtual ICollection<Class> ClassesClasses { get; set; }
    }
}
