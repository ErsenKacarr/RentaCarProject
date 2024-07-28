using Microsoft.AspNetCore.Mvc;

namespace RentACar.ViewComponents.LayoutViewComponents
{
    public class _HeadLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
