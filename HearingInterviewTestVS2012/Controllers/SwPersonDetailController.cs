using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HearingInterviewTest.Models;
using SharpTrooper.Core;
using SharpTrooper.Entities;

namespace HearingInterviewTest.Controllers
{
    public class SwPersonDetailController : Controller
    {
        // GET: SwPersonDetail
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public ViewResult SwPersonDetail(string id)
        {
            SharpTrooperCore st = new SharpTrooperCore();

            var coreRet = st.GetPeople(id);
            var homeWorldRet = st.GetSingleByUrl<Planet>(coreRet.homeworld);

            List<string> filmTitles = new List<string>();
            var index = 0;
            foreach (var url in coreRet.films)
            {
                var filmRet = st.GetSingleByUrl<Film>(coreRet.films[index]);
                filmTitles.Add(filmRet.title + (coreRet.films.Count > 1 && index+1 != coreRet.films.Count ? ", " : "."));
                index++;
            }

            SwPersonDetailVM details = new SwPersonDetailVM()
            {
                name = coreRet.name,
                gender = coreRet.gender,
                homeworld = homeWorldRet.name,
                films = filmTitles,
                height = coreRet.height + " m",
                mass = coreRet.mass + " kg",
                skin_color = coreRet.skin_color,
                eye_color = coreRet.eye_color,
                birth_year = coreRet.birth_year
            };
            return View(details);
        }
    }
}