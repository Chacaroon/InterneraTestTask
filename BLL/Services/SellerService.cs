using AutoMapper.QueryableExtensions;
using BLL.Abstractions;
using BLL.DTOs.Seller;
using DAL.Abstractions;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BLL.Services
{
	public class SellerService : ISellerService
	{
		private readonly IRepository<Seller> _sellerRepository;

		public SellerService(IRepository<Seller> sellerRepository)
		{
			_sellerRepository = sellerRepository;
		}

		public IEnumerable<SellerDTO> GetAll()
		{
			return _sellerRepository.GetAll()
									.Include(s => s.Company)
									.ProjectTo<SellerDTO>();
		}
	}
}
