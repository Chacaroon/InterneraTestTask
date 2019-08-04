using BLL.DTOs.Deal;
using System.Collections.Generic;

namespace BLL.Abstractions
{
	public interface IDealService
	{
		IEnumerable<DealDTO> GetAll();
		void Add(AddDealDTO dealDto);
	}
}
