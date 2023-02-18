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
        private readonly ASPDbContext _context;
        private readonly UserManager<ASPprojektUser> _userManager;

        public AdminController(ASPDbContext context, UserManager<ASPprojektUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            ViewBag.Mess = "to jest strona dla zalogowanych";
            return View();
        }

        public IActionResult Users()
        {
            return View(_context.Users
                .Include(p => p.Location)
                .Include(l => l.Position)
                .ToList());
        }

        public async Task<IActionResult> Edit(string id)
        {

            var user = await _context.Users
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
            ASPprojektUser users  = _context.Users.Include(l => l.Position).Include(p => p.Location).FirstOrDefault(x => x.Id == id);
           // user.Location = _contex.Locations.ToList().FirstOrDefault(x => x.LocationId == user.Location.LocationId);
            try
            {
                 users.FirstName = user.FirstName.ToUpper();
                 users.LastName = user.LastName.ToUpper();
                 users.Email = user.Email;
                users.Position = _context.Positions.ToList().FirstOrDefault(x => x.PositionId == user.Position.PositionId);
                 users.Pesel = user.Pesel;
                 users.Status = user.Status;
                if (users.Location == null)
                {
                    users.Location = new LocationModel();
                }
                users.Location.Town = user.Location.Town;
                users.Location.Street = user.Location.Street;



                _context.Update(users);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Users));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Plan()
        {
            return View(_context.PlanModels
                .Include(u => u.ASPprojektUser)
                .ToList());
        }

        public ActionResult CreatePlan()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePlan(PlanModel plan)
        {
            var user = await _userManager.GetUserAsync(User);

            plan.ASPprojektUser = user;

            _context.Add(plan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Plan));

        }

        public async Task<IActionResult> EditPlan(int id)
        {

            var plan = await _context.PlanModels
               .Include(u => u.ASPprojektUser)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (plan == null)
            {
                return NotFound();
            }

            return View(plan);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPlan(int id, PlanModel plan)
        {
            PlanModel plans = _context.PlanModels
                .Include(u => u.ASPprojektUser)
                .FirstOrDefault(x => x.Id == id);
            try
            {
                var user = await _userManager.GetUserAsync(User);

                plans.ASPprojektUser = user;
                plans.ShiftStart = plan.ShiftStart;
                plans.ShiftEnd = plan.ShiftEnd;
                plans.ShiftDay = plan.ShiftDay;

                _context.Update(plans);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Users));
            }
            catch
            {
                return View();
            }
        }
    }
}
