using _91MY_PortfolioBasic.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace _91MY_PortfolioBasic.Controllers
{
    public class MessageController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult Index()
        {
            var values = context.Messages.ToList();
            return View(values);
        }

        public IActionResult MakeIsReadToTrue(int id)
        {
            var value = context.Messages.Find(id);
            value.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult MakeIsReadToFalse(int id)
        {
            var value = context.Messages.Find(id);
            value.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = context.Messages.Find(id);
            context.Messages.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult MessageDetail(int id)
        {
            var value = context.Messages.Find(id);
            return View(value);
        }
    }
}
