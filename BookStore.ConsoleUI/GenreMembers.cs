using Bookstore.Application.DTOs.GenreDTOs;
using Bookstore.Application.Services;
using Bookstore.Application.Validations.GenreValidators;

namespace BookStore.ConsoleUI;
public  class GenreMembers
{
    public void AddGenre()
    {
        try
        {
            var genreManager = new GenreManager();
            var validator = new GenreValidator();

            Console.Write("Genre adını daxil edin:");
            var name = Console.ReadLine();

            var genrecreatedto = new GenreCreateDTO { Name = name };
            var result = validator.Validate(genrecreatedto);

            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                genreManager.Add(genrecreatedto);
            }
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
        
    }

    public  void GetAllGenre()
    {
        var genremanager = new GenreManager();
        var list = genremanager.GetAll();
        Console.WriteLine($"{("Id"),-15}{("Name"),-25}");
        Console.WriteLine(new string('-', 30));

        foreach (var item in list)
        {
            Console.WriteLine($"{item.Id,-15}{item.Name,-25}");
        }
    }
}