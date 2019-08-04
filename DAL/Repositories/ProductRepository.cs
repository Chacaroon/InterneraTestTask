using DAL.Entities;

namespace DAL.Repositories
{
	public class ProductRepository : Repository<Product>
	{
		public ProductRepository(ApplicationContext dbContext) : base(dbContext)
		{
		}
	}
}
