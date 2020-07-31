using System;
using CV.Services.Contracts;
using System.Linq;
using CV.DataAccess;

namespace CV.Services.Implementation
{
    public class AboutMe : IAboutMe
    {
        public Models.AboutMe GetAboutMe(int value)
        {
            Models.AboutMe aboutMe = null;

            using (DB_CVContext db = new DB_CVContext())
            {
                aboutMe = (from d in db.Curriculums.Where(x => x.CvId == value)
                           select new Models.AboutMe()
                           {
                               Photo = d.Photo.DocumentContents,
                               Summary = d.Summary,
                               Name = d.Name01 + " " + d.Lastname01,
                               PersonalInformation = (d.Gender ? d.Nationality.Nacionalty.Replace("/a", "") : d.Nationality.Nacionalty.Replace("o/a", "a")) + ", " +
                                                     Utilities.GetAge(d.Birthname).ToString() + " años, " +
                                                     (d.Gender ? d.MaritalStatus.MaritalStatusDescription.Replace("/a", "") : d.MaritalStatus.MaritalStatusDescription.Replace("o/a", "a")),
                               Strengths = d.Strengths,
                               Linkedin = d.ContactInformation.Website,
                               Location = d.ContactInformation.City + ", " + d.ContactInformation.FederalState.FederalStateName + " - " + d.ContactInformation.FederalState.Country.CountryName,
                               Email = d.ContactInformation.Email

                           }).FirstOrDefault();
            }

            return aboutMe;
        }

    }
}
