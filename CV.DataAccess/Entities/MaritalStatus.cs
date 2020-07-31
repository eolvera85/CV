using System;
using System.Collections.Generic;

namespace CV.DataAccess
{
    public partial class MaritalStatus
    {
        public MaritalStatus()
        {
            Curriculums = new HashSet<Curriculums>();
        }

        public int MaritalStatusId { get; set; }
        public string MaritalStatusDescription { get; set; }

        public ICollection<Curriculums> Curriculums { get; set; }
    }
}
