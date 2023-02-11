using Microsoft.AspNetCore.Mvc;

namespace ASPprojekt.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Mess = "to jest strona dla zalogowanych";
            return View();
        }

        public IActionResult Gosc()
        {
            ViewBag.Mess = "to jest strona dla wszystkich";
            return View();
        }
    }
}
