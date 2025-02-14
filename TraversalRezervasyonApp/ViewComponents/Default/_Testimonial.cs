using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalRezervasyonApp.ViewComponents.Default
{
    public class _Testimonial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
          
            return View();
        }
    }
}
