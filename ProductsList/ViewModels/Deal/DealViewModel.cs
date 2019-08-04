using ProductsList.ViewModels.Customer;
using ProductsList.ViewModels.Product;
using ProductsList.ViewModels.Seller;

namespace ProductsList.ViewModels.Deal
{
	public class DealViewModel
	{
		public SellerViewModel Seller { get; set; }
		public CustomerViewModel Customer { get; set; }
		public ProductViewModel Product { get; set; }

		public int ProductAmount { get; set; }
	}
}
