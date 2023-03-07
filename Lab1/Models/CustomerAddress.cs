using Microsoft.EntityFrameworkCore;

namespace Lab2.Models
{
	[PrimaryKey(nameof(CustomerId), nameof(AddressId))]
	public class CustomerAddress
	{
		public int CustomerId { get; set; }
		public Customer Customer { get; set; }

		public int AddressId { get; set; }
		public Address Address { get; set; }
		public bool IsOwner { get; set; }

		public CustomerAddress() { }
	}
}
