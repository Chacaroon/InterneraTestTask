using AutoMapper;
using BLL.Abstractions;
using BLL.DTOs.Customer;
using Microsoft.AspNetCore.Mvc;
using ProductsList.ViewModels.Customer;
using System.Collections.Generic;

namespace ProductsList.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		private readonly ICustomerService _customerService;

		public CustomerController(ICustomerService customerService)
		{
			_customerService = customerService;
		}

		[HttpGet]
		public ActionResult<IEnumerable<CustomerViewModel>> Get()
		{
			var res = Mapper.Map<IEnumerable<CustomerDTO>, IEnumerable<CustomerViewModel>>(_customerService.GetAll());

			return Ok(res);
		}
	}
}