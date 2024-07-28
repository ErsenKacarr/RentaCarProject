using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentACar.MediatorPattern.Commands.LocationCommands;
using RentACar.MediatorPattern.Queries.LocationQueries;

namespace RentACar.Controllers
{
    public class AdminLocationController : Controller
    {
        private readonly IMediator _mediator;

        public AdminLocationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetLocationQuery());
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateLocation()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateLocation(CreateLocationCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> RemoveLocation(int id)
        {
            await _mediator.Send(new RemoveLocationCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateLocation(int id)
        {
            var values = await _mediator.Send(new GetLocationByIdQuery(id));
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateLocation(UpdateLocationCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
    }
}
