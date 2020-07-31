using System;
using System.Collections.Generic;

namespace CV.DataAccess
{
    public partial class ContactInformation
    {
        public ContactInformation()
        {
            Curriculums = new HashSet<Curriculums>();
        }

        public int ContactInformationId { get; set; }
        public string Address01 { get; set; }
        public string Address02 { get; set; }
        public string City { get; set; }
        public int FederalStateId { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }

        public FederalStates FederalState { get; set; }
        public ICollection<Curriculums> Curriculums { get; set; }
    }
}
