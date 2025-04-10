using _91MY_PortfolioBasic.DAL.Context;
using _91MY_PortfolioBasic.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _91MY_PortfolioBasic.Controllers
{
    public class ContactController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            message.SendDate = DateTime.Now;
            message.IsRead = false;
            context.Messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("Index", "Default");
        }
    }
}
