using Microsoft.AspNetCore.Mvc;
using Vroom.Models;

namespace Vroom.Controllers
{
    public class MakeController : Controller
    {
        //make/bakes
        public IActionResult Bakes()
        {
            Make make = new Make { Id = 1, Name = "ali" };
            return View(make);
        }
        [Route("make/bakes/{year:int:length(4)}/{month:int:length(1,13)}")]
        public IActionResult ByYearMonth(int year, int month)
        {
            return Content(year + ";" + month);
        }
    }
}
