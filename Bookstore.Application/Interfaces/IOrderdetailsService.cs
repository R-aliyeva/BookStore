using Bookstore.Application.DTOs.OrderDetailsDTOs;
using BookStore.Domain.Entities;

namespace Bookstore.Application.Interfaces;

public interface IOrderdetailsService : ICrudService<OrderDetails, OrderDetailsDTO, OrderDetailsCreateDTO, OrderDetailsUpdateDTO>
{
}
