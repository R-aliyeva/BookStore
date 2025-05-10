using Bookstore.Application.DTOs.AuthorDTOs;
using Bookstore.Application.Services;
using Bookstore.Application.Validations.AuthorValidators;
using Microsoft.EntityFrameworkCore;

namespace BookStore.ConsoleUI;
public  class Authormembers
{
    public  void AddAuthor()
    {
        try
        {
            var authorManager = new AuthorManager();
            var validator = new AuthorValidator();

            Console.Write("Muellifin adını daxil edin:");
            var name = Console.ReadLine();

            Console.Write("Muellifin soyadini daxil edin:");
            var surName = Console.ReadLine();

            Console.Write("Muellifin milliyeti daxil edin:");
            var nationality = Console.ReadLine();

            Console.Write("Muellifin dogulduyu yer daxil edin:");
            var birthPlace = Console.ReadLine();

            Console.Write("Muellifin dogum tarixini daxil edin:");
            var birthDate = DateTime.Parse(Console.ReadLine());

            var authorCreatDto = new AuthorCreateDTO
            {
                Name = name,
                SurName = surName,
                Birthplace = birthPlace,
                Nationality = nationality,
                Birthdate = birthDate
            };
            var result = validator.Validate(authorCreatDto);
            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                authorManager.Add(authorCreatDto);
                Console.WriteLine($"Muellif elave edildi.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
       
    }
   public  void GetAllAuthor()
    {
        try
        {
            var authorManager = new AuthorManager();
            var list = authorManager.GetAll();

            Console.WriteLine($"{("Id"),-15}{("FullName"),-25}{("Nationality"),-15}{("Birthplace"),-15}{"Birthdate",-15}");
            Console.WriteLine(new string('-', 75));

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Id,-15}{item.FullName,-25}{item.Nationality,-15}{item.Birthplace,-15}{item.Birthdate,-15}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
    public void GetAllBooksofAuthor()
    {
        try
        {
            var authorManager = new AuthorManager();

            Console.WriteLine("Enter author ID:");
            var authorid = int.Parse(Console.ReadLine());

            if (authorid == 0)
            {
                Console.WriteLine("Enter Id");
            }

            var author = authorManager.Get(x => x.Id == authorid,
                include: y => y.Include(a => a.Books)
                .ThenInclude(z => z.Genre));

            var books = author.Books;

            Console.WriteLine($"{("Id"),-15}{("Name"),-25}{("Genre"),-25}");
            Console.WriteLine(new string('-', 55));

            foreach (var item in books)
            {
                Console.WriteLine($"{item.Id,-15}{item.Name,-25}{item.GenreName}");
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }   
}