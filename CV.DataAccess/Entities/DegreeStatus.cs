using System;
using System.Collections.Generic;

namespace CV.DataAccess
{
    public partial class DegreeStatus
    {
        public DegreeStatus()
        {
            Educations = new HashSet<Educations>();
        }

        public int DegreeStatusId { get; set; }
        public string DegreeStatusDescription { get; set; }

        public ICollection<Educations> Educations { get; set; }
    }
}
