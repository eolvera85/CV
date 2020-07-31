using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CV.Models
{
    public class AboutMe
    {
        public int Id { get; set; }

        public byte[] Photo { get; set; }

        public string Summary { get; set; }

        [Display(Name="Nombre")]
        public string Name { get; set; }

        [Display(Name = "Personal")]
        public string PersonalInformation { get; set; }

        [Display(Name = "Fortalezas")]
        public string Strengths { get; set; }

        [DataType(DataType.Url)]
        public string Linkedin { get; set; }

        [Display(Name = "Ubicación")]
        public string Location { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
