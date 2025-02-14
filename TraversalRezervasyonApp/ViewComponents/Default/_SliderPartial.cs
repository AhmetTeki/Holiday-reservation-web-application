using Microsoft.AspNetCore.Mvc;

namespace TraversalRezervasyonApp.ViewComponents.Default
{
    public class _SliderPartial: ViewComponent
    {
        public IViewComponentResult Invoke() { 
            return View();
            
        }

    }
}
