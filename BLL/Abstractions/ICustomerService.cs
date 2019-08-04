using BLL.DTOs.Customer;
using System.Collections.Generic;

namespace BLL.Abstractions
{
	public interface ICustomerService
	{
		IEnumerable<CustomerDTO> GetAll();
	}
}
