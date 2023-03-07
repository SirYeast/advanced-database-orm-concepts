using Lab2.Data;
using Lab2.Models;
using Lab2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
	public class CustomersController : Controller
	{
		private readonly DBContext _context;

		public CustomersController(DBContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			return View(_context.Customer);
		}

		public IActionResult OwnsAddress(int customerId, int addressId)
		{
             CustomerOwnsAddressVM vm = new(_context.Customer.ToList(), _context.Address.ToList());

            if (customerId != 0 && addressId != 0)
            {
                Customer? customer = _context.Customer.FirstOrDefault(c => c.Id == customerId);
                Address? address = _context.Address.FirstOrDefault(a => a.Id == addressId);

                if (customer == null || address == null)
                    return BadRequest();

                vm.OwnsAddress = _context.CustomerAddress.Any(ca => ca.CustomerId == customerId && ca.AddressId == addressId && ca.IsOwner);
            }

            return View(vm);
        }

		[HttpPost]
		public IActionResult OwnsAddress(CustomerOwnsAddressVM vm)
		{
            try
            {
                Customer customer = _context.Customer.First(l => l.Id == vm.CustomerId);
                Address address = _context.Address.First(l => l.Id == vm.AddressId);
                return RedirectToAction("OwnsAddress", new { customerId = customer.Id, addressId = address.Id });
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
	}
}
