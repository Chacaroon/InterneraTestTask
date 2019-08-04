using AutoMapper.QueryableExtensions;
using BLL.Abstractions;
using BLL.DTOs.Customer;
using DAL.Abstractions;
using DAL.Entities;
using System.Collections.Generic;

namespace BLL.Services
{
	public class CustomerService : ICustomerService
	{
		private readonly IRepository<Customer> _customerRepository;

		public CustomerService(IRepository<Customer> customerRepository)
		{
			_customerRepository = customerRepository;
		}

		public IEnumerable<CustomerDTO> GetAll()
		{
			return _customerRepository.GetAll()
									  .ProjectTo<CustomerDTO>();
		}
	}
}
