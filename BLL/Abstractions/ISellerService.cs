using System;
using System.Collections.Generic;
using System.Text;
using BLL.DTOs;

namespace BLL.Abstractions
{
	public interface ISellerService
	{
		IEnumerable<SellerDTO> GetAll();
	}
}
