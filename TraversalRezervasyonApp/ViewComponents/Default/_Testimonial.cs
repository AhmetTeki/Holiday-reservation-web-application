using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalRezervasyonApp.ViewComponents.Default
{
    public class _Testimonial:ViewComponent
    {
        TestimonialManager manager = new TestimonialManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
          var result=manager.TGetList();
            return View(result);
        }
    }
}
