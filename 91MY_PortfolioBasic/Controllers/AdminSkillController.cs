using _91MY_PortfolioBasic.DAL.Context;
using _91MY_PortfolioBasic.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _91MY_PortfolioBasic.Controllers
{
    public class AdminSkillController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult Index()
        {
            var values = context.Skills.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            context.Skills.Add(skill);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            var value = context.Skills.Find(id);

            if (value != null)
            {
                context.Skills.Remove(value);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var value = context.Skills.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            context.Skills.Update(skill);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
