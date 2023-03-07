using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab2.Models.ViewModels
{
    public class CustomerOwnsAddressVM
    {
        public List<SelectListItem> Customers = new();
        public List<SelectListItem> Addresses = new();

        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public bool OwnsAddress { get; set; }

        public CustomerOwnsAddressVM() { }

        public CustomerOwnsAddressVM(List<Customer> customers, List<Address> addresses)
        {
            foreach (Customer customer in customers)
            {
                Customers.Add(new SelectListItem($"{customer.FirstName} {customer.LastName}", customer.Id.ToString()));
            }

            foreach (Address address in addresses)
            {
                Addresses.Add(new SelectListItem($"{address.AddressLine1} {address.City}", address.Id.ToString()));
            }
        }
    }
}
