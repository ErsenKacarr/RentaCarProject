using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentACar.MediatorPattern.Queries.RentACarQueries;
using RentACar.MediatorPattern.Results.LocationResults;




namespace RentACar.Controllers
{
    public class RentACarListController : Controller
    {
        private readonly IMediator _mediator;

        public RentACarListController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [HttpPost]
        public async Task<IActionResult> Index([FromForm] GetLocationQueryResult model)
        {
            var locationID = model.LocationID;

            int id = int.Parse(locationID.ToString());
            var q = new GetRentACarQuery();
            q.LocationID = id;

            var values = await _mediator.Send(q);

            ViewBag.locationID = locationID;
            ViewBag.q = values;
            return View(values);
        }
    }
}
