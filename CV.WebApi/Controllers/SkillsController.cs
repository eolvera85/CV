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
    public class SkillsController : ControllerBase
    {
        ISkills skills;

        public SkillsController(ISkills skills)
        {
            this.skills = skills;
        }

        [HttpGet("{id}")]
        public ActionResult<Curriculum> Get(int id)
        {
            return Ok(skills.GetSkills(id));
        }
    }
}