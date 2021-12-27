using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class EWeaponType
    {
        public EWeaponType()
        {
            Weapons = new HashSet<Weapon>();
            ClassesClasses = new HashSet<Class>();
        }

        public string Name { get; set; } = null!;

        public virtual ICollection<Weapon> Weapons { get; set; }

        public virtual ICollection<Class> ClassesClasses { get; set; }
    }
}
