using Lab2.Data;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class AddressesController : Controller
    {
        private readonly DBContext _context;

        public AddressesController(DBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Address);
        }
    }
}
