using BLL.DTOs.Company;

namespace BLL.DTOs.Seller
{
	public class SellerDTO
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public CompanyDTO Company { get; set; }
	}
}
