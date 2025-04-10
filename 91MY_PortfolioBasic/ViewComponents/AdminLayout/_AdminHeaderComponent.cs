using Microsoft.AspNetCore.Mvc;

namespace _91MY_PortfolioBasic.ViewComponents.AdminLayout
{
    public class _AdminHeaderComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
