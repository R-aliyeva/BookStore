using BookStore.Domain.Entities;
using BookStore.Domain.Interfaces;

namespace BookStore.Infrastructure.EfCore.Repository
{
    public class OrderDetailsRepository : EfCoreRepository<OrderDetails>, IOrderDetailsRepository
    {
    }
}
