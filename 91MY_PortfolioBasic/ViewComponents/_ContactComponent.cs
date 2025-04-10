using _91MY_PortfolioBasic.DAL.Context;
using _91MY_PortfolioBasic.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _91MY_PortfolioBasic.ViewComponents
{
    public class _ContactComponent : ViewComponent
    {       
        public IViewComponentResult Invoke()
        {
            return View();
        }        
    }
}
