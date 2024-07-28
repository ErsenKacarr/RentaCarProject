using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentACar.MediatorPattern.Commands.PricingCommands;
using RentACar.MediatorPattern.Queries.PricingQueries;

namespace RentACar.Controllers
{
    public class AdminPricingController : Controller
    {
        private readonly IMediator _mediator;

        public AdminPricingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetPricingQuery());
            return View(values);
        }

        [HttpGet]
        public IActionResult CreatePricing()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreatePricing(CreatePricingCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> RemovePricing(int id)
        {
            await _mediator.Send(new RemovePricingCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdatePricing(int id)
        {
            var values = await _mediator.Send(new GetPricingByIdQuery(id));
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePricing(UpdatePricingCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
    }
}
