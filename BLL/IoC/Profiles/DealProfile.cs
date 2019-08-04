using AutoMapper;
using BLL.DTOs.Deal;
using DAL.Entities;

namespace BLL.IoC.Profiles
{
	class DealProfile : Profile
	{
		public DealProfile()
		{
			CreateMap<AddDealDTO, Deal>()
				.ForMember(d => d.Id, cfg => cfg.Ignore())
				.ForMember(d => d.Product, cfg => cfg.Ignore())
				.ForMember(d => d.Customer, cfg => cfg.Ignore())
				.ForMember(d => d.Seller, cfg => cfg.Ignore());
		}
	}
}
