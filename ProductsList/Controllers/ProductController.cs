using AutoMapper;
using BLL.Abstractions;
using BLL.DTOs.Product;
using Microsoft.AspNetCore.Mvc;
using ProductsList.ViewModels.Product;
using System.Collections.Generic;

namespace ProductsList.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductService _productService;

		public ProductController(IProductService productService)
		{
			_productService = productService;
		}

		[HttpGet]
		public ActionResult<IEnumerable<ProductViewModel>> Get()
		{
			var res = Mapper.Map<IEnumerable<ProductDTO>, IEnumerable<ProductViewModel>>(_productService.GetAll());

			return Ok(res);
		}
	}
}