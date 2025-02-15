using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalRezervasyonApp.Controllers
{
    public class DestinationController : Controller
    {
        readonly DestinationManager destinationManager = new DestinationManager(new EfDestination());
        public IActionResult Index()
        {
          var values=  destinationManager.TGetList();
            return View(values);
        }
        [HttpGet] 
        public IActionResult DestinationDetails(int id)
        {
            ViewBag.i = id;
            var values=destinationManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult DestinationDetail(Destination d)
        {
            return View();
        }
    }
}
