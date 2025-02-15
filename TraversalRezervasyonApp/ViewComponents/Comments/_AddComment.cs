using Microsoft.AspNetCore.Mvc;

namespace TraversalRezervasyonApp.ViewComponents.Comments
{
    public class _AddComment: ViewComponent
    {
        public IViewComponentResult Invoke(){ 
        return View();
        }
    }
}
