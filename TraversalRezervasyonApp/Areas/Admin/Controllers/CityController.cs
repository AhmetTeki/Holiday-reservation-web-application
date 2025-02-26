using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalRezervasyonApp.Models;

namespace TraversalRezervasyonApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(cities);
            return Json(jsonCity);
        }

        public static List<CityClass> cities = new List<CityClass>
        {
            new CityClass
            {
                CityID = 1,
                CityName="Gerger",
                CityCountry="Türkiye"
            },
            new CityClass
            {
                CityID = 2,
                CityName="Sultangazi",
                CityCountry="Türkiye"
            },
            new CityClass
            {
                CityID = 3,
                CityName="Kabil",
                CityCountry="Afganistan"
            }
        };
    }
}
