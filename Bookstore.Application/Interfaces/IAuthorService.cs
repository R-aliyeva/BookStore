using Bookstore.Application.DTOs.AuthorDTOs;
using BookStore.Domain.Entities;

namespace Bookstore.Application.Interfaces;

public interface IAuthorService : ICrudService<Author, AuthorDTO, AuthorCreateDTO, AuthorUpdateDTO>
{
}
