﻿using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalRezervasyonApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        private readonly IAppUserService _userService;
        private readonly IReservationService _reservationService;

        public UsersController(IAppUserService userService, IReservationService reservationService)
        {
            _userService = userService;
            _reservationService = reservationService;
        }

        public IActionResult Index()
        {
           var values= _userService.TGetList();
            return View(values);
        }
        public IActionResult DeleteUser(int id)
        {
            var values = _userService.TGetById(id);
            _userService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var values = _userService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditUser(AppUser appUser)
        {
           _userService.TUpdate(appUser);
            return RedirectToAction("Index");
        }
        public IActionResult CommentUser(int id)
        {
            _userService.TGetList();
            return RedirectToAction("Index");
        }
        public IActionResult RezervationUser(int id)
        {
         var values= _reservationService.GetListWithReservationByAccepted(id);
            return View(values);
        }
    }
}
