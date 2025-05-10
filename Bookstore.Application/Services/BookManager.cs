using Bookstore.Application.DTOs.BookDTOs;
using BookStore.Domain.Entities;

namespace Bookstore.Application.Services;

public class BookManager : CrudManager<Book, BookDTO,BookCreateDTO , BookUpdateDTO>
{

}
