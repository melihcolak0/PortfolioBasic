using _91MY_PortfolioBasic.DAL.Context;
using _91MY_PortfolioBasic.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _91MY_PortfolioBasic.Controllers
{
    public class AdminPortfolioController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult Index()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            context.Portfolios.Add(portfolio);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeletePortfolio(int id)
        {
            var value = context.Portfolios.Find(id);

            if (value != null)
            {
                context.Portfolios.Remove(value);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var value = context.Portfolios.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            context.Portfolios.Update(portfolio);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
