using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
