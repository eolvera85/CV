using System;
using System.Collections.Generic;

namespace CV.DataAccess
{
    public partial class Educations
    {
        public int EducationId { get; set; }
        public int CvId { get; set; }
        public string SchoolName { get; set; }
        public string Website { get; set; }
        public int? LogoId { get; set; }
        public int DegreeLevelId { get; set; }
        public string DegreeName { get; set; }
        public int DegreeStatusId { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime? FinalDate { get; set; }
        public string Detail { get; set; }

        public Curriculums Cv { get; set; }
        public DegreeLevels DegreeLevel { get; set; }
        public DegreeStatus DegreeStatus { get; set; }
        public Documents Logo { get; set; }
    }
}
