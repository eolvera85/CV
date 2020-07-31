using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CV.Models
{
    public class Contact
    {
        public int CvId { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [Display(Name = "Asunto")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [Display(Name = "Mensaje")]
        public string Body { get; set; }

    }
}
