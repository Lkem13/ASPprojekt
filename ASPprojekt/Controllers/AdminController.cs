using ASPprojekt.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


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
            return View(_contex.Users.FirstOrDefault(x => x.Id == id));
        }


        [AllowAnonymous]
        public IActionResult Gosc()
        {
            ViewBag.Mess = "to jest strona dla wszystkich";
            return View();
        }
    }
}
