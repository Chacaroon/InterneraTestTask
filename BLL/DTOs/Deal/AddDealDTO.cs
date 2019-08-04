namespace BLL.DTOs.Deal
{
	public class AddDealDTO
	{
		public long SellerId { get; set; }
		public long CustomerId { get; set; }
		public long ProductId { get; set; }
		public int ProductAmount { get; set; }
	}
}
