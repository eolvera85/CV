using System;
using System.Collections.Generic;

namespace CV.DataAccess
{
    public partial class Skills
    {
        public int SkillId { get; set; }
        public int CvId { get; set; }
        public int SkillTypeId { get; set; }
        public int? LogoId { get; set; }
        public string SkillName { get; set; }
        public decimal? Percentage { get; set; }
        public string Detail { get; set; }

        public Curriculums Cv { get; set; }
        public Documents Logo { get; set; }
        public SkillTypes SkillType { get; set; }
    }
}
