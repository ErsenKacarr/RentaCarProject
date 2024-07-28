using Microsoft.AspNetCore.Mvc;

namespace RentACar.ViewComponents.LayoutViewComponents
{
    public class _FooterLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
