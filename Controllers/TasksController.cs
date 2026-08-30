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
    }
}
