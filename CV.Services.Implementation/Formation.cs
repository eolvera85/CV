using System;
using System.Collections.Generic;
using CV.Services.Contracts;
using System.Linq;
using CV.DataAccess;


namespace CV.Services.Implementation
{
    public class Formation : IFormation
    {
        public Models.Formation GetFormation(int value)
        {
            Models.Formation formation = null;

            using (DB_CVContext db = new DB_CVContext())
            {
                formation = new Models.Formation()
                {
                    Educations = (from d in db.Educations.Where(x => x.CvId == value).OrderByDescending(x => x.InitialDate)
                                  select new Models.Education()
                                  {
                                      Logo = d.Logo.DocumentContents,
                                      SchoolName = d.SchoolName,
                                      WebSite = d.Website,
                                      DegreeLevel = d.DegreeLevel.DegreeLevelDescription,
                                      DegreeName = d.DegreeName,
                                      DegreeStatus = d.DegreeStatus.DegreeStatusDescription,
                                      Duration = "(" + d.InitialDate.ToString("MMM yyyy").ToUpper() + " - " + (d.FinalDate.HasValue ? d.FinalDate.Value.ToString("MMM yyyy").ToUpper() : "---") + ")",
                                      Detail = d.Detail
                                  }).ToList(),

                    Courses = (from d in db.Courses.Where(x => x.CvId == value)
                               select new Models.Course()
                               {
                                   Logo = d.Logo.DocumentContents,
                                   CourseName = d.CourseName,
                                   TypeCourse = d.CourseType.CourseTypeDescription,
                                   Detail = d.Detail
                               }).ToList()
                };

                return formation;
            }
        }
    }
}
