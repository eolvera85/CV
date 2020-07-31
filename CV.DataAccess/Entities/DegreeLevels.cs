using System;
using System.Collections.Generic;

namespace CV.DataAccess
{
    public partial class DegreeLevels
    {
        public DegreeLevels()
        {
            Educations = new HashSet<Educations>();
        }

        public int DegreeLevelId { get; set; }
        public string DegreeLevelDescription { get; set; }

        public ICollection<Educations> Educations { get; set; }
    }
}
