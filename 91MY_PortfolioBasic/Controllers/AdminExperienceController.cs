using _91MY_PortfolioBasic.DAL.Context;
using _91MY_PortfolioBasic.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _91MY_PortfolioBasic.Controllers
{
    public class AdminExperienceController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult Index()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = context.Experiences.Find(id);

            if(value != null)
            {
                context.Experiences.Remove(value);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();           
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = context.Experiences.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            context.Experiences.Update(experience);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
