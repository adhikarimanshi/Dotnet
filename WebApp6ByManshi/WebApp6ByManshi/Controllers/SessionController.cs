using Microsoft.AspNetCore.Mvc;

namespace WebApp6ByManshi.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("uname", "Manshi");
            HttpContext.Session.SetString("pw", "@1003");
            return View();
        }
        public IActionResult SessionPage()
        {
            string uname = HttpContext.Session.GetString("uname").ToString();
            string pw = HttpContext.Session.GetString("pw").ToString();
            ViewBag.username = uname;
            ViewBag.password = pw;
            return View();
        }
    }
}
