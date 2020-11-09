using Microsoft.AspNetCore.Mvc;
using Quiz_22OCT.Models;
using System.Linq;

namespace Quiz_22OCT.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult InputPage()
        {
            return View();
        }
        [HttpPost]
        
        public ViewResult InputPage(User guestResponse) 
        {

            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);

        }

        
    }
}