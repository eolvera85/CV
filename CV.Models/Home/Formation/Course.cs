using System;
using System.Collections.Generic;
using System.Text;

namespace CV.Models
{
    public class Course
    {
        public int Id { get; set; }

        public byte[] Logo { get; set; }

        public string CourseName { get; set; }

        public string TypeCourse { get; set; }

        public string Detail { get; set; }
    }
}
