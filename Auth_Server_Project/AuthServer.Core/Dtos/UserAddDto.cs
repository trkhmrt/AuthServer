using System;
namespace AuthServer.Core.Dtos
{
	public class UserAddDto
	{
		public int Id { get; set; }

		public string UserName { get; set; }

		public string Email { get; set; }

		public string City { get; set; }
	}
}

