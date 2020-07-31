using System;
using CV.Services.Contracts;
using System.Linq;
using CV.DataAccess;


namespace CV.Services.Implementation
{
    public class Skills : ISkills
    {
        public Models.Skills GetSkills(int value)
        {
            Models.Skills skills = null;

            using (DB_CVContext db = new DB_CVContext())
            {
                skills = new Models.Skills()
                {
                    Technologies = (from d in db.Skills.Where(x => x.CvId == value && x.SkillTypeId == 3)
                                    select new Models.Programming()
                                    {
                                        Name = d.SkillName,
                                        Percentage = d.Percentage.HasValue ? d.Percentage.Value : 0
                                    }).ToList(),

                    Tools = (from d in db.Skills.Where(x => x.CvId == value && x.SkillTypeId == 2)
                             select new Models.Abilities()
                             {
                                 Name = d.SkillName
                             }).ToList(),

                    Abilities = (from d in db.Skills.Where(x => x.CvId == value && x.SkillTypeId == 4)
                                 select new Models.Abilities()
                                 {
                                     Name = d.SkillName
                                 }).ToList(),

                    Languages = (from d in db.Skills.Where(x => x.CvId == value && x.SkillTypeId == 1)
                                 select new Models.Languages()
                                 {
                                     Logo = d.Logo.DocumentContents,
                                     Name = d.SkillName,
                                     Detail = d.Detail
                                 }).ToList(),
                };

                return skills;
            }
        }
    }
}