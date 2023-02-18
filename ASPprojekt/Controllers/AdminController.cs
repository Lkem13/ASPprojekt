using ASPprojekt.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPprojekt.Controllers
{

    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ASPDbContext _contex;
        private readonly UserManager<ASPprojektUser> _userManager;

        public AdminController(ASPDbContext contex, UserManager<ASPprojektUser> userManager)
        {
            _contex = contex;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            ViewBag.Mess = "to jest strona dla zalogowanych";
            return View();
        }

        public IActionResult Users()
        {
            return View(_contex.Users
                .Include(p => p.Location)
                .Include(l => l.Position)
                .ToList());
        }

        public async Task<IActionResult> Edit(string id)
        {

            var user = await _contex.Users
                .Include(p => p.Location)
                .Include(l => l.Position)
                .FirstOrDefaultAsync(x => x.Id == id);

            if(user == null)
            {
                return NotFound();
            }
            
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, ASPprojektUser user)
        {
            ASPprojektUser users  = _contex.Users.Include(l => l.Position).Include(p => p.Location).FirstOrDefault(x => x.Id == id);
           // user.Location = _contex.Locations.ToList().FirstOrDefault(x => x.LocationId == user.Location.LocationId);
            try
            {
                 users.FirstName = user.FirstName.ToUpper();
                 users.LastName = user.LastName.ToUpper();
                 users.Email = user.Email;
                 users.Position = user.Position;
                 users.Pesel = user.Pesel;
                 users.Status = user.Status;
                 users.Location = user.Location;



                // _contex.Update(users);
                await _contex.SaveChangesAsync();
                return RedirectToAction(nameof(Users));
            }
            catch
            {
                return View();
            }
        }

        [AllowAnonymous]
        public IActionResult Gosc()
        {
            ViewBag.Mess = "to jest strona dla wszystkich";
            return View();
        }
    }
}
