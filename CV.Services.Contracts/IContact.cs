using System;
using System.Collections.Generic;
using System.Text;
using CV.Models;


namespace CV.Services.Contracts
{
    public interface IContact
    {
        bool SaveContact(Models.Contact contact);
    }
}
