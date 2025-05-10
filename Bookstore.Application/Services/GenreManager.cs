using Bookstore.Application.DTOs.GenreDTOs;
using BookStore.Domain.Entities;

namespace Bookstore.Application.Services;

public class GenreManager : CrudManager<Genre, GenreDTO, GenreCreateDTO, GenreUpdateDTO>
{
}
