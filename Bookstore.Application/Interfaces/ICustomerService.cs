using Bookstore.Application.DTOs.CustomerDTOs;
using BookStore.Domain.Entities;
using BookStore.Infrastructure.EfCore.Repository;

namespace Bookstore.Application.Interfaces;

public interface ICustomerService:ICrudService<Customer,CustomerDTO,CustomerCreateDTO,CustomerUpdateDTO>
{
}
