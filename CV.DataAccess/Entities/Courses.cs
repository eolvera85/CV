using System;
using System.Collections.Generic;

namespace CV.DataAccess
{
    public partial class Courses
    {
        public int CourseId { get; set; }
        public int CvId { get; set; }
        public int CourseTypeId { get; set; }
        public int? LogoId { get; set; }
        public string CourseName { get; set; }
        public string Detail { get; set; }

        public CourseTypes CourseType { get; set; }
        public Documents Logo { get; set; }
    }
}
