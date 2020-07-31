using System;
using System.Collections.Generic;
using System.Text;

namespace CV.Services.Contracts
{
    public interface ICurriculum
    {
        Models.Curriculum GetCurriculum(int value);

        Models.Document GetDocument(int value);
    }
}
