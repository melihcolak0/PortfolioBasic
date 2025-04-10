using _91MY_PortfolioBasic.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace _91MY_PortfolioBasic.ViewComponents
{
    public class _StatisticsComponent : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.totalExperience = 6;
            ViewBag.skillCount = context.Skills.Count();
            ViewBag.portfolioCount = context.Portfolios.Count();
            ViewBag.socialMediaCount = context.SocialMedias.Count();
            return View();
        }
    }
}
