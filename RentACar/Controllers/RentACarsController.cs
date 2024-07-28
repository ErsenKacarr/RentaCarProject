using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentACar.MediatorPattern.Queries.RentACarQueries;

namespace RentACar.Controllers
{
    public class RentACarsController : Controller
    {
        private readonly IMediator _mediator;

        public RentACarsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetRentACarListByLocation(GetRentACarQuery query)
        {
            var values = await _mediator.Send(query);
            return View();
        }
    }
}
