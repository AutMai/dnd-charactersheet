using System;
using System.Collections.Generic;

namespace Model.Entities {
    //The partial keyword indicates that other parts of the class, struct, or interface can be defined in the namespace.
    public partial class Ability {
        public Ability() {
            //HashSet keine doppelten Werte
            /*
             * A HashSet is usually the semantically correct collection type.
             *  Most collections should only have one instance of a member (no duplicates)
             */
            Skills = new HashSet<Skill>();
        }

        public int AbilityId { get; set; }
        //This operator basically turns off the compiler null checks for this usage.
        public string Name { get; set; } = null!;
        public int AbilityScore { get; set; }
        //The SByte value type represents integers with values ranging from negative 128 to positive 127.
        public sbyte Proficient { get; set; }
        public int CharacterId { get; set; }

        //The virtual keyword is used to modify a method, property, indexer,
        //or event declaration and allow for it to be overridden in a derived class.
        //For example, this method can be overridden by any class that inherits it
        public virtual Character Character { get; set; } = null!;
        public virtual EAbilityName NameNavigation { get; set; } = null!;
        //Liste für Objekte zu durchgehen und ändern
        public virtual ICollection<Skill> Skills { get; set; }
    }
}