﻿using System;
using System.Linq.Expressions;
using SharedLibrary.Dto;

namespace AuthServer.Core.Services
{
	public interface IServiceGeneric<TEntity,TDto> where TEntity : class where TDto : class
	{
        Task<Response<TDto>> GetByIdAsync(int id);

        Task<Response<IEnumerable<TDto>>> GetAllAsync();

        Response<IEnumerable<TDto>> Where(Expression<Func<TEntity, bool>> predicate);

        Task<Response<TDto>> AddAsync(TEntity entity);

        Task<Response<NoDataDto>> Remove(TEntity entity);


        Task<Response<NoDataDto>> Update(TEntity enttiy);

    }
}

