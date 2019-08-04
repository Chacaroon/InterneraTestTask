using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
	public class SellerDTO
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public CompanyDTO Company { get; set; }
	}
}
