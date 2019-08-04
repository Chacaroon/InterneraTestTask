using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using BLL.Abstractions;
using BLL.DTOs;
using DAL.Abstractions;
using DAL.Entities;

namespace BLL.Services
{
	public class ProductService : IProductService
	{
		private readonly IRepository<Product> _productRepository;

		public ProductService(IRepository<Product> productRepository)
		{
			_productRepository = productRepository;
		}

		public IEnumerable<ProductDTO> GetAll()
		{
			return _productRepository.GetAll()
									 .ProjectTo<ProductDTO>();

		}
	}
}
