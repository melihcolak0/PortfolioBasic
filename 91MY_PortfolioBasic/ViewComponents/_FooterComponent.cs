using Microsoft.AspNetCore.Mvc;

namespace _91MY_PortfolioBasic.ViewComponents
{
    public class _FooterComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
