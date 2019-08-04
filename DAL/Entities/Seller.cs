namespace DAL.Entities
{
	public class Seller : Entity
	{
		public string Name { get; set; }

		public long CompanyId { get; set; }
		public Company Company { get; set; }
	}
}
