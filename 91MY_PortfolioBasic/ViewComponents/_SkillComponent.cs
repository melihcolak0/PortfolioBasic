using _91MY_PortfolioBasic.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace _91MY_PortfolioBasic.ViewComponents
{
    public class _SkillComponent : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}
