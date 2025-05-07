using Bookstore.Application.DTOs.BookDTOs;
using Bookstore.Application.DTOs.StoreDTOs;
using Bookstore.Application.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.IO.Compression;

namespace BookStore.ConsoleUI;

public class BookMembers
{
    public void AddBook()
    {
        var storemanagment = new StoreManager();
        var bookmanager = new BookManager();
        Console.Write("Kitabin adını daxil edin:");
        var name = Console.ReadLine();
       
        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Enter name");
        }
        Console.Write("Kitabin genreni  daxil edin:");            
        GenreMembers.GetAllGenre();           
        var genreid = int.Parse(Console.ReadLine());
        if (string.IsNullOrEmpty(genreid.ToString()))
        {
            Console.WriteLine("Enter genre");
        }
        Console.Write("Kitabin muellifini  daxil edin:");
        Authormembers.GetAllAuthor();
        var authorid = int.Parse(Console.ReadLine());
        if (string.IsNullOrEmpty(authorid.ToString()))
        {
            Console.WriteLine("Enter name");
        }
        Console.Write("Kitabin qiymetini  daxil edin:");
        var price = decimal.Parse(Console.ReadLine());
        if (string.IsNullOrEmpty(price.ToString()))
        {
            Console.WriteLine("Enter price");
        }

        var bookcreatedto = new BookCreateDTO { Name = name, AuthorId = authorid, GenreId = genreid, Price = price };
        var addedbook=bookmanager.Add(bookcreatedto);
        Console.Write("Kitabin miqdarını daxil edin:");
        var amount = int.Parse(Console.ReadLine());
        if (string.IsNullOrEmpty(amount.ToString()))
        {
            Console.WriteLine("Enter amount");
        }
        
        var storecreatedto = new StoreCreateDTO {BookId=addedbook.Id,Amount=amount };
        storemanagment.Add(storecreatedto);
        

    }
    public void GetAllBooks()
    {
        var bookmanager = new BookManager();
        var books = bookmanager.GetAll(include: x => x.Include(y => y.Author)
        .Include(z=>z.Genre)
        .Include(r=>r.Store)
        .Include(r=>r.Store));
        Console.WriteLine($"{("Id"),-15}{("Name"),-25}{("Author"),-15}{("Genre"),-15}{"Amount",-15}{("price")}");
        Console.WriteLine(new string('-', 75));
        foreach (var item in books)
        {
            Console.WriteLine($"{item.Id,-15}{item.Name,-25}{item.AuthorFullName,-15}{item.GenreName,-15}{item.Amount,-15}{item.Price}");
        }
    }
    public void GetBook() 
    {
        Console.Write("Kitabin adini daxil edin:");
        string input= Console.ReadLine();
        var bookmanager = new BookManager();
        var result=bookmanager.Get(x=>x.Name.Contains(input));
        if (result != null)
        {

            Console.WriteLine($"{("Id"),-15}{("Name"),-25}{("Author"),-15}{("Genre"),-15}{"Amount",-15}{("price")}");
            Console.WriteLine(new string('-', 75));

            Console.WriteLine($"{result.Id,-15}{result.Name,-25}{result.AuthorFullName,-15}{result.GenreName,-15}{result.Amount,-15}{result.Price}");
        }
        else { Console.WriteLine("Axtarilan kitab tapilmadi"); }

    }
    public void UpdateBook() 
    { 
    GetAllBooks();
        Console.Write("Duzelis olunacaq kitabin ID sini secin");
        int input=int.Parse(Console.ReadLine());
        var bookmanager = new BookManager();

    
    }
    public void DeleteBook() { }
}