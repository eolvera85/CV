using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CV.Domain;
using CV.WebMVC.Models;

namespace CV.WebMVC.Controllers
{
    public class HomeController : Controller
    {
        Domain.ICurriculum curriculum;

        public HomeController()
        {
            curriculum = new Domain.Curriculum();
        }

        public async Task<ActionResult> Index()
        {
            var _cv = await curriculum.GetCurriculum(1);

            if (_cv != null)
            {
                return View(_cv);
            }

            return RedirectToAction("Error", "Home");
        }

        public async Task<FileResult> Download()
        {
            var _document = await curriculum.GetDocument(1);

            return File(_document.Contents, _document.ContentType, _document.Name);
        }

        public async Task<ActionResult> AboutMe()
        {
            var _about = await curriculum.GetAboutMe(1);

            if (_about != null)
            {
                return View(_about);
            }

            return RedirectToAction("Error", "Home");
        }

        public async Task<ActionResult> Experience()
        {
            var experiences = await curriculum.GetExperiences(1);

            return View(experiences);
        }

        public async Task<ActionResult> Education()
        {
            var formation = await curriculum.GetFormation(1);

            return View(formation);
        }

        public async Task<ActionResult> Skills()
        {
            var skills = await curriculum.GetSkills(1);

            return View(skills);
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Contact(CV.Models.Contact contact)
        {
            if (ModelState.IsValid)
            {
                var result = await curriculum.SaveContact(contact);

                if (result)
                {
                    TempData["Success"] = contact.Name;
                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
