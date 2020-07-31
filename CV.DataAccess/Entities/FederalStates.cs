using System;
using System.Collections.Generic;

namespace CV.DataAccess
{
    public partial class FederalStates
    {
        public FederalStates()
        {
            ContactInformation = new HashSet<ContactInformation>();
        }

        public int FederalStateId { get; set; }
        public string FederalStateName { get; set; }
        public int CountryId { get; set; }

        public Countries Country { get; set; }
        public ICollection<ContactInformation> ContactInformation { get; set; }
    }
}
