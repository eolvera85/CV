using System;
using System.Collections.Generic;

namespace CV.DataAccess
{
    public partial class ContactMe
    {
        public int ContactId { get; set; }
        public int CvId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public bool Sended { get; set; }

        public Curriculums Cv { get; set; }
    }
}
