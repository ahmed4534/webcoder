using Microsoft.AspNetCore.Mvc;
namespace CodersCollab.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}