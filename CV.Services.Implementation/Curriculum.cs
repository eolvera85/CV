using System;
using CV.Services.Contracts;
using System.Linq;
using CV.DataAccess;

namespace CV.Services.Implementation
{
    public class Curriculum : ICurriculum
    {
        public Models.Curriculum GetCurriculum(int value)
        {
            Models.Curriculum curriculum = null;

            using (DB_CVContext db = new DB_CVContext())
            {
                curriculum = (from d in db.Curriculums.Where(x => x.CvId == value)
                              select new Models.Curriculum()
                              {
                                  Id = d.CvId,
                                  Name = (string.IsNullOrEmpty(d.Name01) ? "" : d.Name01) + " " + (string.IsNullOrEmpty(d.Lastname01) ? "" : d.Lastname01),
                                  Title01 = d.Title01,
                                  Title02 = d.Title02
                              }).FirstOrDefault();
            }

            return curriculum;
        }

        public Models.Document GetDocument(int value)
        {
            Models.Document document = null;

            using (DB_CVContext db = new DB_CVContext())
            {
                document = (from d in db.Curriculums.Where(x => x.CvId == value)
                            select new Models.Document()
                            {
                                Id = d.Document.DocumentId,
                                Contents = d.Document.DocumentContents,
                                ContentType = d.Document.DocumentContentType,
                                Name = d.Document.DocumentName
                            }).FirstOrDefault();

            }

            return document;
        }
    }
}
