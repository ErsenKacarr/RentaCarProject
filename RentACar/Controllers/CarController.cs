using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentACar.CQRS.Handlers.CarHandlers;
using RentACar.DAL;


namespace RentACar.Controllers
{
    public class CarController : Controller
    {
        private readonly GetCarWithPricingQueryHandler _getCarWithPricingQueryHandler;

        public CarController(GetCarWithPricingQueryHandler getCarWithPricingQueryHandler)
        {
            _getCarWithPricingQueryHandler = getCarWithPricingQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _getCarWithPricingQueryHandler.Handle();
            return View(values);
        }

    }
}
