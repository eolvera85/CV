using System;
using System.Collections.Generic;

namespace CV.DataAccess
{
    public partial class CourseTypes
    {
        public CourseTypes()
        {
            Courses = new HashSet<Courses>();
        }

        public int CourseTypeId { get; set; }
        public string CourseTypeDescription { get; set; }

        public ICollection<Courses> Courses { get; set; }
    }
}
