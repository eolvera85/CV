using System;
using System.Collections.Generic;

namespace CV.DataAccess
{
    public partial class WorkExperiences
    {
        public int WorkExperienceId { get; set; }
        public int CvId { get; set; }
        public string CompanyName { get; set; }
        public int? LogoId { get; set; }
        public string Website { get; set; }
        public string Business { get; set; }
        public string JobTitle { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime? FinalDate { get; set; }
        public string Detail { get; set; }

        public Curriculums Cv { get; set; }
        public Documents Logo { get; set; }
    }
}
