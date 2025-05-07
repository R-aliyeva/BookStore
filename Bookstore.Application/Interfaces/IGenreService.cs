using Bookstore.Application.DTOs.GenreDTOs;
using BookStore.Domain.Entities;

namespace Bookstore.Application.Interfaces
{
    public interface IGenreService : ICrudService<Genre, GenreDTO, GenreCreateDTO, GenreUpdateDTO>
    {
    }
}
