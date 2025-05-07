using BookStore.Domain.Entities;
using BookStore.Domain.Interfaces;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Infrastructure.EfCore.Repository
{
    public class AuthorRepository:EfCoreRepository<Author>,IAuthorRepository
    {
    }
}
