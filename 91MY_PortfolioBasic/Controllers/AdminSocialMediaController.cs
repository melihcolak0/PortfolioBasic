using _91MY_PortfolioBasic.DAL.Context;
using _91MY_PortfolioBasic.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _91MY_PortfolioBasic.Controllers
{
    public class AdminSocialMediaController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult Index()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia socialMedia)
        {
            context.SocialMedias.Add(socialMedia);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            var value = context.SocialMedias.Find(id);

            if (value != null)
            {
                context.SocialMedias.Remove(value);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var value = context.SocialMedias.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            context.SocialMedias.Update(socialMedia);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
