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
    }
}
