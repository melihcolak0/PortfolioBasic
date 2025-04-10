using _91MY_PortfolioBasic.DAL.Context;
using _91MY_PortfolioBasic.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _91MY_PortfolioBasic.Controllers
{
    public class AdminToDoListController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {
            var values = context.ToDoLists.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddToDoList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddToDoList(ToDoList toDoList)
        {
            toDoList.Status = false;
            context.ToDoLists.Add(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteToDoList(int id)
        {
            var value = context.ToDoLists.Find(id);
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var values = context.ToDoLists.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList toDoList)
        {
            toDoList.Status = false;
            context.Update(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult MakeStatusToTrue(int id)
        {
            var value = context.ToDoLists.Find(id);
            value.Status = true;
            context.Update(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult MakeStatusToFalse(int id)
        {
            var value = context.ToDoLists.Find(id);
            value.Status = false;
            context.Update(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
