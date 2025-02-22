using Microsoft.AspNetCore.Mvc;

namespace TraversalRezervasyonApp.ViewComponents.AdminDashboard
{
    public class _DashboardBanner : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
