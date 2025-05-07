using Bookstore.Application.DTOs.AuthorDTOs;
using Bookstore.Application.Services;
using Microsoft.EntityFrameworkCore;

namespace BookStore.ConsoleUI
{
    internal static class Authormembers
    {


        public static void AddAuthor()
        {
            var authormanager = new AuthorManager();
            Console.Write("Muellifin adını daxil edin:");
            var name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Enter name");
            }
            Console.Write("Muellifin soyadini daxil edin:");
            var surname = Console.ReadLine();
            if (string.IsNullOrEmpty(surname))
            {
                Console.WriteLine("Enter Surname");
            }
            Console.Write("Muellifin milliyeti daxil edin:");
            var nationality = Console.ReadLine();
            if (string.IsNullOrEmpty(nationality))
            {
                Console.WriteLine("Enter Surname");
            }
            Console.Write("Muellifin dogulduyu yer daxil edin:");
            var birthplace = Console.ReadLine();
            if (string.IsNullOrEmpty(birthplace))
            {
                Console.WriteLine("Enter Surname");
            }
            Console.Write("Muellifin dogum tarixini daxil edin:");
            var birthdate = DateTime.Parse(Console.ReadLine());
            var authorcreatdto = new AuthorCreateDTO { Name = name, SurName = surname, Birthplace = birthplace, Nationality = nationality, Birthdate = birthdate };
            authormanager.Add(authorcreatdto);
        }
       public static void GetAllAuthor()
        {
            var authormanager = new AuthorManager();
            var list = authormanager.GetAll();
            foreach (var item in list)
            {
                Console.Write($"ID:{item.Id},Name:{item.Name}");
            }
        }
        public static void GetAllBooksofAuthor()
        {
            var authormanager = new AuthorManager();
            Console.WriteLine("Enter author ID:");
            var authorid = int.Parse(Console.ReadLine());
            if (authorid == 0)
            {
                Console.WriteLine("Enter Id");
            }

            var author = authormanager.Get(x => x.Id == authorid, include: y => y.Include(a => a.Books).ThenInclude(z => z.Genre));
            var books = author.Books;
            foreach (var item in books)
            {
                Console.WriteLine($"{item.Name},{item.GenreName}");
            }

        }
    }
}