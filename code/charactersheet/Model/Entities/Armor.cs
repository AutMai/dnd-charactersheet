using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class Armor
    {
        public int ArmorId { get; set; }
        public string ArmorType { get; set; } = null!;
        public int ArmorClass { get; set; }

        public virtual Item ArmorNavigation { get; set; } = null!;
        public virtual EArmorType ArmorTypeNavigation { get; set; } = null!;
    }
}
