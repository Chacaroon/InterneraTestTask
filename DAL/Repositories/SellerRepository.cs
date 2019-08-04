using DAL.Entities;

namespace DAL.Repositories
{
	public class SellerRepository : Repository<Seller>
	{
		public SellerRepository(ApplicationContext dbContext) : base(dbContext)
		{
		}
	}
}
