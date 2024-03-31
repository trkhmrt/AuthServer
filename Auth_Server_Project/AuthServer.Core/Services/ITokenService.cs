﻿using System;
using AuthServer.Core.Configuration;
using AuthServer.Core.Dtos;
using AuthServer.Core.Models;

namespace AuthServer.Core.Services
{
	public interface ITokenService
	{
		TokenDto CreateToken(UserApp userApp);

		ClientTokenDto CreateTokenByClient(Client client);
	}
}

