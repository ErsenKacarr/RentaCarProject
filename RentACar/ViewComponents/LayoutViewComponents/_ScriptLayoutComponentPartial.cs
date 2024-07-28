using Microsoft.AspNetCore.Mvc;

namespace RentACar.ViewComponents.LayoutViewComponents
{
    public class _ScriptLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
