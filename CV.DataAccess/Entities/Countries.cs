using System;
using System.Collections.Generic;

namespace CV.DataAccess
{
    public partial class Countries
    {
        public Countries()
        {
            Curriculums = new HashSet<Curriculums>();
            FederalStates = new HashSet<FederalStates>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string Nacionalty { get; set; }

        public ICollection<Curriculums> Curriculums { get; set; }
        public ICollection<FederalStates> FederalStates { get; set; }
    }
}
