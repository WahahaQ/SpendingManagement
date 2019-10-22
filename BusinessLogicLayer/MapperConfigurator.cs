using System;
using System.Linq.Expressions;
using DataAccessLayer.Entities;
using DTOLayer.DTOs;
using AutoMapper;

namespace BusinessLogicLayer
{
	public class MapperConfigurator : Profile
	{
		public MapperConfigurator()
		{
			CreateMap<User, UserDTO>();
			CreateMap<UserDTO, User>();
			CreateMap<Tag, TagDTO>();
			CreateMap<TagDTO, Tag>();
			CreateMap<Category, CategoryDTO>();
			CreateMap<CategoryDTO, Category>();
			CreateMap<Spending, SpendingDTO>();
			CreateMap<SpendingDTO, Spending>();

			CreateMap<Func<User, bool>, Func<UserDTO, bool>>();
			CreateMap<Func<UserDTO, bool>, Func<User, bool>>();
			CreateMap<Func<Tag, bool>, Func<TagDTO, bool>>();
			CreateMap<Func<TagDTO, bool>, Func<Tag, bool>>();
			CreateMap<Func<Category, bool>, Func<CategoryDTO, bool>>();
			CreateMap<Func<CategoryDTO, bool>, Func<Category, bool>>();
			CreateMap<Func<Spending, bool>, Func<SpendingDTO, bool>>();
			CreateMap<Func<SpendingDTO, bool>, Func<Spending, bool>>();

			CreateMap<Expression<Func<User, bool>>, Expression<Func<UserDTO, bool>>>();
			CreateMap<Expression<Func<UserDTO, bool>>, Expression<Func<User, bool>>>();
			CreateMap<Expression<Func<Tag, bool>>, Expression<Func<TagDTO, bool>>>();
			CreateMap<Expression<Func<TagDTO, bool>>, Expression<Func<Tag, bool>>>();
			CreateMap<Expression<Func<Category, bool>>, Expression<Func<CategoryDTO, bool>>>();
			CreateMap<Expression<Func<CategoryDTO, bool>>, Expression<Func<Category, bool>>>();
			CreateMap<Expression<Func<SpendingDTO, bool>>, Expression<Func<Spending, bool>>>();
			CreateMap<Expression<Func<Spending, bool>>, Expression<Func<SpendingDTO, bool>>>();
		}
	}
}