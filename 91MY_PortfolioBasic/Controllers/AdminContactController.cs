using _91MY_PortfolioBasic.DAL.Context;
using _91MY_PortfolioBasic.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _91MY_PortfolioBasic.Controllers
{
    public class AdminContactController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult Index()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteContact(int id)
        {
            var value = context.Contacts.Find(id);

            if (value != null)
            {
                context.Contacts.Remove(value);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var value = context.Contacts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            context.Contacts.Update(contact);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
