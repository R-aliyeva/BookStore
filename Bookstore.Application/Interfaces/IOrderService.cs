using Bookstore.Application.DTOs.OrderDTOs;
using BookStore.Domain.Entities;

namespace Bookstore.Application.Interfaces;

public interface IOrderService : ICrudService<Order, OrderDTO, OrderCreateDTO, OrderUpdateDTO>
{
}
