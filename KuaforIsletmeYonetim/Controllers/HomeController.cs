using Microsoft.AspNetCore.Mvc;

namespace KuaforIsletmeYonetim.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
