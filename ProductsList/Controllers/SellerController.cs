using AutoMapper;
using BLL.Abstractions;
using BLL.DTOs.Seller;
using Microsoft.AspNetCore.Mvc;
using ProductsList.ViewModels.Seller;
using System.Collections.Generic;

namespace ProductsList.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SellerController : ControllerBase
	{
		private readonly ISellerService _sellerService;

		public SellerController(ISellerService sellerService)
		{
			_sellerService = sellerService;
		}

		[HttpGet]
		public ActionResult<IEnumerable<SellerViewModel>> Get()
		{
			var res = Mapper.Map<IEnumerable<SellerDTO>, IEnumerable<SellerViewModel>>(_sellerService.GetAll());

			return Ok(res);
		}
	}
}