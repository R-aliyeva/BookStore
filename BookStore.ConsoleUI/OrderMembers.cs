using Bookstore.Application.DTOs.BookDTOs;
using Bookstore.Application.DTOs.OrderDetailsDTOs;
using Bookstore.Application.DTOs.OrderDTOs;
using Bookstore.Application.Services;
using Microsoft.EntityFrameworkCore;

namespace BookStore.ConsoleUI;
public  class OrderMembers
{
    public void AddOrder()
    {
        try
        {
            var orderManager = new OrderManager();
            var orderDetailsManager = new OrderDetailManager();
            var customerMember = new CustomerMembers();
            var bookMember = new BookMembers();
            var bookManager = new BookManager();

            Console.WriteLine("Müştəri İd sini daxil edin:");
            customerMember.GetAllCustomer();
            var customerid = int.Parse(Console.ReadLine());

            Console.WriteLine("Kitabın İd sini daxil edin:");
            bookMember.GetAllBooks();
            var bookid = int.Parse(Console.ReadLine());
            var book = bookManager.Get(x => x.Id == bookid);

            Console.WriteLine("Kitabin sayını daxil edin:");
            var quantity = int.Parse(Console.ReadLine());
            if (quantity < book.Amount && quantity>0)
            {
                book.Amount -= quantity;
                var updatedbook = new BookUpdateDTO
                {
                    Id = book.Id,
                    Name = book.Name,
                    Amount = book.Amount,
                    Price = book.Price,
                    AuthorId = book.AuthorId,
                    GenreId = book.GenreId,
                };
                bookManager.Update(updatedbook);

                var ordercreatedto = new OrderCreateDTO { CustomerId = customerid };
                var created = orderManager.Add(ordercreatedto);
                var id = created.Id;

                var orderdetailscreatedto = new OrderDetailsCreateDTO { BookId = bookid, Quantity = quantity, OrderID = id };
                orderDetailsManager.Add(orderdetailscreatedto);
                Console.WriteLine($"{orderdetailscreatedto.OrderID} id li sifaris əlavə edildi.");
            }
            else
            {
                Console.WriteLine("Sifariş edilən miqdar mənfi və ya qalıq miqdardan çox ola bilməz...");
            }
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }  
    }
    
    public  void Orderdetails() 
    {
        try
        {
            var orderDetailsManager = new OrderDetailManager();
            var result = orderDetailsManager.GetAll(include: x => x.Include(z => z.Book).Include(t => t.Order));
            if (result == null)
            {
                Console.WriteLine("sifaris yoxdur.");
                return;
            }

            Console.WriteLine($"{("Id"),-15}{("Book Id"),-10}{("BookName"),-15}{("Orderstatus"),-15}{("Quantity"),-15}{"Price",-15}{"Total",-15}");
            Console.WriteLine(new string('-', 95));

            foreach (var item in result)
            {
                decimal total = item.Book.Price * item.Quantity;

                Console.WriteLine($"{item.OrderID,-15}{item.Book.Id,-10}{item.BookName,-15}{item.OrderStatus,-15}{item.Quantity,-15}{item.Book.Price,-15}{total,-15}");
            }
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
        
    }
}