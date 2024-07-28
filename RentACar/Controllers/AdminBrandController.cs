using Microsoft.AspNetCore.Mvc;
using RentACar.CQRS.Commands.BrandCommands;
using RentACar.CQRS.Handlers.BrandHandlers;
using RentACar.CQRS.Queries.BrandQueries;

namespace RentACar.Controllers
{
    public class AdminBrandController : Controller
    {
        private readonly GetBrandQueryHandler _queryBrandHandler;
        private readonly CreateBrandCommandHandler _createBrandCommandHandler;
        private readonly RemoveBrandCommandHandler _removeBrandCommandHandler;
        private readonly GetBrandByIdQueryHandler _getBrandByIdQueryHandler;
        private readonly UpdateBrandCommandHandler _updateBrandCommandHandler;

        public AdminBrandController(GetBrandQueryHandler queryBrandHandler, CreateBrandCommandHandler createBrandCommandHandler, RemoveBrandCommandHandler removeBrandCommandHandler, GetBrandByIdQueryHandler getBrandByIdQueryHandler, UpdateBrandCommandHandler updateBrandCommandHandler)
        {
            _queryBrandHandler = queryBrandHandler;
            _createBrandCommandHandler = createBrandCommandHandler;
            _removeBrandCommandHandler = removeBrandCommandHandler;
            _getBrandByIdQueryHandler = getBrandByIdQueryHandler;
            _updateBrandCommandHandler = updateBrandCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _queryBrandHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateBrand()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBrand(CreateBrandCommand command)
        {
            _createBrandCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        public IActionResult RemoveBrand(int id)
        {
            _removeBrandCommandHandler.Handle(new RemoveBrandCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateBrand(int id)
        {
            var value = _getBrandByIdQueryHandler.Handle(new GetBrandByIdQuery(id));
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateBrand(UpdateBrandCommand command)
        {
            _updateBrandCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
