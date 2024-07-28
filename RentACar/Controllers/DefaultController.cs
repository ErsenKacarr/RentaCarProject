using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RentACar.DAL;
using RentACar.MediatorPattern.Queries.CarFeatureDetail;
using RentACar.MediatorPattern.Queries.LocationQueries;

namespace RentACar.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IMediator _mediator;
        private readonly Context _context;

        public DefaultController(IMediator mediator, Context context)
        {
            _mediator = mediator;
            _context = context;
        }

        public IActionResult Index()
        {
            List<SelectListItem> values = (from x in _context.Locations.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.LocationName,
                                               Value = x.LocationID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
    }
}
