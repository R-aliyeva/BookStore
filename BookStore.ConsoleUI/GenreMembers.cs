using Bookstore.Application.DTOs.GenreDTOs;
using Bookstore.Application.Services;

namespace BookStore.ConsoleUI
{
    internal static class GenreMembers
    {


        public static void AddGenre()
        {
            var genremanager = new GenreManager();
            Console.Write("Genre adını daxil edin:");
            var name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Enter name");
            }
            Console.Write("Genre daxil edin:");

            var genrecreatedto = new GenreCreateDTO { Name = name };

            genremanager.Add(genrecreatedto);
        }
        public static void GetAllGenre()
        {
            var genremanager = new GenreManager();
            var list = genremanager.GetAll();
            foreach (var item in list)
            {
                Console.Write($"ID:{item.Id},Name:{item.Name}");
            }
        }
    }
}