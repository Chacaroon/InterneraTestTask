using DAL.Entities;

namespace DAL.Repositories
{
	public class DealRepository : Repository<Deal>
	{
		public DealRepository(ApplicationContext dbContext) : base(dbContext)
		{
		}
	}
}
