using System.Collections.Generic;

namespace DAL.Entities
{
	public class Product : Entity
	{
		public string Name { get; set; }

		public ICollection<Deal> SellerCustomers { get; set; }
	}
}
