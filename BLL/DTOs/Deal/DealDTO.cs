using BLL.DTOs.Customer;
using BLL.DTOs.Product;
using BLL.DTOs.Seller;

namespace BLL.DTOs.Deal
{
	public class DealDTO
	{
		public ProductDTO Product { get; set; }
		public CustomerDTO Customer { get; set; }
		public SellerDTO Seller { get; set; }

		public int ProductAmount { get; set; }
	}
}
