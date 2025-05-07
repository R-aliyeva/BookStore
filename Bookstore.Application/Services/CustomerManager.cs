using Bookstore.Application.DTOs.CustomerDTOs;
using BookStore.Domain.Entities;

namespace Bookstore.Application.Services
{
    public class CustomerManager:CrudManager<Customer,CustomerDTO,CustomerCreateDTO,CustomerUpdateDTO>
    {
      
    }
}
