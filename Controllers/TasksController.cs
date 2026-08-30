using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace vs.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult SprintTasks()
        {
            return View();
        }
        public IActionResult Greetings()
        {
            return View();
        }

        public IActionResult SuperMarkets()
        {
            List<string> markets = new List<string>
            {
                "WellMart",
                "Silpo",
                "ATB",
                "Furshet",
                "Metro"
            };

            ViewBag.SuperMarkets = markets;
            return View();
        }
        public IActionResult ProductInfo()
        {
            return View();
        }
        public IActionResult ShoppingList()
        {
            Dictionary<string, int> shoppingList = new Dictionary<string, int>
            {
                 { "Milk", 2 },
                 { "Bread", 2 },
                 { "Cake", 1 },
                 { "Ice Cream", 5 },
                 { "Cola", 10 }
            };

            return View(shoppingList);
        }
    }
}
