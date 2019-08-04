using BLL.DTOs.Product;
using System.Collections.Generic;

namespace BLL.Abstractions
{
	public interface IProductService
	{
		IEnumerable<ProductDTO> GetAll();
	}
}
