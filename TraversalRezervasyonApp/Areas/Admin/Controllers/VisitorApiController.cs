using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalRezervasyonApp.Areas.Admin.Models;

namespace TraversalRezervasyonApp.Areas.Admin.Controllers
{
    public class VisitorApiController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public VisitorApiController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5126/api/Visitor");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData =await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<VisitorViewModel>>(jsonData);
            }
            return View();
        }
    }
}
