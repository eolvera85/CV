using System;
using System.Collections.Generic;

namespace CV.DataAccess
{
    public partial class SkillTypes
    {
        public SkillTypes()
        {
            Skills = new HashSet<Skills>();
        }

        public int SkillTypeId { get; set; }
        public string SkillTypeDescription { get; set; }

        public ICollection<Skills> Skills { get; set; }
    }
}
