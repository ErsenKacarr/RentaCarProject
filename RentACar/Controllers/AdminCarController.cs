using Microsoft.AspNetCore.Mvc;
using RentACar.CQRS.Commands.CarCommands;
using RentACar.CQRS.Handlers.CarHandlers;
using RentACar.CQRS.Queries.CarQueries;

namespace RentACar.Controllers
{
    public class AdminCarController : Controller
    {
        private readonly CreateCarCommandHandler _createCarCommandHandler;
        private readonly RemoveCarCommandHandler _removeCarCommandHandler;
        private readonly GetCarByIdQueryHandler _getCarByIdQueryHandler;
        private readonly UpdateCarCommandHandler _updateCarCommandHandler;
        private readonly GetCarWithBrandQueryHandler _getCarWithBrandQueryHandler;

        public AdminCarController(CreateCarCommandHandler createCarCommandHandler, RemoveCarCommandHandler removeCarCommandHandler, UpdateCarCommandHandler updateCarCommandHandler, GetCarByIdQueryHandler getCarByIdQueryHandler,  GetCarWithBrandQueryHandler getCarWithBrandQueryHandler)
        {

            _createCarCommandHandler = createCarCommandHandler;
            _removeCarCommandHandler = removeCarCommandHandler;
            _updateCarCommandHandler = updateCarCommandHandler;
            _getCarByIdQueryHandler = getCarByIdQueryHandler;
            _getCarWithBrandQueryHandler = getCarWithBrandQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _getCarWithBrandQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateCar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCar(CreateCarCommand command)
        {
            _createCarCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        public IActionResult RemoveCar(int id)
        {
            _removeCarCommandHandler.Handle(new RemoveCarCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCar(int id)
        {
            var value = _getCarByIdQueryHandler.Handle(new GetCarByIdQuery(id));
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCar(UpdateCarCommand command)
        {
            _updateCarCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
