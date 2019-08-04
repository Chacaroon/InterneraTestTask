using AutoMapper;
using BLL.IoC.Profiles;

namespace BLL.IoC
{
	public static class MapperBootstrapper
	{
		public static void Bootstrap(IMapperConfigurationExpression cfg)
		{
			cfg.AddProfile<DealProfile>();
		}
	}
}
