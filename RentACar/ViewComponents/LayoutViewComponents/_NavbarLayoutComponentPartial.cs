using Microsoft.AspNetCore.Mvc;

namespace RentACar.ViewComponents.LayoutViewComponents
{
    public class _NavbarLayoutComponentPartial : ViewComponent
    {
        public  IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
