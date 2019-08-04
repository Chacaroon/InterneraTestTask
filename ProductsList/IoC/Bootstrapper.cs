using Microsoft.Extensions.DependencyInjection;

namespace ProductsList.IoC
{
	public static class Bootstrapper
	{
		public static void Bootstrap(IServiceCollection services)
		{
			BLL.IoC.Bootstrapper.Bootstrap(services);
		}
	}
}
