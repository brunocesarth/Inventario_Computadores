using Inventario.Models;
using Inventario.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Inventario.Controllers
{
    public class ComputerController : Controller
    {
        private readonly IComputerRepository _computerRepository;

        public ComputerController(IComputerRepository computerRepository)
        {
            _computerRepository = computerRepository;
        }

        public IActionResult List()
        {
            var computers = _computerRepository.Computers.OrderBy(c => c.ComputerId);
            return View(computers);
        }

        public IActionResult Details(string computerId)
        {
            var computador = _computerRepository.Computers.FirstOrDefault(pc => pc.ComputerId == computerId);

            if (computador == null)
            {
                return View("Error");
            }
            return View(computador);
        }

        public IActionResult Edit(string computerId)
        {
            if (computerId == null)
            {
                return NotFound();
            }

            var computador = _computerRepository.GetComputerByComputerId(computerId);
            if (computador == null)
            {
                return NotFound();
            }

            return View(computador);
        }
    }
}
