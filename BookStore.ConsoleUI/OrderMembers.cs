using Bookstore.Application.DTOs.OrderDetailsDTOs;
using Bookstore.Application.DTOs.OrderDTOs;
using Bookstore.Application.Services;
using BookStore.Infrastructure.EfCore.DataContext;

namespace BookStore.ConsoleUI
{
    internal static class OrderMembers
    {


        public static void AddOrder()
        {
            var ordermanager = new OrderManager();
            var orderdetailsmanager = new OrderDetailManager();

            Console.WriteLine("enter customer id:");
            var customerid = int.Parse(Console.ReadLine());

            Console.WriteLine("end book id:");
            var bookid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter quantity:");
            var quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("enter date");

            var ordercreatedto = new OrderCreateDTO { CustomerId = customerid };
            var created = ordermanager.Add(ordercreatedto);
            var id = created.Id;

            var orderdetailscreatedto = new OrderDetailsCreateDTO { BookId = bookid, Quantity = quantity, OrderID = id };
            orderdetailsmanager.Add(orderdetailscreatedto);
        }

        public static void Orderdetails() { }
    }
}