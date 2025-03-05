using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalRezervasyonApp.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        ContactUsManager contactUsManager = new ContactUsManager(new EFContactUsDal());
        public IActionResult Index()
        {
            return View();
        }
    }
}
