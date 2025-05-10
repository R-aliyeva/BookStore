using Bookstore.Application.DTOs.OrderDTOs;
using BookStore.Domain.Entities;

namespace Bookstore.Application.Services;

public class OrderManager : CrudManager<Order, OrderDTO, OrderCreateDTO, OrderUpdateDTO>
{
}
