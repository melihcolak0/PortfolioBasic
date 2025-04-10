using _91MY_PortfolioBasic.DAL.Context;
using _91MY_PortfolioBasic.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _91MY_PortfolioBasic.Controllers
{
    public class AdminAboutController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult Index()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAbout(About about)
        {
            context.Abouts.Add(about);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAbout(int id)
        {
            var value = context.Abouts.Find(id);

            if (value != null)
            {
                context.Abouts.Remove(value);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            context.Abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
