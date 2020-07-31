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
    public class AboutMeController : ControllerBase
    {
        IAboutMe aboutMe;

        public AboutMeController(IAboutMe aboutMe)
        {
            this.aboutMe = aboutMe;
        }

        [HttpGet("{id}")]
        public ActionResult<Curriculum> Get(int id)
        {
            return Ok(aboutMe.GetAboutMe(id));
        }
    }
}