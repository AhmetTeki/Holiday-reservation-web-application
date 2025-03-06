using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Versioning;
using TraversalRezervasyonApp.Areas.Admin.Models;

namespace TraversalRezervasyonApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values=_roleManager.Roles.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            AppRole role=new AppRole()
            {
                Name=model.RoleName
            };
            var result=await _roleManager.CreateAsync(role);
            if (result.Succeeded) 
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
            
        }
        public async Task<IActionResult> DeleteRole(int id)
        {
            var values=_roleManager.Roles.FirstOrDefault(x => x.Id == id);  
            await _roleManager.DeleteAsync(values);
            return RedirectToAction("Index");
        }
        public IActionResult UserList()
        {
            var values=_userManager.Users.ToList();
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user=_userManager.Users.FirstOrDefault(x => x.Id == id);
            TempData["UserId"]=user.Id;
            var roles = _roleManager.Roles.ToList();
            var userRoles=await _userManager.GetRolesAsync(user);
            List<RoleAssignViewModel> assignments= new List<RoleAssignViewModel>();
            foreach (var role in roles)
            {
                RoleAssignViewModel model = new RoleAssignViewModel();
                model.RoleName = role.Name;
                model.RoleId = role.Id;
                model.RoleExist = userRoles.Contains(role.Name);
                assignments.Add(model);
            }
            return View(assignments);
        }
        [HttpPost]
        public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> model)
        {
            var userId =(int)TempData["UserId"];
            var user=_userManager.Users.FirstOrDefault(x=>x.Id==userId);
            foreach (var role in model)
            {
                if (role.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user, role.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, role.RoleName);
                }
                
            }
            return RedirectToAction("UserList");
        }
    }
}
