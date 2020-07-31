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
    public class CurriculumController : ControllerBase
    {
        ICurriculum curriculum;

        public CurriculumController(ICurriculum curriculum)
        {
            this.curriculum = curriculum;
        }

        [HttpGet("{id}")]
        public ActionResult<Curriculum> Get(int id)
        {
            return Ok(curriculum.GetCurriculum(id));
        }

        [HttpGet("document/{id}")]
        public ActionResult<Document> GetDocument(int id)
        {
            return Ok(curriculum.GetDocument(id));
        }
    }
}