using Microsoft.AspNetCore.Mvc;

namespace TraversalRezervasyonApp.Areas.Member.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
