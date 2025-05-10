using Bookstore.Application.DTOs.BookDTOs;
using Bookstore.Application.Services;
using Bookstore.Application.Validations.NewFolder;
using Microsoft.EntityFrameworkCore;

namespace BookStore.ConsoleUI;

public class BookMembers
{
    public void AddBook()
    {
        try
        {
            var bookManager = new BookManager();
            var genreMember = new GenreMembers();
            var authurMember = new Authormembers();
            var validator = new BookValidator();

            Console.Write("Kitabin adını daxil edin:");
            string? name = Console.ReadLine();


            Console.WriteLine("Kitabin genreni  daxil edin:");
            genreMember.GetAllGenre();
            var genreid = int.Parse(Console.ReadLine());

            Console.WriteLine("Kitabin muellifini  daxil edin:");
            authurMember.GetAllAuthor();
            var authorid = int.Parse(Console.ReadLine());

            decimal price;
            while (true)
            {
                Console.Write("Qiyməti daxil edin: ");
                string input = Console.ReadLine();

                if (decimal.TryParse(input, out price) && price > 0)
                    break;

                Console.WriteLine("Zəhmət olmasa düzgün və 0-dan böyük ədəd daxil edin.");
            }
            int amount;
            while (true)
            {
                Console.Write("Miqdarı daxil edin: ");
                string inputamount = Console.ReadLine();

                if (int.TryParse(inputamount, out amount) && amount > 0)
                    break;

                Console.WriteLine("Zəhmət olmasa düzgün və 0-dan böyük ədəd daxil edin.");
            }
            var bookcreatedto = new BookCreateDTO
            {
                Name = name,
                AuthorId = authorid,
                GenreId = genreid,
                Price = price,
                Amount = amount
            };

            var result = validator.Validate(bookcreatedto);

            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                try
                {
                    var addedbook = bookManager.Add(bookcreatedto);
                    Console.WriteLine($"{addedbook.Id} id ile {addedbook.Name} adlı kitab əlavə edildi.");
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
        
    }

    public void GetAllBooks()
    {
        try
        {
            var bookmanager = new BookManager();

            var books = bookmanager.GetAll(
             include: x => x.Include(y => y.Author)
            .Include(z => z.Genre));

            Console.WriteLine($"{("Id"),-15}{("Name"),-15}{("Author"),-25}{("Genre"),-15}{"Amount",-15}{("price")}");
            Console.WriteLine(new string('-', 95));

            foreach (var item in books)
            {
                Console.WriteLine($"{item.Id,-15}{item.Name,-15}{item.AuthorFullName,-25}{item.GenreName,-15}{item.Amount,-15}{item.Price}");
            }
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }   
    }

    public void GetBook()
    {
        try
        {
            Console.Write("Kitabin adini daxil edin:");
            string input = Console.ReadLine();
            var bookmanager = new BookManager();

            var result = bookmanager.GetAll(x => x.Name.Contains(input), include: x => x.Include(t => t.Author).Include(z => z.Genre));
            if (result != null)
            {

                Console.WriteLine($"{("Id"),-15}{("Name"),-25}{("Author"),-25}{("Genre"),-15}{"Amount",-15}{("price")}");
                Console.WriteLine(new string('-', 75));
                foreach (var item in result)
                {
                    Console.WriteLine($"{item.Id,-15}{item.Name,-25}{item.AuthorFullName,-25}{item.GenreName,-15}{item.Amount,-15}{item.Price}");
                }
            }
            else
            {
                Console.WriteLine("Axtarilan kitab tapilmadi");
            }
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }
        
    public void UpdateBook() 
    {
        try
        {
            var genreMember = new GenreMembers();
            var authurMember = new Authormembers();
            var updateValidator = new BookUpdateValidator();
            var bookManager = new BookManager();

            GetAllBooks();

            Console.Write("Duzelis olunacaq kitabin ID sini secin:");
            int input = int.Parse(Console.ReadLine());

            var book = bookManager.Get(x => x.Id == input,
            include: t => t.Include(t => t.Genre)
            .Include(y => y.Author));

            string newName = book.Name;
            int newAuthorid = book.AuthorId;
            int newGenreId = book.GenreId;
            int newAmount = book.Amount;
            decimal newPrice = book.Price;

            Console.WriteLine($"{("Id"),-15}{("Name"),-15}{("Author"),-25}{("Genre"),-15}{"Amount",-15}{("price")}");
            Console.WriteLine(new string('-', 95));
            Console.WriteLine($"{book.Id,-15}{book.Name,-15}{book.AuthorFullName,-25}{book.GenreName,-15}{book.Amount,-15}{book.Price}");

            Console.Write("Adi deyismek isteyirsiniz?(B/X): ");
            string? answerName = Console.ReadLine().ToLower();

            if (answerName == "b")
            {
                Console.Write("Yeni adi daxil edin: ");
                newName = Console.ReadLine();
            }

            Console.Write("Yazicini deyismek isteyirsiniz?(B/X): ");
            string? answerAuthor = Console.ReadLine().ToLower();

            if (answerAuthor == "b")
            {
                authurMember.GetAllAuthor();
                Console.Write("Yeni yazicininin IDsini  daxil edin: ");
                newAuthorid = int.Parse(Console.ReadLine());
            }

            Console.Write("Janri deyismek isteyirsiniz?(B/X): ");
            string? answerGenre = Console.ReadLine().ToLower();

            if (answerGenre == "b")
            {
                genreMember.GetAllGenre();
                Console.WriteLine("Yeni janrin Idsini daxil edin: ");
                newGenreId = int.Parse(Console.ReadLine());
            }

            Console.Write("Miqdari deyismek isteyirsiniz?(B/X): ");
            string? answerAmount = Console.ReadLine().ToLower();

            if (answerAmount == "b")
            {
                Console.WriteLine("Yeni miqdari daxil edin: ");
                newAmount = int.Parse(Console.ReadLine());
            }

            Console.Write("Qiymeti deyismek isteyirsiniz?(B/X): ");
            string? answerPrice = Console.ReadLine().ToLower();

            if (answerPrice == "b")
            {
                Console.Write("Yeni qiymeti daxil edin: ");
                newPrice = int.Parse(Console.ReadLine());
            }
            var updatedbookdto = new BookUpdateDTO
            {
                Id = book.Id,
                AuthorId = newAuthorid,
                GenreId = newGenreId,
                Name = newName,
                Price = newPrice,
                Amount = newAmount
            };
            var result = updateValidator.Validate(updatedbookdto);

            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            bookManager.Update(updatedbookdto);
            Console.WriteLine($"{updatedbookdto.Id} id li kitaba düzəliş edildi.");
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
        
    }

    public void DeleteBook()
    {
        try
        {
            GetAllBooks();

            var bookManager = new BookManager();
            var orderDetailsManager = new OrderDetailManager();

            Console.Write("Silinecek kitabin Id sini daxil edin: ");
            var deletedId = int.Parse(Console.ReadLine());

            var book = bookManager.Get(x => x.Id == deletedId);
            var orderedBook = orderDetailsManager.Get(x => x.BookId == deletedId);

            if (book == null)
            {
                Console.WriteLine("bu kitab üçün sifariş mövcuddur silinə bilməz.");
                return;
            }

            if (orderedBook != null)
            {
                Console.WriteLine("bu kitab üçün sifariş mövcuddur silinə bilməz.");
                return;
            }

            bookManager.Delete(deletedId);
            Console.WriteLine($"{book.Id} id-li və {book.Name} adında kitab silindi.");

            GetAllBooks();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        } 
    }
}