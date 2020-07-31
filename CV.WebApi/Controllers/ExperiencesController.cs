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
    public class ExperiencesController : ControllerBase
    {
        IExperience experience;

        public ExperiencesController(IExperience experience)
        {
            this.experience = experience;
        }

        [HttpGet("{id}")]
        public ActionResult<List<Models.Experience>> Get(int id)
        {
            return Ok(experience.GetExperiences(id));
        }
    }
}