using _91MY_PortfolioBasic.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace _91MY_PortfolioBasic.ViewComponents
{
    public class _AboutComponent : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = context.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = context.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetails = context.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();
        }
    }
}
