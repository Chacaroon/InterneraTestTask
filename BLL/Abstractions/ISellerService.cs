using BLL.DTOs.Seller;
using System.Collections.Generic;

namespace BLL.Abstractions
{
	public interface ISellerService
	{
		IEnumerable<SellerDTO> GetAll();
	}
}
