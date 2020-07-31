using System;
using System.Collections.Generic;

namespace CV.DataAccess
{
    public partial class Curriculums
    {
        public Curriculums()
        {
            ContactMe = new HashSet<ContactMe>();
            Educations = new HashSet<Educations>();
            Skills = new HashSet<Skills>();
            WorkExperiences = new HashSet<WorkExperiences>();
        }

        public int CvId { get; set; }
        public string Name01 { get; set; }
        public string Name02 { get; set; }
        public string Lastname01 { get; set; }
        public string Lastname02 { get; set; }
        public DateTime Birthname { get; set; }
        public bool Gender { get; set; }
        public string Title01 { get; set; }
        public string Title02 { get; set; }
        public string Summary { get; set; }
        public string Strengths { get; set; }
        public string Hobbies { get; set; }
        public int NationalityId { get; set; }
        public int MaritalStatusId { get; set; }
        public int? ContactInformationId { get; set; }
        public int? DocumentId { get; set; }
        public int? PhotoId { get; set; }
        public bool Active { get; set; }

        public ContactInformation ContactInformation { get; set; }
        public Documents Document { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Countries Nationality { get; set; }
        public Documents Photo { get; set; }
        public ICollection<ContactMe> ContactMe { get; set; }
        public ICollection<Educations> Educations { get; set; }
        public ICollection<Skills> Skills { get; set; }
        public ICollection<WorkExperiences> WorkExperiences { get; set; }
    }
}
