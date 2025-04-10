using _91MY_PortfolioBasic.DAL.Context;
using _91MY_PortfolioBasic.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _91MY_PortfolioBasic.Controllers
{
    public class AdminTestimonialController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult Index()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            context.Testimonials.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);

            if (value != null)
            {
                context.Testimonials.Remove(value);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            context.Testimonials.Update(testimonial);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
