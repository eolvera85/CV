using System;
using System.Collections.Generic;
using CV.Services.Contracts;
using System.Linq;
using CV.DataAccess;

namespace CV.Services.Implementation
{
    public class Contact : IContact
    {
        public bool SaveContact(Models.Contact contact)
        {
            try
            {
                using (DB_CVContext db = new DB_CVContext())
                {
                    ContactMe contactMe = new ContactMe()
                    {
                        CvId = contact.CvId,
                        Name = contact.Name,
                        Email = contact.Email,
                        Title = contact.Subject,
                        Detail = contact.Body,
                        Sended = false
                    };

                    db.ContactMe.Add(contactMe);
                    db.SaveChanges();
                }
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
