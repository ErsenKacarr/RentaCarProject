using Microsoft.AspNetCore.Mvc;

namespace RentACar.ViewComponents.RentACarFilters
{
    public class _RentACarFilterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke(string v)
        {
            v = "aaaa";
            TempData["value"] = v;
            return View();
        }
    }
}
