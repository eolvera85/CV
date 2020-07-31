using System;
using System.Collections.Generic;
using System.Text;
using CV.Models;

namespace CV.Services.Contracts
{
    public interface IAboutMe
    {
        Models.AboutMe GetAboutMe(int value);
    }
}
