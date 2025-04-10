using _91MY_PortfolioBasic.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace _91MY_PortfolioBasic.Controllers
{
    public class AdminStatisticsController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {
            ViewBag.skillCount = context.Skills.Count();
            ViewBag.messageCount = context.Messages.Count();
            ViewBag.readMessageCount = context.Messages.Where(x => x.IsRead == true).Count();
            ViewBag.unreadMessageCount = context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.portfolioCount = context.Portfolios.Count();
            ViewBag.socialMediaCount = context.SocialMedias.Count();
            ViewBag.testimonialCount = context.Testimonials.Count();
            ViewBag.toDoListCount = context.ToDoLists.Count();
            ViewBag.doneToDoListCount = context.ToDoLists.Where(x => x.Status == true).Count();
            ViewBag.unDoneToDoListCount = context.ToDoLists.Where(x => x.Status == false).Count();
            ViewBag.aboutCount = context.Abouts.Count();
            ViewBag.contactCount = context.Contacts.Count();
            ViewBag.experienceCount = context.Experiences.Count();
            ViewBag.featureCount = context.Features.Count();

            return View();
        }
    }
}
