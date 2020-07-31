using System;
using System.Collections.Generic;

namespace CV.DataAccess
{
    public partial class Documents
    {
        public Documents()
        {
            Courses = new HashSet<Courses>();
            CurriculumsDocument = new HashSet<Curriculums>();
            CurriculumsPhoto = new HashSet<Curriculums>();
            Educations = new HashSet<Educations>();
            Skills = new HashSet<Skills>();
            WorkExperiences = new HashSet<WorkExperiences>();
        }

        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
        public byte[] DocumentContents { get; set; }
        public string DocumentContentType { get; set; }

        public ICollection<Courses> Courses { get; set; }
        public ICollection<Curriculums> CurriculumsDocument { get; set; }
        public ICollection<Curriculums> CurriculumsPhoto { get; set; }
        public ICollection<Educations> Educations { get; set; }
        public ICollection<Skills> Skills { get; set; }
        public ICollection<WorkExperiences> WorkExperiences { get; set; }
    }
}
