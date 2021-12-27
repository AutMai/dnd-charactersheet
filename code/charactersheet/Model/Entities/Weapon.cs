using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class Weapon
    {
        public int WeaponId { get; set; }
        public int DamageDieAmount { get; set; }
        public int DamageDieType { get; set; }
        public string WeaponType { get; set; } = null!;
        public string DamageType { get; set; } = null!;

        public virtual EDamageType DamageTypeNavigation { get; set; } = null!;
        public virtual Item WeaponNavigation { get; set; } = null!;
        public virtual EWeaponType WeaponTypeNavigation { get; set; } = null!;
    }
}
