using BookStore.Domain.Entities;
using BookStore.Domain.Interfaces;

namespace BookStore.Infrastructure.EfCore.Repository;

public class AuthorRepository:EfCoreRepository<Author>,IAuthorRepository
{
}
