using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        public IActionResult Index(int numTimes)
        {
            ViewData["Message"] = "Hip hip hooray!!! :)";
            ViewData["HowManyTimes"] = numTimes;
            return View();
        }

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1, int ID = 3)
        {
            ViewData["Message"] = "Hello " + name + ", ID: " + ID;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
