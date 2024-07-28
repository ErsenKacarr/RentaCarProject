using Microsoft.AspNetCore.Mvc;
using RentACar.CQRS.Handlers.CarHandlers;
using RentACar.CQRS.Results.CarResults;
using RentACar.DAL;

namespace RentACar.ViewComponents.DefaultViewComponents
{
    public class _DefaultLastCarsWithBrandsComponentPartial : ViewComponent
    {
        private readonly GetCarWithBrandQueryHandler _getCarWithBrandQueryHandler;

        public _DefaultLastCarsWithBrandsComponentPartial(GetCarWithBrandQueryHandler getCarWithBrandQueryHandler)
        {
            _getCarWithBrandQueryHandler = getCarWithBrandQueryHandler;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = _getCarWithBrandQueryHandler.Handle();
            return View(values);
        }
    }
}
