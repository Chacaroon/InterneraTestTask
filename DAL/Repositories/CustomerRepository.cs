using DAL.Entities;

namespace DAL.Repositories
{
	public class CustomerRepository : Repository<Customer>
	{
		public CustomerRepository(ApplicationContext dbContext) : base(dbContext)
		{
		}
	}
}
