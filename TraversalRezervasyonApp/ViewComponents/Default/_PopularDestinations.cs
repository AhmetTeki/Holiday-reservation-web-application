using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalRezervasyonApp.ViewComponents.Default
{
    public class _PopularDestinations:ViewComponent
    {
        readonly DestinationManager destinationManager = new DestinationManager(new EfDestination());
        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }
    }
}
