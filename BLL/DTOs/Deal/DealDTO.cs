namespace BLL.DTOs
{
	public class DealDTO
	{
		public ProductDTO Product { get; set; }
		public CustomerDTO Customer { get; set; }
		public SellerDTO Seller { get; set; }

		public int ProductAmount { get; set; }
	}
}
