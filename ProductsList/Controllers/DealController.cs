using AutoMapper;
using BLL.Abstractions;
using BLL.DTOs.Deal;
using Microsoft.AspNetCore.Mvc;
using ProductsList.ViewModels.Deal;
using System.Collections.Generic;

namespace ProductsList.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DealController : ControllerBase
	{
		private readonly IDealService _dealService;

		public DealController(IDealService dealService)
		{
			_dealService = dealService;
		}

		[HttpGet]
		public ActionResult<IEnumerable<DealViewModel>> Get()
		{
			var res = Mapper.Map<IEnumerable<DealDTO>, IEnumerable<DealViewModel>>(_dealService.GetAll());

			return Ok(res);
		}

		[HttpPost]
		public ActionResult Post(AddDealViewModel model)
		{
			_dealService.Add(Mapper.Map<AddDealDTO>(model));

			return Ok();
		}
	}
}