using System;
using System.Collections.Generic;
using System.Text;
using CV.Models;

namespace CV.Services.Contracts
{
    public interface ISkills
    {
        Models.Skills GetSkills(int value);
    }
}
