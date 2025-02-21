using Microsoft.AspNetCore.Mvc;

namespace TraversalRezervasyonApp.ViewComponents.MemberDashboard
{
    public class _PlatformSetting: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
