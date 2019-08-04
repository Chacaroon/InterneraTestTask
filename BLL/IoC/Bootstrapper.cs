using BLL.Abstractions;
using BLL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.IoC
{
	public static class Bootstrapper
	{
		public static void Bootstrap(IServiceCollection services)
		{
			services.AddTransient<IDealService, DealService>();
			services.AddTransient<IProductService, ProductService>();
			services.AddTransient<ISellerService, SellerService>();
			services.AddTransient<ICustomerService, CustomerService>();

			DAL.IoC.Bootstrapper.Bootstrap(services);
		}
	}
}
