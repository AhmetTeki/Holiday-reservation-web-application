using Microsoft.AspNetCore.Mvc;

namespace TraversalRezervasyonApp.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
