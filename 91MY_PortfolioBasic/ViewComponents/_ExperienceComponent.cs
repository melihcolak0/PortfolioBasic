using _91MY_PortfolioBasic.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace _91MY_PortfolioBasic.ViewComponents
{
    public class _ExperienceComponent : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
