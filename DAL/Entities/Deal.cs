namespace DAL.Entities
{
	public class Deal : Entity
	{
		public int ProductAmount { get; set; }

		public long SellerId { get; set; }
		public Seller Seller { get; set; }

		public long CustomerId { get; set; }
		public Customer Customer { get; set; }

		public long ProductId { get; set; }
		public Product Product { get; set; }
	}
}
