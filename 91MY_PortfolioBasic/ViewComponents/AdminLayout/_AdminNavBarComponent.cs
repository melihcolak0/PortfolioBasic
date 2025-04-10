using _91MY_PortfolioBasic.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace _91MY_PortfolioBasic.ViewComponents.AdminLayout
{
    public class _AdminNavBarComponent : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.unDoneCount = context.ToDoLists.Where(y => y.Status == false).Count();
            var value = context.ToDoLists.Where(x => x.Status == false).ToList();
            return View(value);
        }
    }
}
