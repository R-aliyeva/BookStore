using Bookstore.Application.DTOs.AuthorDTOs;
using BookStore.Domain.Entities;

namespace Bookstore.Application.Services;

public class AuthorManager : CrudManager<Author, AuthorDTO, AuthorCreateDTO, AuthorUpdateDTO>
{
}
