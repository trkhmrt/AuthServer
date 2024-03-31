using System;
using AuthServer.Core.Dtos;
using SharedLibrary.Dto;

namespace AuthServer.Core.Services
{
	public interface IUserService
	{
		Task<Response<UserAddDto>> CreateUserAsync(CreateUserDto createUserDto);

        Task<Response<UserAddDto>> GetUserByNameAsync(string userName);


    }
}

