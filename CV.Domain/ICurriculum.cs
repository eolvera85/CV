using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CV.Domain
{
    public interface ICurriculum
    {
        Task<Models.Curriculum> GetCurriculum(int value);

        Task<Models.Document> GetDocument(int value);

        Task<Models.AboutMe> GetAboutMe(int value);

        Task<List<Models.Experience>> GetExperiences(int value);

        Task<Models.Formation> GetFormation(int value);

        Task<Models.Skills> GetSkills(int value);

        Task<bool> SaveContact(Models.Contact contact);

    }
}
