using _91MY_PortfolioBasic.DAL.Context;
using _91MY_PortfolioBasic.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _91MY_PortfolioBasic.Controllers
{
    public class AdminFeatureController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult Index()
        {
            var values = context.Features.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddFeature()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddFeature(Feature feature)
        {
            context.Features.Add(feature);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteFeature(int id)
        {
            var value = context.Features.Find(id);

            if (value != null)
            {
                context.Features.Remove(value);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var value = context.Features.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateFeature(Feature feature)
        {
            context.Features.Update(feature);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
