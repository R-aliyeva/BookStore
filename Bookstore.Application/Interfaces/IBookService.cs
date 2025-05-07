using Bookstore.Application.DTOs.BookDTOs;
using BookStore.Domain.Entities;

namespace Bookstore.Application.Interfaces
{
    public interface IBookService : ICrudService<Book, BookDTO, BookCreateDTO, BookUpdateDTO>
    {
    }
}
