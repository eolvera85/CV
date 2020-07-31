using System;
using System.Collections.Generic;
using CV.Services.Contracts;
using System.Linq;
using CV.DataAccess;


namespace CV.Services.Implementation
{
    public class Experience : IExperience
    {
        public List<Models.Experience> GetExperiences(int value)
        {
            List<Models.Experience> experiences = new List<Models.Experience>();

            using (DB_CVContext db = new DB_CVContext())
            {
                experiences = (from d in db.WorkExperiences.Where(x => x.CvId == value).OrderByDescending(x => x.InitialDate)
                               select new Models.Experience()
                               {
                                   Logo = d.Logo.DocumentContents,
                                   CompanyName = d.CompanyName,
                                   WebSite = d.Website,
                                   Bussiness = d.Business,
                                   JobTitle = d.JobTitle,
                                   Duration = "(" + d.InitialDate.ToString("MMM yyyy").ToUpper() + " - " + (d.FinalDate.HasValue ? d.FinalDate.Value.ToString("MMM yyyy").ToUpper() : "Actual") + ")",
                                   Detail = d.Detail
                               }).ToList();
            }

            return experiences;
        }
    }
}
