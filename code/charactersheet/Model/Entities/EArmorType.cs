using System;
using System.Collections.Generic;

namespace Model.Entities {
    public partial class EArmorType {
        public EArmorType() {
            Armors = new HashSet<Armor>();
            Classes = new HashSet<Class>();
        }

        public string Label { get; set; } = null!;

        public virtual ICollection<Armor> Armors { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
    }
}