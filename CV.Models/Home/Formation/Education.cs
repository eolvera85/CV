using System;
using System.Collections.Generic;
using System.Text;

namespace CV.Models
{
    public class Education
    {
        public int Id { get; set; }

        public byte[] Logo { get; set; }

        public string SchoolName { get; set; }

        public string WebSite { get; set; }

        public string DegreeLevel { get; set; }

        public string DegreeName { get; set; }
        
        public string DegreeStatus { get; set; }

        public string Duration { get; set; }

        public string Detail { get; set; }
    }
}
