using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalRezervasyonApp.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
        FeatureManager _featureManager = new FeatureManager(new EfFeatureDal());

        
        public IViewComponentResult Invoke()
        {
            //var values = _featureManager.TGetList();
            //ViewBag.image1=
            
            return View();
        }
    }
}
