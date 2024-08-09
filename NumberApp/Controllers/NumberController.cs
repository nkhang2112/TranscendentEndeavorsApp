using Microsoft.AspNetCore.Mvc;
using NumberApp.Data;
using NumberApp.Models;
using System.Threading.Tasks;

namespace NumberApp.Controllers
{
    public class NumberController : Controller
    {
        private readonly NumberContext _context;

        public NumberController(NumberContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(int inputNumber)
        {
            var multipliedNumber = inputNumber * 2;
            var multipliedSquaredNumber = multipliedNumber * multipliedNumber;

            var numberEntry = new NumberEntry
            {
                InputNumber = inputNumber,
                MultipliedNumber = multipliedNumber,
                MultipliedSquaredNumber = multipliedSquaredNumber
            };

            _context.NumberEntries.Add(numberEntry);
            await _context.SaveChangesAsync();

            ViewBag.MultipliedNumber = multipliedNumber;
            ViewBag.MultipliedSquaredNumber = multipliedSquaredNumber;

            return View(numberEntry);
        }
    }
}
