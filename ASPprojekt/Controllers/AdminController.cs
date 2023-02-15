using ASPprojekt.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPprojekt.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly ASPDbContext _contex;

        public AdminController(ASPDbContext contex)
        {
            _contex = contex;
        }

        public IActionResult Index()
        {
            ViewBag.Mess = "to jest strona dla zalogowanych";
            return View();
        }

        public IActionResult Users()
        {
            return View(_contex.Users.ToList());
        }

        public IActionResult Edit(string id)
        {
            var items = _contex.Positions.ToList();
            if (items != null)
            {
                ViewBag.data = items;
            }

            var items2 = _contex.Locations.ToList();
            if (items2 != null)
            {
                ViewBag.data2 = items2;
            }
            return View(_contex.Users.FirstOrDefault(x => x.Id == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, ASPprojektUser user, LocationModel location)
        {
            
            try
            {
                ASPprojektUser users = _contex.Users.FirstOrDefault(x => x.Id == id);
                LocationModel locations = _contex.Locations.FirstOrDefault(x => x.LocationId == location.LocationId);

                locations.Town = location.Town;
                locations.Street = location.Street;
                locations.ZipCode = location.ZipCode;

                users.FirstName = user.FirstName;
                users.LastName = user.LastName;
                users.Email = user.Email;
                users.Position = user.Position;
                users.Location = user.Location;
                users.Pesel = user.Pesel;
                await _contex.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                    throw;
                }
                return RedirectToAction(nameof(Users));
 
        }

        [AllowAnonymous]
        public IActionResult Gosc()
        {
            ViewBag.Mess = "to jest strona dla wszystkich";
            return View();
        }
    }
}
