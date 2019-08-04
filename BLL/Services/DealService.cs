using AutoMapper;
using AutoMapper.QueryableExtensions;
using BLL.Abstractions;
using BLL.DTOs.Deal;
using DAL.Abstractions;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BLL.Services
{
	public class DealService : IDealService
	{
		private readonly IRepository<Deal> _dealRepository;

		public DealService(IRepository<Deal> dealRepository)
		{
			_dealRepository = dealRepository;
		}

		public IEnumerable<DealDTO> GetAll()
		{
			return _dealRepository.GetAll()
								  .Include(d => d.Product)
								  .Include(d => d.Customer)
								  .Include(d => d.Seller)
									.ThenInclude(s => s.Company)
								  .ProjectTo<DealDTO>();
		}

		public void Add(AddDealDTO dealDto)
		{
			var deal = Mapper.Map<AddDealDTO, Deal>(dealDto);

			_dealRepository.Add(deal);
		}
	}
}
