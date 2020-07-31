using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CV.Models;
using CV.Services.Contracts;


namespace CV.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        IContact contact;

        public ContactController(IContact contact)
        {
            this.contact = contact;
        }

        [HttpPost]
        public IActionResult Post(Models.Contact contactMe)
        {
            var result = contact.SaveContact(contactMe);

            return Ok(result);
        }
    }
}