using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class Feature
    {
        public Feature()
        {
            Classes = new HashSet<Class>();
        }

        public int FeatureId { get; set; }
        public string Label { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Level { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
    }
}
