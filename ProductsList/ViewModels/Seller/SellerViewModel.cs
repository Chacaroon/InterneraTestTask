using ProductsList.ViewModels.Company;

namespace ProductsList.ViewModels.Seller
{
	public class SellerViewModel
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public CompanyViewModel Company { get; set; }
	}
}
